namespace BookAccounting.Forms
{
    partial class AddEditBookForm
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.textBoxPublishOffice = new System.Windows.Forms.TextBox();
            this.labelPublishOffice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.textBoxRack = new System.Windows.Forms.TextBox();
            this.labelRack = new System.Windows.Forms.Label();
            this.textBoxCabinet = new System.Windows.Forms.TextBox();
            this.labelCabinet = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.numUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPageCount = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(15, 29);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(320, 22);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(320, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTheme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTheme.Location = new System.Drawing.Point(15, 225);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(320, 22);
            this.textBoxTheme.TabIndex = 3;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(12, 205);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(72, 17);
            this.labelTheme.TabIndex = 6;
            this.labelTheme.Text = "Тематика";
            // 
            // textBoxPublishOffice
            // 
            this.textBoxPublishOffice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPublishOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPublishOffice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPublishOffice.Location = new System.Drawing.Point(15, 161);
            this.textBoxPublishOffice.Name = "textBoxPublishOffice";
            this.textBoxPublishOffice.Size = new System.Drawing.Size(320, 22);
            this.textBoxPublishOffice.TabIndex = 2;
            // 
            // labelPublishOffice
            // 
            this.labelPublishOffice.AutoSize = true;
            this.labelPublishOffice.Location = new System.Drawing.Point(12, 141);
            this.labelPublishOffice.Name = "labelPublishOffice";
            this.labelPublishOffice.Size = new System.Drawing.Size(100, 17);
            this.labelPublishOffice.TabIndex = 4;
            this.labelPublishOffice.Text = "Издательство";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 265);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(91, 17);
            this.labelYear.TabIndex = 8;
            this.labelYear.Text = "Год издания";
            // 
            // labelPageCount
            // 
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Location = new System.Drawing.Point(451, 9);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(107, 17);
            this.labelPageCount.TabIndex = 12;
            this.labelPageCount.Text = "Число страниц";
            // 
            // textBoxRack
            // 
            this.textBoxRack.Location = new System.Drawing.Point(450, 285);
            this.textBoxRack.Name = "textBoxRack";
            this.textBoxRack.Size = new System.Drawing.Size(320, 22);
            this.textBoxRack.TabIndex = 9;
            // 
            // labelRack
            // 
            this.labelRack.AutoSize = true;
            this.labelRack.Location = new System.Drawing.Point(451, 265);
            this.labelRack.Name = "labelRack";
            this.labelRack.Size = new System.Drawing.Size(49, 17);
            this.labelRack.TabIndex = 20;
            this.labelRack.Text = "Полка";
            // 
            // textBoxCabinet
            // 
            this.textBoxCabinet.Location = new System.Drawing.Point(450, 225);
            this.textBoxCabinet.Name = "textBoxCabinet";
            this.textBoxCabinet.Size = new System.Drawing.Size(320, 22);
            this.textBoxCabinet.TabIndex = 8;
            // 
            // labelCabinet
            // 
            this.labelCabinet.AutoSize = true;
            this.labelCabinet.Location = new System.Drawing.Point(451, 205);
            this.labelCabinet.Name = "labelCabinet";
            this.labelCabinet.Size = new System.Drawing.Size(65, 17);
            this.labelCabinet.TabIndex = 18;
            this.labelCabinet.Text = "Стеллаж";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(451, 141);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(86, 17);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "Количество";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(450, 93);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(320, 22);
            this.textBoxISBN.TabIndex = 6;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(451, 73);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(39, 17);
            this.labelISBN.TabIndex = 14;
            this.labelISBN.Text = "ISBN";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(585, 313);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 36);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BeepOnError = true;
            this.textBoxYear.Location = new System.Drawing.Point(15, 285);
            this.textBoxYear.Mask = "0000";
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.PromptChar = ' ';
            this.textBoxYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxYear.Size = new System.Drawing.Size(320, 22);
            this.textBoxYear.TabIndex = 4;
            this.textBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxYear.Leave += new System.EventHandler(this.TextBoxYear_Leave);
            // 
            // numUpDownCount
            // 
            this.numUpDownCount.Location = new System.Drawing.Point(450, 162);
            this.numUpDownCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownCount.Name = "numUpDownCount";
            this.numUpDownCount.Size = new System.Drawing.Size(320, 22);
            this.numUpDownCount.TabIndex = 7;
            this.numUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(667, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 36);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxPageCount
            // 
            this.textBoxPageCount.BeepOnError = true;
            this.textBoxPageCount.Location = new System.Drawing.Point(450, 29);
            this.textBoxPageCount.Mask = "0000000";
            this.textBoxPageCount.Name = "textBoxPageCount";
            this.textBoxPageCount.PromptChar = ' ';
            this.textBoxPageCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPageCount.Size = new System.Drawing.Size(320, 22);
            this.textBoxPageCount.TabIndex = 5;
            this.textBoxPageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPageCount.Leave += new System.EventHandler(this.TextBoxPageCount_Leave);
            // 
            // AddEditBookForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.textBoxPageCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numUpDownCount);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxRack);
            this.Controls.Add(this.labelRack);
            this.Controls.Add(this.textBoxCabinet);
            this.Controls.Add(this.labelCabinet);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelPageCount);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.textBoxPublishOffice);
            this.Controls.Add(this.labelPublishOffice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddEditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditBookForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditBookForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox textBoxPublishOffice;
        private System.Windows.Forms.Label labelPublishOffice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.TextBox textBoxRack;
        private System.Windows.Forms.Label labelRack;
        private System.Windows.Forms.TextBox textBoxCabinet;
        private System.Windows.Forms.Label labelCabinet;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.MaskedTextBox textBoxYear;
        private System.Windows.Forms.NumericUpDown numUpDownCount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MaskedTextBox textBoxPageCount;
    }
}