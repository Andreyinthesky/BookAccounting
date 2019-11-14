﻿using BookAccounting.CustomControls;

 namespace BookAccounting.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControlTables = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.groupBoxBookActions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBtnBook = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tabPageReaders = new System.Windows.Forms.TabPage();
            this.groupBoxReadersAction = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBtnReader = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.btnEditReader = new System.Windows.Forms.Button();
            this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
            this.tabPageIssuedBook = new System.Windows.Forms.TabPage();
            this.groupBoxIssuedBookActions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBtnIssuedBooks = new System.Windows.Forms.TableLayoutPanel();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnDeleteIssuedBook = new System.Windows.Forms.Button();
            this.btnEditIssuedBook = new System.Windows.Forms.Button();
            this.dataGridViewIssuedBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewFilters = new FiltersDataGridView();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.idBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingOfficeBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetNameBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackNameBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailReaderTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssueIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBookIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorNameIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReaderIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerNameIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerSurnameIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerPatronymicIssuedBookTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlTables.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            this.groupBoxBookActions.SuspendLayout();
            this.tableLayoutPanelBtnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabPageReaders.SuspendLayout();
            this.groupBoxReadersAction.SuspendLayout();
            this.tableLayoutPanelBtnReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
            this.tabPageIssuedBook.SuspendLayout();
            this.groupBoxIssuedBookActions.SuspendLayout();
            this.tableLayoutPanelBtnIssuedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBooks)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilters)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTables
            // 
            this.tabControlTables.Controls.Add(this.tabPageBooks);
            this.tabControlTables.Controls.Add(this.tabPageReaders);
            this.tabControlTables.Controls.Add(this.tabPageIssuedBook);
            this.tabControlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlTables.ItemSize = new System.Drawing.Size(120, 50);
            this.tabControlTables.Location = new System.Drawing.Point(3, 47);
            this.tabControlTables.Name = "tabControlTables";
            this.tabControlTables.Padding = new System.Drawing.Point(20, 3);
            this.tabControlTables.SelectedIndex = 0;
            this.tabControlTables.Size = new System.Drawing.Size(1256, 457);
            this.tabControlTables.TabIndex = 0;
            this.tabControlTables.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControlTables_Selecting);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.groupBoxBookActions);
            this.tabPageBooks.Controls.Add(this.dataGridViewBooks);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 54);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(1248, 399);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            this.tabPageBooks.Leave += new System.EventHandler(this.TabPageBooks_Leave);
            // 
            // groupBoxBookActions
            // 
            this.groupBoxBookActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBookActions.AutoSize = true;
            this.groupBoxBookActions.Controls.Add(this.tableLayoutPanelBtnBook);
            this.groupBoxBookActions.Location = new System.Drawing.Point(6, 304);
            this.groupBoxBookActions.Name = "groupBoxBookActions";
            this.groupBoxBookActions.Size = new System.Drawing.Size(1236, 89);
            this.groupBoxBookActions.TabIndex = 2;
            this.groupBoxBookActions.TabStop = false;
            this.groupBoxBookActions.Text = "Действия";
            // 
            // tableLayoutPanelBtnBook
            // 
            this.tableLayoutPanelBtnBook.ColumnCount = 3;
            this.tableLayoutPanelBtnBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnBook.Controls.Add(this.btnAddBook, 0, 0);
            this.tableLayoutPanelBtnBook.Controls.Add(this.btnDeleteBook, 2, 0);
            this.tableLayoutPanelBtnBook.Controls.Add(this.btnEditBook, 1, 0);
            this.tableLayoutPanelBtnBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBtnBook.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanelBtnBook.Name = "tableLayoutPanelBtnBook";
            this.tableLayoutPanelBtnBook.RowCount = 1;
            this.tableLayoutPanelBtnBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBtnBook.Size = new System.Drawing.Size(1230, 64);
            this.tableLayoutPanelBtnBook.TabIndex = 2;
            this.tableLayoutPanelFilters.SetRowSpan(this.dataGridViewFilters, 3);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteBook.Location = new System.Drawing.Point(823, 3);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(404, 58);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Удалить";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBook.Location = new System.Drawing.Point(413, 3);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(404, 58);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Изменить";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBookTableColumn,
            this.authorBookTableColumn,
            this.bookBookTableColumn,
            this.publishingOfficeBookTableColumn,
            this.themeBookTableColumn,
            this.yearBookTableColumn,
            this.pageBookTableColumn,
            this.iSBNBookTableColumn,
            this.countBookTableColumn,
            this.cabinetNameBookTableColumn,
            this.rackNameBookTableColumn});
            this.dataGridViewBooks.DataSource = this.bookBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1245, 295);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridViewBooks_CellPainting);
            // 
            // tabPageReaders
            // 
            this.tabPageReaders.Controls.Add(this.groupBoxReadersAction);
            this.tabPageReaders.Controls.Add(this.dataGridViewReaders);
            this.tabPageReaders.Location = new System.Drawing.Point(4, 54);
            this.tabPageReaders.Name = "tabPageReaders";
            this.tabPageReaders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReaders.Size = new System.Drawing.Size(1248, 404);
            this.tabPageReaders.TabIndex = 1;
            this.tabPageReaders.Text = "Читатели";
            this.tabPageReaders.UseVisualStyleBackColor = true;
            this.tabPageReaders.Leave += new System.EventHandler(this.TabPageReaders_Leave);
            // 
            // groupBoxReadersAction
            // 
            this.groupBoxReadersAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReadersAction.AutoSize = true;
            this.groupBoxReadersAction.Controls.Add(this.tableLayoutPanelBtnReader);
            this.groupBoxReadersAction.Location = new System.Drawing.Point(6, 309);
            this.groupBoxReadersAction.Name = "groupBoxReadersAction";
            this.groupBoxReadersAction.Size = new System.Drawing.Size(1236, 89);
            this.groupBoxReadersAction.TabIndex = 3;
            this.groupBoxReadersAction.TabStop = false;
            this.groupBoxReadersAction.Text = "Действия";
            // 
            // tableLayoutPanelBtnReader
            // 
            this.tableLayoutPanelBtnReader.ColumnCount = 3;
            this.tableLayoutPanelBtnReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnReader.Controls.Add(this.btnAddReader, 0, 0);
            this.tableLayoutPanelBtnReader.Controls.Add(this.btnDeleteReader, 2, 0);
            this.tableLayoutPanelBtnReader.Controls.Add(this.btnEditReader, 1, 0);
            this.tableLayoutPanelBtnReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBtnReader.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanelBtnReader.Name = "tableLayoutPanelBtnReader";
            this.tableLayoutPanelBtnReader.RowCount = 1;
            this.tableLayoutPanelBtnReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBtnReader.Size = new System.Drawing.Size(1230, 64);
            this.tableLayoutPanelBtnReader.TabIndex = 2;
            // 
            // btnAddReader
            // 
            this.btnAddReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddReader.Location = new System.Drawing.Point(3, 3);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(404, 58);
            this.btnAddReader.TabIndex = 0;
            this.btnAddReader.Text = "Добавить читателя";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.BtnAddReader_Click);
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteReader.Location = new System.Drawing.Point(823, 3);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(404, 58);
            this.btnDeleteReader.TabIndex = 2;
            this.btnDeleteReader.Text = "Удалить";
            this.btnDeleteReader.UseVisualStyleBackColor = true;
            this.btnDeleteReader.Click += new System.EventHandler(this.BtnDeleteReader_Click);
            // 
            // btnEditReader
            // 
            this.btnEditReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditReader.Location = new System.Drawing.Point(413, 3);
            this.btnEditReader.Name = "btnEditReader";
            this.btnEditReader.Size = new System.Drawing.Size(404, 58);
            this.btnEditReader.TabIndex = 1;
            this.btnEditReader.Text = "Изменить";
            this.btnEditReader.UseVisualStyleBackColor = true;
            this.btnEditReader.Click += new System.EventHandler(this.BtnEditReader_Click);
            // 
            // dataGridViewReaders
            // 
            this.dataGridViewReaders.AllowUserToAddRows = false;
            this.dataGridViewReaders.AllowUserToDeleteRows = false;
            this.dataGridViewReaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReaders.AutoGenerateColumns = false;
            this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReaderTableColumn,
            this.surnameReaderTableColumn,
            this.nameReaderTableColumn,
            this.patronymicReaderTableColumn,
            this.phoneNumberReaderTableColumn,
            this.emailReaderTableColumn});
            this.dataGridViewReaders.DataSource = this.readerBindingSource;
            this.dataGridViewReaders.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewReaders.Name = "dataGridViewReaders";
            this.dataGridViewReaders.ReadOnly = true;
            this.dataGridViewReaders.RowTemplate.Height = 24;
            this.dataGridViewReaders.Size = new System.Drawing.Size(1245, 300);
            this.dataGridViewReaders.TabIndex = 2;
            // 
            // tabPageIssuedBook
            // 
            this.tabPageIssuedBook.Controls.Add(this.groupBoxIssuedBookActions);
            this.tabPageIssuedBook.Controls.Add(this.dataGridViewIssuedBooks);
            this.tabPageIssuedBook.Location = new System.Drawing.Point(4, 54);
            this.tabPageIssuedBook.Name = "tabPageIssuedBook";
            this.tabPageIssuedBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIssuedBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageIssuedBook.Size = new System.Drawing.Size(1248, 404);
            this.tabPageIssuedBook.TabIndex = 2;
            this.tabPageIssuedBook.Text = "Выданные книги";
            this.tabPageIssuedBook.UseVisualStyleBackColor = true;
            this.tabPageIssuedBook.Leave += new System.EventHandler(this.TabPageIssuedBooks_Leave);
            // 
            // groupBoxIssuedBookActions
            // 
            this.groupBoxIssuedBookActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIssuedBookActions.AutoSize = true;
            this.groupBoxIssuedBookActions.Controls.Add(this.tableLayoutPanelBtnIssuedBooks);
            this.groupBoxIssuedBookActions.Location = new System.Drawing.Point(6, 309);
            this.groupBoxIssuedBookActions.Name = "groupBoxIssuedBookActions";
            this.groupBoxIssuedBookActions.Size = new System.Drawing.Size(1236, 89);
            this.groupBoxIssuedBookActions.TabIndex = 4;
            this.groupBoxIssuedBookActions.TabStop = false;
            this.groupBoxIssuedBookActions.Text = "Действия";
            // 
            // tableLayoutPanelBtnIssuedBooks
            // 
            this.tableLayoutPanelBtnIssuedBooks.ColumnCount = 3;
            this.tableLayoutPanelBtnIssuedBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnIssuedBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnIssuedBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBtnIssuedBooks.Controls.Add(this.btnIssueBook, 0, 0);
            this.tableLayoutPanelBtnIssuedBooks.Controls.Add(this.btnDeleteIssuedBook, 2, 0);
            this.tableLayoutPanelBtnIssuedBooks.Controls.Add(this.btnEditIssuedBook, 1, 0);
            this.tableLayoutPanelBtnIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBtnIssuedBooks.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanelBtnIssuedBooks.Name = "tableLayoutPanelBtnIssuedBooks";
            this.tableLayoutPanelBtnIssuedBooks.RowCount = 1;
            this.tableLayoutPanelBtnIssuedBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBtnIssuedBooks.Size = new System.Drawing.Size(1230, 64);
            this.tableLayoutPanelBtnIssuedBooks.TabIndex = 2;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIssueBook.Location = new System.Drawing.Point(3, 3);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(404, 58);
            this.btnIssueBook.TabIndex = 0;
            this.btnIssueBook.Text = "Выдать книгу";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.BtnAddIssuedBook_Click);
            // 
            // btnDeleteIssuedBook
            // 
            this.btnDeleteIssuedBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteIssuedBook.Location = new System.Drawing.Point(823, 3);
            this.btnDeleteIssuedBook.Name = "btnDeleteIssuedBook";
            this.btnDeleteIssuedBook.Size = new System.Drawing.Size(404, 58);
            this.btnDeleteIssuedBook.TabIndex = 2;
            this.btnDeleteIssuedBook.Text = "Удалить";
            this.btnDeleteIssuedBook.UseVisualStyleBackColor = true;
            this.btnDeleteIssuedBook.Click += new System.EventHandler(this.BtnDeleteIssuedBook_Click);
            // 
            // btnEditIssuedBook
            // 
            this.btnEditIssuedBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditIssuedBook.Location = new System.Drawing.Point(413, 3);
            this.btnEditIssuedBook.Name = "btnEditIssuedBook";
            this.btnEditIssuedBook.Size = new System.Drawing.Size(404, 58);
            this.btnEditIssuedBook.TabIndex = 1;
            this.btnEditIssuedBook.Text = "Изменить";
            this.btnEditIssuedBook.UseVisualStyleBackColor = true;
            this.btnEditIssuedBook.Click += new System.EventHandler(this.BtnEditIssuedBook_Click);
            // 
            // dataGridViewIssuedBooks
            // 
            this.dataGridViewIssuedBooks.AllowUserToAddRows = false;
            this.dataGridViewIssuedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewIssuedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIssuedBooks.AutoGenerateColumns = false;
            this.dataGridViewIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIssuedBookTableColumn,
            this.dateIssueIssuedBookTableColumn,
            this.dateReturnIssuedBookTableColumn,
            this.idBookIssuedBookTableColumn,
            this.bookNameIssuedBookTableColumn,
            this.bookAuthorNameIssuedBookTableColumn,
            this.idReaderIssuedBookTableColumn,
            this.readerNameIssuedBookTableColumn,
            this.readerSurnameIssuedBookTableColumn,
            this.readerPatronymicIssuedBookTableColumn,
            });
            this.dataGridViewIssuedBooks.DataSource = this.issuedBooksBindingSource;
            this.dataGridViewIssuedBooks.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewIssuedBooks.Name = "dataGridViewIssuedBooks";
            this.dataGridViewIssuedBooks.ReadOnly = true;
            this.dataGridViewIssuedBooks.RowTemplate.Height = 24;
            this.dataGridViewIssuedBooks.Size = new System.Drawing.Size(1245, 300);
            this.dataGridViewIssuedBooks.TabIndex = 0;
            this.dataGridViewIssuedBooks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridViewIssuedBooks_CellPainting);
            //
            // dataGridViewFilters
            //
            dataGridViewFilters.CellValueChanged += DataGridViewFilters_CellValueChanged;
            dataGridViewFilters.RowsAdded += DataGridViewFilters_RowsAdded;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.AutoSize = true;
            this.groupBoxFilters.Controls.Add(this.tableLayoutPanelFilters);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilters.Location = new System.Drawing.Point(3, 510);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(1256, 208);
            this.groupBoxFilters.TabIndex = 3;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 2;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFilters.Controls.Add(this.dataGridViewFilters, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.btnApplyFilters, 1, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.btnAddFilter, 1, 1);
            this.tableLayoutPanelFilters.Controls.Add(this.btnDeleteFilter, 1, 2);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 3;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(1250, 187);
            this.tableLayoutPanelFilters.TabIndex = 2;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.Location = new System.Drawing.Point(1003, 3);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(244, 56);
            this.btnApplyFilters.TabIndex = 2;
            this.btnApplyFilters.Text = "Применить";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.BtnApplyFilter_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddFilter.Location = new System.Drawing.Point(1003, 65);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(244, 56);
            this.btnAddFilter.TabIndex = 3;
            this.btnAddFilter.Text = "Добавить";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.BtnAddFilter_Click);
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteFilter.Location = new System.Drawing.Point(1003, 127);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(244, 57);
            this.btnDeleteFilter.TabIndex = 4;
            this.btnDeleteFilter.Text = "Удалить";
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.BtnDeleteFilter_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxFilters, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tabControlTables, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.btnCreateReport, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1262, 721);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateReport.AutoSize = true;
            this.btnCreateReport.Image = global::BookAccounting.Properties.Resources.table_excel_icon;
            this.btnCreateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReport.Location = new System.Drawing.Point(3, 3);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 53);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(189, 38);
            this.btnCreateReport.TabIndex = 4;
            this.btnCreateReport.Text = "Создать отчет";
            this.btnCreateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddBook.Location = new System.Drawing.Point(3, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(404, 58);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // idBookTableColumn
            // 
            this.idBookTableColumn.DataPropertyName = "Id";
            this.idBookTableColumn.HeaderText = "Id";
            this.idBookTableColumn.Name = "idBookTableColumn";
            this.idBookTableColumn.ReadOnly = true;
            this.idBookTableColumn.Width = 50;
            // 
            // authorBookTableColumn
            // 
            this.authorBookTableColumn.DataPropertyName = "AuthorName";
            this.authorBookTableColumn.HeaderText = "Автор";
            this.authorBookTableColumn.Name = "authorBookTableColumn";
            this.authorBookTableColumn.ReadOnly = true;
            this.authorBookTableColumn.Width = 150;
            // 
            // bookBookTableColumn
            // 
            this.bookBookTableColumn.DataPropertyName = "BookName";
            this.bookBookTableColumn.HeaderText = "Название";
            this.bookBookTableColumn.Name = "bookBookTableColumn";
            this.bookBookTableColumn.ReadOnly = true;
            this.bookBookTableColumn.Width = 200;
            // 
            // publishingOfficeBookTableColumn
            // 
            this.publishingOfficeBookTableColumn.DataPropertyName = "PublishingOfficeName";
            this.publishingOfficeBookTableColumn.HeaderText = "Издательство";
            this.publishingOfficeBookTableColumn.Name = "publishingOfficeBookTableColumn";
            this.publishingOfficeBookTableColumn.ReadOnly = true;
            this.publishingOfficeBookTableColumn.Width = 150;
            // 
            // themeBookTableColumn
            // 
            this.themeBookTableColumn.DataPropertyName = "Theme";
            this.themeBookTableColumn.HeaderText = "Тематика";
            this.themeBookTableColumn.Name = "themeBookTableColumn";
            this.themeBookTableColumn.ReadOnly = true;
            // 
            // yearBookTableColumn
            // 
            this.yearBookTableColumn.DataPropertyName = "Year";
            this.yearBookTableColumn.HeaderText = "Год";
            this.yearBookTableColumn.Name = "yearBookTableColumn";
            this.yearBookTableColumn.ReadOnly = true;
            // 
            // pageBookTableColumn
            // 
            this.pageBookTableColumn.DataPropertyName = "PageCount";
            this.pageBookTableColumn.HeaderText = "Кол-во страниц";
            this.pageBookTableColumn.Name = "pageBookTableColumn";
            this.pageBookTableColumn.ReadOnly = true;
            // 
            // iSBNBookTableColumn
            // 
            this.iSBNBookTableColumn.DataPropertyName = "ISBN";
            this.iSBNBookTableColumn.HeaderText = "ISBN";
            this.iSBNBookTableColumn.Name = "iSBNBookTableColumn";
            this.iSBNBookTableColumn.ReadOnly = true;
            this.iSBNBookTableColumn.Width = 150;
            // 
            // countBookTableColumn
            // 
            this.countBookTableColumn.DataPropertyName = "Count";
            this.countBookTableColumn.HeaderText = "Текущее кол-во";
            this.countBookTableColumn.Name = "countBookTableColumn";
            this.countBookTableColumn.ReadOnly = true;
            // 
            // cabinetNameBookTableColumn
            // 
            this.cabinetNameBookTableColumn.DataPropertyName = "CabinetName";
            this.cabinetNameBookTableColumn.HeaderText = "Стеллаж";
            this.cabinetNameBookTableColumn.Name = "cabinetNameBookTableColumn";
            this.cabinetNameBookTableColumn.ReadOnly = true;
            // 
            // rackNameBookTableColumn
            // 
            this.rackNameBookTableColumn.DataPropertyName = "RackName";
            this.rackNameBookTableColumn.HeaderText = "Полка";
            this.rackNameBookTableColumn.Name = "rackNameBookTableColumn";
            this.rackNameBookTableColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookAccounting.Data.Models.Book);
            // 
            // idReaderTableColumn
            // 
            this.idReaderTableColumn.DataPropertyName = "Id";
            this.idReaderTableColumn.HeaderText = "Id";
            this.idReaderTableColumn.Name = "idReaderTableColumn";
            this.idReaderTableColumn.ReadOnly = true;
            // 
            // surnameReaderTableColumn
            // 
            this.surnameReaderTableColumn.DataPropertyName = "Surname";
            this.surnameReaderTableColumn.HeaderText = "Фамилия";
            this.surnameReaderTableColumn.Name = "surnameReaderTableColumn";
            this.surnameReaderTableColumn.ReadOnly = true;
            this.surnameReaderTableColumn.Width = 150;
            // 
            // nameReaderTableColumn
            // 
            this.nameReaderTableColumn.DataPropertyName = "Name";
            this.nameReaderTableColumn.HeaderText = "Имя";
            this.nameReaderTableColumn.Name = "nameReaderTableColumn";
            this.nameReaderTableColumn.ReadOnly = true;
            this.nameReaderTableColumn.Width = 150;
            // 
            // patronymicReaderTableColumn
            // 
            this.patronymicReaderTableColumn.DataPropertyName = "Patronymic";
            this.patronymicReaderTableColumn.HeaderText = "Отчество";
            this.patronymicReaderTableColumn.Name = "patronymicReaderTableColumn";
            this.patronymicReaderTableColumn.ReadOnly = true;
            this.patronymicReaderTableColumn.Width = 150;
            // 
            // phoneNumberReaderTableColumn
            // 
            this.phoneNumberReaderTableColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberReaderTableColumn.HeaderText = "Номер Телефона";
            this.phoneNumberReaderTableColumn.Name = "phoneNumberReaderTableColumn";
            this.phoneNumberReaderTableColumn.ReadOnly = true;
            this.phoneNumberReaderTableColumn.Width = 150;
            // 
            // emailReaderTableColumn
            // 
            this.emailReaderTableColumn.DataPropertyName = "Email";
            this.emailReaderTableColumn.HeaderText = "Эл. почта";
            this.emailReaderTableColumn.Name = "emailReaderTableColumn";
            this.emailReaderTableColumn.ReadOnly = true;
            this.emailReaderTableColumn.Width = 200;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataSource = typeof(BookAccounting.Data.Models.Reader);
            // 
            // idIssuedBookTableColumn
            // 
            this.idIssuedBookTableColumn.DataPropertyName = "Id";
            this.idIssuedBookTableColumn.HeaderText = "Id";
            this.idIssuedBookTableColumn.Name = "idIssuedBookTableColumn";
            this.idIssuedBookTableColumn.ReadOnly = true;
            this.idIssuedBookTableColumn.Width = 50;
            // 
            // dateIssueIssuedBookTableColumn
            // 
            this.dateIssueIssuedBookTableColumn.DataPropertyName = "DateIssue";
            this.dateIssueIssuedBookTableColumn.HeaderText = "Дата выдачи";
            this.dateIssueIssuedBookTableColumn.Name = "dateIssueIssuedBookTableColumn";
            this.dateIssueIssuedBookTableColumn.ReadOnly = true;
            // 
            // dateReturnIssuedBookTableColumn
            // 
            this.dateReturnIssuedBookTableColumn.DataPropertyName = "DateReturn";
            this.dateReturnIssuedBookTableColumn.HeaderText = "Дата возврата";
            this.dateReturnIssuedBookTableColumn.Name = "dateReturnIssuedBookTableColumn";
            this.dateReturnIssuedBookTableColumn.ReadOnly = true;
            // 
            // idBookIssuedBookTableColumn
            // 
            this.idBookIssuedBookTableColumn.DataPropertyName = "IdBook";
            this.idBookIssuedBookTableColumn.HeaderText = "Id книги";
            this.idBookIssuedBookTableColumn.Name = "idBookIssuedBookTableColumn";
            this.idBookIssuedBookTableColumn.ReadOnly = true;
            this.idBookIssuedBookTableColumn.Width = 100;
            // 
            // bookNameIssuedBookTableColumn
            // 
            this.bookNameIssuedBookTableColumn.DataPropertyName = "BookName";
            this.bookNameIssuedBookTableColumn.HeaderText = "Название книги";
            this.bookNameIssuedBookTableColumn.Name = "bookNameIssuedBookTableColumn";
            this.bookNameIssuedBookTableColumn.ReadOnly = true;
            this.bookNameIssuedBookTableColumn.Width = 100;
            // 
            // bookAuthorNameIssuedBookTableColumn
            // 
            this.bookAuthorNameIssuedBookTableColumn.DataPropertyName = "BookAuthorName";
            this.bookAuthorNameIssuedBookTableColumn.HeaderText = "Автор книги";
            this.bookAuthorNameIssuedBookTableColumn.Name = "bookAuthorNameIssuedBookTableColumn";
            this.bookAuthorNameIssuedBookTableColumn.ReadOnly = true;
            this.bookAuthorNameIssuedBookTableColumn.Width = 100;
            // 
            // idReaderIssuedBookTableColumn
            // 
            this.idReaderIssuedBookTableColumn.DataPropertyName = "IdReader";
            this.idReaderIssuedBookTableColumn.HeaderText = "Id читателя";
            this.idReaderIssuedBookTableColumn.Name = "idReaderIssuedBookTableColumn";
            this.idReaderIssuedBookTableColumn.ReadOnly = true;
            this.idReaderIssuedBookTableColumn.Width = 100;
            // 
            // readerNameIssuedBookTableColumn
            // 
            this.readerNameIssuedBookTableColumn.DataPropertyName = "ReaderName";
            this.readerNameIssuedBookTableColumn.HeaderText = "Имя читателя";
            this.readerNameIssuedBookTableColumn.Name = "readerNameIssuedBookTableColumn";
            this.readerNameIssuedBookTableColumn.ReadOnly = true;
            this.readerNameIssuedBookTableColumn.Width = 100;
            // 
            // idReaderIssuedBookTableColumn
            // 
            this.readerSurnameIssuedBookTableColumn.DataPropertyName = "ReaderSurname";
            this.readerSurnameIssuedBookTableColumn.HeaderText = "Фамилия читателя";
            this.readerSurnameIssuedBookTableColumn.Name = "readerSurnameIssuedBookTableColumn";
            this.readerSurnameIssuedBookTableColumn.ReadOnly = true;
            this.readerSurnameIssuedBookTableColumn.Width = 100;
            // 
            // readerPatronymicIssuedBookTableColumn
            // 
            this.readerPatronymicIssuedBookTableColumn.DataPropertyName = "ReaderPatronymic";
            this.readerPatronymicIssuedBookTableColumn.HeaderText = "Отчество читателя";
            this.readerPatronymicIssuedBookTableColumn.Name = "readerPatronymicIssuedBookTableColumn";
            this.readerPatronymicIssuedBookTableColumn.ReadOnly = true;
            this.readerPatronymicIssuedBookTableColumn.Width = 100;       
            // 
            // issuedBooksBindingSource
            // 
            this.issuedBooksBindingSource.DataSource = typeof(BookAccounting.Data.Models.IssuedBook);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет книг";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlTables.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            this.groupBoxBookActions.ResumeLayout(false);
            this.tableLayoutPanelBtnBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabPageReaders.ResumeLayout(false);
            this.tabPageReaders.PerformLayout();
            this.groupBoxReadersAction.ResumeLayout(false);
            this.tableLayoutPanelBtnReader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
            this.tabPageIssuedBook.ResumeLayout(false);
            this.tabPageIssuedBook.PerformLayout();
            this.groupBoxIssuedBookActions.ResumeLayout(false);
            this.tableLayoutPanelBtnIssuedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBooks)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.tableLayoutPanelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilters)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedBooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private System.Windows.Forms.BindingSource issuedBooksBindingSource;
        private System.Windows.Forms.TabControl tabControlTables;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.GroupBox groupBoxBookActions;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabPage tabPageReaders;
        private System.Windows.Forms.GroupBox groupBoxReadersAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtnReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.Button btnEditReader;
        private System.Windows.Forms.DataGridView dataGridViewReaders;
        private System.Windows.Forms.TabPage tabPageIssuedBook;
        private System.Windows.Forms.GroupBox groupBoxIssuedBookActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtnIssuedBooks;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnDeleteIssuedBook;
        private System.Windows.Forms.Button btnEditIssuedBook;
        private System.Windows.Forms.DataGridView dataGridViewIssuedBooks;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFilters;
        private BookAccounting.CustomControls.FiltersDataGridView dataGridViewFilters;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingOfficeBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetNameBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackNameBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailReaderTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssueIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorNameIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReaderIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerSurnameIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerNameIssuedBookTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerPatronymicIssuedBookTableColumn;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBtnBook;
        private System.Windows.Forms.Button btnCreateReport;
    }
}

