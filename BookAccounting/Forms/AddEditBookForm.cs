using System;
using System.Linq;
using System.Windows.Forms;
using BookAccounting.Data.Models;
using BookAccounting.Data.Repositories;

namespace BookAccounting.Forms
{
    public partial class AddEditBookForm : Form
    {
        BooksRepository booksRepository;
        Book book;
        AddEditFormState state;

        public AddEditBookForm(Book book, BooksRepository booksRepository)
        {
            InitializeComponent();
            this.booksRepository = booksRepository;
            if (book == null)
            {
                this.book = new Book();
                state = AddEditFormState.Add;
                Text = "Добавление новой книги";
            }
            else
            {
                this.book = book;
                state = AddEditFormState.Edit;
                Text = String.Format("Изменение книги (ID = {0})", this.book.Id);
                BindDataToControls();
            }
            SetupControls();
        }

        private void SetupControls()
        {
            textBoxPublishOffice.AutoCompleteCustomSource
                .AddRange(booksRepository.GetAll().Select(b => b.PublishingOfficeName).Where(p => p != null).Distinct().ToArray());
            textBoxTheme.AutoCompleteCustomSource
                .AddRange(booksRepository.GetAll().Select(b => b.Theme).Where(p => p != null).Distinct().ToArray());
        }

        private void AddEditBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAuthor.Text))
                {
                    MessageBox.Show("Введите название книги и автора", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Focus();
                    e.Cancel = true;
                    return;
                }
                SetDataFromControls();
                if (state == AddEditFormState.Add)
                {
                    booksRepository.Add(book);
                }
                else
                {
                    booksRepository.Update(book);
                }
                e.Cancel = false;
            }
        }

        private void BindDataToControls()
        {
            textBoxAuthor.Text = book.AuthorName;
            textBoxName.Text = book.BookName;
            textBoxPublishOffice.Text = book.PublishingOfficeName;
            textBoxTheme.Text = book.Theme;
            textBoxYear.Text = book.Year == null ? "" : book.Year.ToString();
            textBoxPageCount.Text = book.PageCount == null ? "" : book.PageCount.ToString();
            textBoxISBN.Text = book.ISBN;
            numUpDownCount.Value = book.Count;
            textBoxCabinet.Text = book.CabinetName;
            textBoxRack.Text = book.RackName;
        }

        private void SetDataFromControls()
        {
            book.AuthorName = textBoxAuthor.Text;
            book.BookName = textBoxName.Text;
            book.PublishingOfficeName = textBoxPublishOffice.Text;
            book.Theme = textBoxTheme.Text;
            if (!String.IsNullOrEmpty(textBoxYear.Text))
            {
                book.Year = int.Parse(textBoxYear.Text);
            }
            if (!String.IsNullOrEmpty(textBoxPageCount.Text))
            {
                book.PageCount = int.Parse(textBoxPageCount.Text);
            }
            book.ISBN = textBoxISBN.Text;
            book.Count = (int)numUpDownCount.Value;
            book.CabinetName = textBoxCabinet.Text;
            book.RackName = textBoxRack.Text;

        }

        private void TextBoxYear_Leave(object sender, EventArgs e)
        {
            if (textBoxYear.Text.Contains(" "))
            {
                textBoxYear.Text = textBoxYear.Text.Replace(" ", "");
            }
        }

        private void TextBoxPageCount_Leave(object sender, EventArgs e)
        {
            if (textBoxPageCount.Text.Contains(" "))
            {
                textBoxPageCount.Text = textBoxPageCount.Text.Replace(" ", "");
            }
        }
    }
}
