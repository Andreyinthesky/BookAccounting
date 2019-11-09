using System;
using System.Windows.Forms;
using BookAccounting.Data.Models;
using BookAccounting.Data.Repositories;

namespace BookAccounting.Forms
{
    public partial class AddEditReaderForm : Form
    {
        ReadersRepository readersRepository;
        Reader reader;
        AddEditFormState state;

        public AddEditReaderForm(Reader reader, ReadersRepository readersRepository)
        {
            InitializeComponent();
            this.readersRepository = readersRepository;
            if (reader == null)
            {
                this.reader = new Reader();
                state = AddEditFormState.Add;
                Text = "Добавление нового читателя";
            }
            else
            {
                this.reader = reader;
                state = AddEditFormState.Edit;
                Text = String.Format("Изменение читателя (ID = {0})", this.reader.Id);
                BindDataToControls();
            }
        }

        private void AddEditReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
                {
                    MessageBox.Show("Введите имя и фамилию читателя", "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    textBoxName.Focus();
                    e.Cancel = true;
                    return;
                }

                SetDataFromControls();

                if (state == AddEditFormState.Add)
                {
                    readersRepository.Add(reader);
                }
                else
                {
                    readersRepository.Update(reader);
                }
            }

            e.Cancel = false;
        }

        private void BindDataToControls()
        {
            textBoxSurname.Text = reader.Surname;
            textBoxName.Text = reader.Name;
            textBoxPatronymic.Text = reader.Patronymic;
            textBoxPhoneNumber.Text = reader.PhoneNumber;
            textBoxEmail.Text = reader.Email;
        }

        private void SetDataFromControls()
        {
            reader.Surname = textBoxSurname.Text;
            reader.Name = textBoxName.Text;
            reader.Patronymic = textBoxPatronymic.Text;
            
            if (textBoxPhoneNumber.MaskFull)
            {
                reader.PhoneNumber = textBoxPhoneNumber.Text;
            }
            else
            {
                reader.PhoneNumber = "";
            }

            reader.Email = textBoxEmail.Text;
        }
    }
}