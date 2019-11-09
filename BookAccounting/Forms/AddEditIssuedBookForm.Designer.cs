namespace BookAccounting.Forms
{
    partial class AddEditIssuedBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBook = new System.Windows.Forms.TextBox();
            this.textBoxReader = new System.Windows.Forms.TextBox();
            this.dateTimeIssuePicker = new System.Windows.Forms.DateTimePicker();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelReader = new System.Windows.Forms.Label();
            this.labelDateIssue = new System.Windows.Forms.Label();
            this.labelDateReturn = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimeReturnPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxBook
            // 
            this.textBoxBook.AcceptsReturn = true;
            this.textBoxBook.AcceptsTab = true;
            this.textBoxBook.Enabled = false;
            this.textBoxBook.Font = new System.Drawing.Font("Liberation Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBook.Location = new System.Drawing.Point(232, 12);
            this.textBoxBook.Multiline = true;
            this.textBoxBook.Name = "textBoxBook";
            this.textBoxBook.Size = new System.Drawing.Size(679, 156);
            this.textBoxBook.TabIndex = 0;
            // 
            // textBoxReader
            // 
            this.textBoxReader.Enabled = false;
            this.textBoxReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReader.Location = new System.Drawing.Point(232, 205);
            this.textBoxReader.Name = "textBoxReader";
            this.textBoxReader.Size = new System.Drawing.Size(514, 24);
            this.textBoxReader.TabIndex = 1;
            // 
            // dateTimeIssuePicker
            // 
            this.dateTimeIssuePicker.Enabled = false;
            this.dateTimeIssuePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeIssuePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeIssuePicker.Location = new System.Drawing.Point(232, 273);
            this.dateTimeIssuePicker.Name = "dateTimeIssuePicker";
            this.dateTimeIssuePicker.Size = new System.Drawing.Size(514, 26);
            this.dateTimeIssuePicker.TabIndex = 2;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook.Location = new System.Drawing.Point(24, 12);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(63, 20);
            this.labelBook.TabIndex = 6;
            this.labelBook.Text = "Книга:";
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReader.Location = new System.Drawing.Point(24, 205);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(74, 20);
            this.labelReader.TabIndex = 7;
            this.labelReader.Text = "На имя:";
            // 
            // labelDateIssue
            // 
            this.labelDateIssue.AutoSize = true;
            this.labelDateIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateIssue.Location = new System.Drawing.Point(24, 273);
            this.labelDateIssue.Name = "labelDateIssue";
            this.labelDateIssue.Size = new System.Drawing.Size(121, 20);
            this.labelDateIssue.TabIndex = 8;
            this.labelDateIssue.Text = "Дата выдачи";
            // 
            // labelDateReturn
            // 
            this.labelDateReturn.AutoSize = true;
            this.labelDateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateReturn.Location = new System.Drawing.Point(24, 376);
            this.labelDateReturn.Name = "labelDateReturn";
            this.labelDateReturn.Size = new System.Drawing.Size(136, 20);
            this.labelDateReturn.TabIndex = 9;
            this.labelDateReturn.Text = "Дата возврата";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(531, 475);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(187, 46);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Выдать книгу";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(724, 475);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(187, 46);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменв";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimeReturnPicker
            // 
            this.dateTimeReturnPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeReturnPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeReturnPicker.Location = new System.Drawing.Point(232, 376);
            this.dateTimeReturnPicker.Name = "dateTimeReturnPicker";
            this.dateTimeReturnPicker.Size = new System.Drawing.Size(514, 26);
            this.dateTimeReturnPicker.TabIndex = 3;
            // 
            // AddEditIssuedBookForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(923, 533);
            this.Controls.Add(this.dateTimeReturnPicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDateReturn);
            this.Controls.Add(this.labelDateIssue);
            this.Controls.Add(this.labelReader);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.dateTimeIssuePicker);
            this.Controls.Add(this.textBoxReader);
            this.Controls.Add(this.textBoxBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEditIssuedBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditIssuedBookForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditIssuedBookForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBook;
        private System.Windows.Forms.TextBox textBoxReader;
        private System.Windows.Forms.DateTimePicker dateTimeIssuePicker;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.Label labelDateIssue;
        private System.Windows.Forms.Label labelDateReturn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimeReturnPicker;
    }
}