using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BookAccounting.Data.Models;
using BookAccounting.Data.Repositories;

namespace BookAccounting.Forms
{
    public partial class MainForm : Form
    {
        BindingSource currentBindingSource;
        bool filtersFromBufferAreLoading;

        private BooksRepository booksRepository = new BooksRepository();
        private ReadersRepository readersRepository = new ReadersRepository();
        private IssuedBooksRepository issuedBooksRepository = new IssuedBooksRepository();

        static List<DataGridViewRow> bookFiltersBuffer = new List<DataGridViewRow>();
        static List<DataGridViewRow> readerFiltersBuffer = new List<DataGridViewRow>();
        static List<DataGridViewRow> issuedBooksFiltersBuffer = new List<DataGridViewRow>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = booksRepository.GetAll();
            readerBindingSource.DataSource = readersRepository.GetAll();
            issuedBooksBindingSource.DataSource = issuedBooksRepository.GetAll();
            currentBindingSource = bookBindingSource;
//            FieldFilterTableColumn.Items.AddRange(FilterController.filterTableColumnsNames.Keys.ToArray());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
//            db.Dispose();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditBookForm(null, booksRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bookBindingSource.DataSource = booksRepository.GetAll().ToList();
                }
            }
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null)
                return;

            using (var form = new AddEditBookForm((Book) bookBindingSource.Current, booksRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bookBindingSource.ResetCurrentItem();
                }
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Сообщение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var relatedIssuedBooks = issuedBooksRepository.GetAll()
                        .Where(b => b.IdBook == ((Book) bookBindingSource.Current).Id).ToList();

                    if (relatedIssuedBooks.Any())
                    {
                        if (MessageBox.Show(
                                String.Format(
                                    "Чтобы удалить эту книгу, нужно удалить все выданные книги ({0} записей) связанные с ней." +
                                    " " +
                                    "Хотите продожить?",
                                    relatedIssuedBooks.Count),
                                "Сообщение",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            foreach (var issuedBook in relatedIssuedBooks)
                            {
                                issuedBooksRepository.Delete(issuedBook);
                                issuedBooksBindingSource.Remove(issuedBook);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

                    booksRepository.Delete((Book) bookBindingSource.Current);
                    bookBindingSource.RemoveCurrent();
                }
            }
        }

        private void BtnAddReader_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditReaderForm(null, readersRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    readerBindingSource.DataSource = readersRepository.GetAll().ToList();
                }
            }
        }

        private void BtnEditReader_Click(object sender, EventArgs e)
        {
            if (readerBindingSource.Current == null)
                return;

            using (var form = new AddEditReaderForm((Reader) readerBindingSource.Current, readersRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    readerBindingSource.ResetCurrentItem();
                }
            }
        }

        private void BtnDeleteReader_Click(object sender, EventArgs e)
        {
            if (readerBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Сообщение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (issuedBooksRepository.GetAll()
                        .Any(b => b.IdReader == ((Reader) readerBindingSource.Current).Id))
                    {
                        MessageBox.Show(
                            "Вам нужно сначало удалить все выданные книги на этого читателя," +
                            " " +
                            "прежде чем вы сможете его удалить.",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    readersRepository.Delete((Reader) readerBindingSource.Current);
                    readerBindingSource.RemoveCurrent();
                }
            }
        }

        private void BtnAddIssuedBook_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null || readerBindingSource.Current == null)
                return;

            if (((Book) bookBindingSource.Current).Count <= 0)
            {
                MessageBox.Show("Вы не можете выдать эту книгу. Количество книг равно нулю.", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new AddEditIssuedBookForm(null, (Book) bookBindingSource.Current,
                (Reader) readerBindingSource.Current, issuedBooksRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    issuedBooksBindingSource.DataSource = issuedBooksRepository.GetAll().ToList();
                }
            }
        }

        private void BtnEditIssuedBook_Click(object sender, EventArgs e)
        {
            var issuedBook = issuedBooksBindingSource.Current as IssuedBook;

            if (issuedBook == null)
                return;

            var reader = readersRepository.GetAll().FirstOrDefault(r => r.Id == issuedBook.IdReader);
            var book = booksRepository.GetAll().FirstOrDefault(b => b.Id == issuedBook.IdBook);

            using (var form = new AddEditIssuedBookForm(issuedBook, book,
                reader, issuedBooksRepository))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    issuedBooksBindingSource.ResetCurrentItem();
                }
            }
        }

        private void BtnDeleteIssuedBook_Click(object sender, EventArgs e)
        {
            if (issuedBooksBindingSource.Current != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Сообщение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var issuedBook = (IssuedBook) issuedBooksBindingSource.Current;

                    issuedBooksRepository.Delete(issuedBook);

                    var book = booksRepository
                        .GetAll()
                        .FirstOrDefault(b => b.Id == issuedBook.IdBook);

                    if (book == null)
                        MessageBox.Show("Внимание, книга на возврат отсутствует в базе!", "Сообщение",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    issuedBooksBindingSource.RemoveCurrent();
                }
            }
        }

        private void DataGridViewFilters_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridViewFilters["FieldFilterTableColumn", e.RowIndex] ==
                dataGridViewFilters[e.ColumnIndex, e.RowIndex])
            {
                var cellValue = dataGridViewFilters[e.ColumnIndex, e.RowIndex].Value.ToString();
                var propertyType = currentBindingSource.DataSource
                    .GetType()
                    .GetGenericArguments()[0]
                    .GetProperty(FilterController.filterTableColumnsNames[cellValue])
                    .PropertyType;

                var conditionsCell = new DataGridViewComboBoxCell();

                conditionsCell.Items.AddRange(FilterController.numberConditions);
                dataGridViewFilters["ConditionFilterTableColumn", e.RowIndex] = conditionsCell;
                dataGridViewFilters["ConditionFilterTableColumn", e.RowIndex].Value =
                    FilterController.numberConditions.First();
                dataGridViewFilters["ValueFilterTableColumn", e.RowIndex] = new DataGridViewTextBoxCell();

                if (propertyType == typeof(int) || propertyType == typeof(int?))
                {
                    dataGridViewFilters["ValueFilterTableColumn", e.RowIndex].Value = "1";
                }
                else if (propertyType == typeof(DateTime))
                {
                    var calendarCell = new CalendarCell();
                    calendarCell.Value = DateTime.Now;
                    dataGridViewFilters["ValueFilterTableColumn", e.RowIndex] = calendarCell;
                }
                else
                {
                    conditionsCell.Items.Clear();
                    conditionsCell.Items.AddRange(FilterController.stringConditions);
                    dataGridViewFilters["ConditionFilterTableColumn", e.RowIndex].Value =
                        FilterController.stringConditions.First();
                }
            }
        }

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            var filters = FilterController.GetFilters(dataGridViewFilters);
            var entityType = currentBindingSource.DataSource.GetType().GetGenericArguments()[0];
//                currentBindingSource.DataSource = FilterController.ApplyFilters(db, entityType, filters);
        }

        private void BtnAddFilter_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilters.Rows.Count < 5)
                dataGridViewFilters.Rows.Add();
        }

        private void BtnDeleteFilter_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilters.CurrentRow == null)
                return;
            dataGridViewFilters.Rows.Remove(dataGridViewFilters.CurrentRow);
        }

        private void TabControlTables_Selecting(object sender, TabControlCancelEventArgs e)
        {
            dataGridViewFilters.Rows.Clear();
            filtersFromBufferAreLoading = true;
            if (e.TabPage == tabPageBooks)
            {
                currentBindingSource = bookBindingSource;
                FilterController.filterTableColumnsNames = Localization.localNamesBook;
                dataGridViewFilters.Rows.AddRange(bookFiltersBuffer.ToArray());
            }
            else if (e.TabPage == tabPageReaders)
            {
                currentBindingSource = readerBindingSource;
                FilterController.filterTableColumnsNames = Localization.localNamesReaders;
                dataGridViewFilters.Rows.AddRange(readerFiltersBuffer.ToArray());
            }
            else
            {
                currentBindingSource = issuedBooksBindingSource;
                FilterController.filterTableColumnsNames = Localization.localNamesIssuedBooksView;
                dataGridViewFilters.Rows.AddRange(issuedBooksFiltersBuffer.ToArray());
            }

            filtersFromBufferAreLoading = false;
            FieldFilterTableColumn.Items.Clear();
            FieldFilterTableColumn.Items.AddRange(FilterController.filterTableColumnsNames.Keys.ToArray());
        }

        private void DataGridViewFilters_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowCount <= 0 || filtersFromBufferAreLoading) return;
            ((DataGridView) sender).Rows[e.RowIndex].Cells["UsedFilterTableColumn"].Value = true;
            ((DataGridView) sender).Rows[e.RowIndex].Cells["OperatorFilterTableColumn"].Value =
                OperatorFilterTableColumn.Items[0];
            ((DataGridView) sender).Rows[e.RowIndex].Cells["FieldFilterTableColumn"].Value =
                FilterController.filterTableColumnsNames.Keys.First();
            ((DataGridView) sender).Rows[e.RowIndex].Cells["ConditionFilterTableColumn"].Value = "=";
            ((DataGridView) sender).Rows[e.RowIndex].Cells["ValueFilterTableColumn"].Value = "1";
        }

        private void TabPageBooks_Leave(object sender, EventArgs e)
        {
            bookFiltersBuffer.Clear();
            foreach (DataGridViewRow str in dataGridViewFilters.Rows)
            {
                bookFiltersBuffer.Add(str);
            }
        }

        private void TabPageReaders_Leave(object sender, EventArgs e)
        {
            readerFiltersBuffer.Clear();
            foreach (DataGridViewRow str in dataGridViewFilters.Rows)
            {
                readerFiltersBuffer.Add(str);
            }
        }

        private void TabPageIssuedBooks_Leave(object sender, EventArgs e)
        {
            issuedBooksFiltersBuffer.Clear();
            foreach (DataGridViewRow str in dataGridViewFilters.Rows)
            {
                issuedBooksFiltersBuffer.Add(str);
            }
        }

        private void DataGridViewBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = (DataGridView) sender;
            var cellCountValue = int.Parse(grid[countBookTableColumn.Index, e.RowIndex].Value.ToString());
            if (cellCountValue == 1)
                e.CellStyle.BackColor = Color.Yellow;
            else if (cellCountValue == 0)
                e.CellStyle.BackColor = Color.OrangeRed;
        }

        private void DataGridViewIssuedBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = (DataGridView) sender;
            var cellDateReturnValue = (DateTime) grid[dateReturnIssuedBookTableColumn.Index, e.RowIndex].Value;
            if (cellDateReturnValue == DateTime.Today)
                e.CellStyle.BackColor = Color.Yellow;
            else if (cellDateReturnValue < DateTime.Today)
                e.CellStyle.BackColor = Color.OrangeRed;
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
//                using (var form = new ReportForm())
//                {
//                }
        }
    }
}