using System;
using System.Windows.Forms;
using BookAccounting.Data.Models;
using BookAccounting.Data.Repositories;

namespace BookAccounting.Forms
{
    public partial class AddEditIssuedBookForm : Form
    {
        IssuedBooksRepository issuedBooksRepository;
        AddEditFormState state;
        IssuedBook issuedBook;
        Book book;
        Reader reader;

        public AddEditIssuedBookForm(IssuedBook issuedBook, Book book, Reader reader,
            IssuedBooksRepository issuedBooksRepository)
        {
            InitializeComponent();

            this.issuedBooksRepository = issuedBooksRepository;
            if (issuedBook == null)
            {
                this.Text = "Выдача книги";
                state = AddEditFormState.Add;
                this.book = book;
                this.reader = reader;
                issuedBook = new IssuedBook
                {
                    IdBook = book.Id,
                    IdReader = reader.Id,
                    DateIssue = DateTime.Now.Date,
                    DateReturn = DateTime.Now.Date
                };

                this.issuedBook = issuedBook;
            }
            else
            {
                this.Text = String.Format("Изменение выдачи (ID = {0})", issuedBook.Id);
                buttonOK.Text = "ОК";
                state = AddEditFormState.Edit;
                dateTimeIssuePicker.Enabled = true;
                this.book = book;
                this.reader = reader;
                this.issuedBook = issuedBook;
            }

            BindDataToControls();
        }

        private void AddEditIssuedBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (dateTimeIssuePicker.Value > dateTimeReturnPicker.Value)
                {
                    MessageBox.Show("Дата возврата назначена раньше чем дата выдачи!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateTimeReturnPicker.Focus();
                    e.Cancel = true;
                    return;
                }

                SetDataFromControls();
                if (state == AddEditFormState.Add)
                {
                    issuedBooksRepository.Add(issuedBook);
                }
                else
                {
                    issuedBooksRepository.Update(issuedBook);
                }
            }

            e.Cancel = false;
        }
        
        private void BindDataToControls()
        {
            textBoxBook.Text = String.Format("Автор: {0}\r\nНазвание: {1}\r\nИздательство: {2}\r\nГод издания: {3}",
                book.AuthorName, book.BookName, book.PublishingOfficeName, book.Year);
            textBoxReader.Text = String.Format("{0} {1} {2}", reader.Surname, reader.Name, reader.Patronymic);
            dateTimeIssuePicker.Value = issuedBook.DateIssue;
            dateTimeReturnPicker.Value = issuedBook.DateReturn;
        }

        private void SetDataFromControls()
        {
            issuedBook.DateIssue = dateTimeIssuePicker.Value;
            issuedBook.DateReturn = dateTimeReturnPicker.Value;
        }
    }
}