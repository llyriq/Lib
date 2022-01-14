namespace Kursovoi_proekt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGVReaders = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PageReader = new System.Windows.Forms.TabPage();
            this.PageTicket = new System.Windows.Forms.TabPage();
            this.DGVTickets = new System.Windows.Forms.DataGridView();
            this.PageGiveBook = new System.Windows.Forms.TabPage();
            this.DGVBook_give = new System.Windows.Forms.DataGridView();
            this.PageBooks = new System.Windows.Forms.TabPage();
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.PageWriters = new System.Windows.Forms.TabPage();
            this.DGVAuthor = new System.Windows.Forms.DataGridView();
            this.PagePublishers = new System.Windows.Forms.TabPage();
            this.DGVPublisher = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_find_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_ser_pas = new System.Windows.Forms.TextBox();
            this.TB_find_reader = new System.Windows.Forms.TextBox();
            this.TB_inf_ser = new System.Windows.Forms.TextBox();
            this.CB_find_reader = new System.Windows.Forms.ComboBox();
            this.Reader_find = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_pubname = new System.Windows.Forms.ComboBox();
            this.TB_pubbook = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Book_find = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TB_find_book = new System.Windows.Forms.TextBox();
            this.TB_name_book = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clear_logs = new System.Windows.Forms.Button();
            this.open_log = new System.Windows.Forms.Button();
            this.Log_list = new System.Windows.Forms.ListBox();
            this.кодБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийАдресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОЧитателеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Kursovoi_proekt.LibraryDataSet();
            this.кодБилетаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЧитателяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингЧитателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЗадолжностейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОЧитательскомБилетеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.кодВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодБилетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОВыдачеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодКнигиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеКнигиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияАвтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоСтраницDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расположениеВРядуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОКнигеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодАвтораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количестовБестселлеровDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОбАвтореBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодИздательстваDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.издательствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сайтИздательстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОИздательствеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информацияОЧитательскомБилетеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_читателеTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_о_читателеTableAdapter();
            this.информация_о_читательском_билетеTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_о_читательском_билетеTableAdapter();
            this.информация_о_выдачеTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_о_выдачеTableAdapter();
            this.информация_о_книгеTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_о_книгеTableAdapter();
            this.информация_об_автореTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_об_автореTableAdapter();
            this.информация_о_издательствеTableAdapter = new Kursovoi_proekt.LibraryDataSetTableAdapters.Информация_о_издательствеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReaders)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.PageReader.SuspendLayout();
            this.PageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickets)).BeginInit();
            this.PageGiveBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBook_give)).BeginInit();
            this.PageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.PageWriters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthor)).BeginInit();
            this.PagePublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublisher)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитателеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитательскомБилетеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОВыдачеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОКнигеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОбАвтореBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОИздательствеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитательскомБилетеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReaders
            // 
            this.DGVReaders.AutoGenerateColumns = false;
            this.DGVReaders.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЧитателяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.серияПаспортаDataGridViewTextBoxColumn,
            this.домашнийАдресDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn});
            this.DGVReaders.DataSource = this.информацияОЧитателеBindingSource;
            this.DGVReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVReaders.Location = new System.Drawing.Point(3, 3);
            this.DGVReaders.Name = "DGVReaders";
            this.DGVReaders.RowHeadersWidth = 51;
            this.DGVReaders.Size = new System.Drawing.Size(1094, 463);
            this.DGVReaders.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1108, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.toolStripSeparator3,
            this.DeleteButton,
            this.toolStripSeparator1,
            this.ChangeButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 471);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(67, 22);
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(60, 22);
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ChangeButton
            // 
            this.ChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChangeButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(67, 22);
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PageReader);
            this.tabControl.Controls.Add(this.PageTicket);
            this.tabControl.Controls.Add(this.PageGiveBook);
            this.tabControl.Controls.Add(this.PageBooks);
            this.tabControl.Controls.Add(this.PageWriters);
            this.tabControl.Controls.Add(this.PagePublishers);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1108, 496);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // PageReader
            // 
            this.PageReader.Controls.Add(this.DGVReaders);
            this.PageReader.Location = new System.Drawing.Point(4, 23);
            this.PageReader.Name = "PageReader";
            this.PageReader.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.PageReader.Size = new System.Drawing.Size(1100, 469);
            this.PageReader.TabIndex = 0;
            this.PageReader.Text = "Читатели";
            this.PageReader.UseVisualStyleBackColor = true;
            // 
            // PageTicket
            // 
            this.PageTicket.Controls.Add(this.DGVTickets);
            this.PageTicket.Location = new System.Drawing.Point(4, 23);
            this.PageTicket.Name = "PageTicket";
            this.PageTicket.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.PageTicket.Size = new System.Drawing.Size(1100, 469);
            this.PageTicket.TabIndex = 1;
            this.PageTicket.Text = "Читательские билеты";
            this.PageTicket.UseVisualStyleBackColor = true;
            // 
            // DGVTickets
            // 
            this.DGVTickets.AutoGenerateColumns = false;
            this.DGVTickets.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодБилетаDataGridViewTextBoxColumn2,
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn,
            this.кодЧитателяDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.рейтингЧитателяDataGridViewTextBoxColumn,
            this.количествоЗадолжностейDataGridViewTextBoxColumn});
            this.DGVTickets.DataSource = this.информацияОЧитательскомБилетеBindingSource1;
            this.DGVTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTickets.Location = new System.Drawing.Point(3, 3);
            this.DGVTickets.Name = "DGVTickets";
            this.DGVTickets.RowHeadersWidth = 51;
            this.DGVTickets.Size = new System.Drawing.Size(1094, 463);
            this.DGVTickets.TabIndex = 1;
            // 
            // PageGiveBook
            // 
            this.PageGiveBook.Controls.Add(this.DGVBook_give);
            this.PageGiveBook.Location = new System.Drawing.Point(4, 23);
            this.PageGiveBook.Name = "PageGiveBook";
            this.PageGiveBook.Size = new System.Drawing.Size(1100, 469);
            this.PageGiveBook.TabIndex = 2;
            this.PageGiveBook.Text = "Выдача книг";
            this.PageGiveBook.UseVisualStyleBackColor = true;
            // 
            // DGVBook_give
            // 
            this.DGVBook_give.AutoGenerateColumns = false;
            this.DGVBook_give.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVBook_give.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBook_give.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВыдачиDataGridViewTextBoxColumn,
            this.наименованиеКнигиDataGridViewTextBoxColumn,
            this.стоимостьКнигиDataGridViewTextBoxColumn,
            this.кодКнигиDataGridViewTextBoxColumn,
            this.кодАвтораDataGridViewTextBoxColumn,
            this.датаВыдачиDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn,
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn,
            this.кодБилетаDataGridViewTextBoxColumn1});
            this.DGVBook_give.DataSource = this.информацияОВыдачеBindingSource;
            this.DGVBook_give.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBook_give.Location = new System.Drawing.Point(0, 0);
            this.DGVBook_give.Name = "DGVBook_give";
            this.DGVBook_give.RowHeadersWidth = 51;
            this.DGVBook_give.Size = new System.Drawing.Size(1100, 469);
            this.DGVBook_give.TabIndex = 1;
            // 
            // PageBooks
            // 
            this.PageBooks.Controls.Add(this.DGVBooks);
            this.PageBooks.Location = new System.Drawing.Point(4, 23);
            this.PageBooks.Name = "PageBooks";
            this.PageBooks.Size = new System.Drawing.Size(1100, 469);
            this.PageBooks.TabIndex = 3;
            this.PageBooks.Text = "Книги";
            this.PageBooks.UseVisualStyleBackColor = true;
            // 
            // DGVBooks
            // 
            this.DGVBooks.AutoGenerateColumns = false;
            this.DGVBooks.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодКнигиDataGridViewTextBoxColumn1,
            this.наименованиеКнигиDataGridViewTextBoxColumn1,
            this.фамилияАвтораDataGridViewTextBoxColumn,
            this.количествоСтраницDataGridViewTextBoxColumn,
            this.наличиеDataGridViewTextBoxColumn,
            this.расположениеВРядуDataGridViewTextBoxColumn,
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn,
            this.рейтингDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2});
            this.DGVBooks.DataSource = this.информацияОКнигеBindingSource;
            this.DGVBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBooks.Location = new System.Drawing.Point(0, 0);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.RowHeadersWidth = 51;
            this.DGVBooks.Size = new System.Drawing.Size(1100, 469);
            this.DGVBooks.TabIndex = 1;
            // 
            // PageWriters
            // 
            this.PageWriters.Controls.Add(this.DGVAuthor);
            this.PageWriters.Location = new System.Drawing.Point(4, 23);
            this.PageWriters.Name = "PageWriters";
            this.PageWriters.Size = new System.Drawing.Size(1100, 469);
            this.PageWriters.TabIndex = 4;
            this.PageWriters.Text = "Авторы";
            this.PageWriters.UseVisualStyleBackColor = true;
            // 
            // DGVAuthor
            // 
            this.DGVAuthor.AutoGenerateColumns = false;
            this.DGVAuthor.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодАвтораDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn,
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn,
            this.количестовБестселлеровDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.DGVAuthor.DataSource = this.информацияОбАвтореBindingSource;
            this.DGVAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAuthor.Location = new System.Drawing.Point(0, 0);
            this.DGVAuthor.Name = "DGVAuthor";
            this.DGVAuthor.RowHeadersWidth = 51;
            this.DGVAuthor.Size = new System.Drawing.Size(1100, 469);
            this.DGVAuthor.TabIndex = 1;
            // 
            // PagePublishers
            // 
            this.PagePublishers.Controls.Add(this.DGVPublisher);
            this.PagePublishers.Location = new System.Drawing.Point(4, 23);
            this.PagePublishers.Name = "PagePublishers";
            this.PagePublishers.Size = new System.Drawing.Size(1100, 469);
            this.PagePublishers.TabIndex = 5;
            this.PagePublishers.Text = "Издательства";
            this.PagePublishers.UseVisualStyleBackColor = true;
            // 
            // DGVPublisher
            // 
            this.DGVPublisher.AutoGenerateColumns = false;
            this.DGVPublisher.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPublisher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодИздательстваDataGridViewTextBoxColumn1,
            this.издательствоDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.сайтИздательстваDataGridViewTextBoxColumn});
            this.DGVPublisher.DataSource = this.информацияОИздательствеBindingSource;
            this.DGVPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPublisher.Location = new System.Drawing.Point(0, 0);
            this.DGVPublisher.Name = "DGVPublisher";
            this.DGVPublisher.RowHeadersWidth = 51;
            this.DGVPublisher.Size = new System.Drawing.Size(1100, 469);
            this.DGVPublisher.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 469);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Администрирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 453);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_find_id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_ser_pas);
            this.groupBox2.Controls.Add(this.TB_find_reader);
            this.groupBox2.Controls.Add(this.TB_inf_ser);
            this.groupBox2.Controls.Add(this.CB_find_reader);
            this.groupBox2.Controls.Add(this.Reader_find);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск читателя";
            // 
            // TB_find_id
            // 
            this.TB_find_id.Location = new System.Drawing.Point(358, 137);
            this.TB_find_id.Name = "TB_find_id";
            this.TB_find_id.Size = new System.Drawing.Size(104, 20);
            this.TB_find_id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Код читателя и билета:";
            // 
            // TB_ser_pas
            // 
            this.TB_ser_pas.Location = new System.Drawing.Point(215, 45);
            this.TB_ser_pas.Name = "TB_ser_pas";
            this.TB_ser_pas.Size = new System.Drawing.Size(247, 20);
            this.TB_ser_pas.TabIndex = 5;
            // 
            // TB_find_reader
            // 
            this.TB_find_reader.Location = new System.Drawing.Point(215, 19);
            this.TB_find_reader.Name = "TB_find_reader";
            this.TB_find_reader.Size = new System.Drawing.Size(247, 20);
            this.TB_find_reader.TabIndex = 4;
            // 
            // TB_inf_ser
            // 
            this.TB_inf_ser.BackColor = System.Drawing.SystemColors.Window;
            this.TB_inf_ser.Location = new System.Drawing.Point(6, 45);
            this.TB_inf_ser.Name = "TB_inf_ser";
            this.TB_inf_ser.ReadOnly = true;
            this.TB_inf_ser.Size = new System.Drawing.Size(203, 20);
            this.TB_inf_ser.TabIndex = 3;
            this.TB_inf_ser.Text = "Серия паспорта";
            this.TB_inf_ser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_find_reader
            // 
            this.CB_find_reader.FormattingEnabled = true;
            this.CB_find_reader.Items.AddRange(new object[] {
            "Номер паспорта",
            "Номер телефона",
            "Номер билета"});
            this.CB_find_reader.Location = new System.Drawing.Point(6, 19);
            this.CB_find_reader.Name = "CB_find_reader";
            this.CB_find_reader.Size = new System.Drawing.Size(203, 22);
            this.CB_find_reader.TabIndex = 1;
            this.CB_find_reader.SelectedIndexChanged += new System.EventHandler(this.CB_find_reader_SelectedIndexChanged);
            // 
            // Reader_find
            // 
            this.Reader_find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reader_find.Location = new System.Drawing.Point(387, 191);
            this.Reader_find.Name = "Reader_find";
            this.Reader_find.Size = new System.Drawing.Size(75, 23);
            this.Reader_find.TabIndex = 0;
            this.Reader_find.Text = "Найти";
            this.Reader_find.UseVisualStyleBackColor = true;
            this.Reader_find.Click += new System.EventHandler(this.Reader_find_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_pubname);
            this.groupBox1.Controls.Add(this.TB_pubbook);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Book_find);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.TB_find_book);
            this.groupBox1.Controls.Add(this.TB_name_book);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск книги";
            // 
            // b_pubname
            // 
            this.b_pubname.FormattingEnabled = true;
            this.b_pubname.Location = new System.Drawing.Point(215, 45);
            this.b_pubname.Name = "b_pubname";
            this.b_pubname.Size = new System.Drawing.Size(186, 22);
            this.b_pubname.TabIndex = 8;
            this.b_pubname.SelectedIndexChanged += new System.EventHandler(this.b_pubname_SelectedIndexChanged);
            // 
            // TB_pubbook
            // 
            this.TB_pubbook.Location = new System.Drawing.Point(407, 45);
            this.TB_pubbook.Name = "TB_pubbook";
            this.TB_pubbook.Size = new System.Drawing.Size(55, 20);
            this.TB_pubbook.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Издательство";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Book_find
            // 
            this.Book_find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Book_find.Location = new System.Drawing.Point(387, 191);
            this.Book_find.Name = "Book_find";
            this.Book_find.Size = new System.Drawing.Size(75, 23);
            this.Book_find.TabIndex = 5;
            this.Book_find.Text = "Найти";
            this.Book_find.UseVisualStyleBackColor = true;
            this.Book_find.Click += new System.EventHandler(this.Book_find_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(203, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Наименование книги";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_find_book
            // 
            this.TB_find_book.BackColor = System.Drawing.SystemColors.Window;
            this.TB_find_book.Location = new System.Drawing.Point(362, 137);
            this.TB_find_book.Name = "TB_find_book";
            this.TB_find_book.ReadOnly = true;
            this.TB_find_book.Size = new System.Drawing.Size(100, 20);
            this.TB_find_book.TabIndex = 3;
            // 
            // TB_name_book
            // 
            this.TB_name_book.Location = new System.Drawing.Point(215, 19);
            this.TB_name_book.Name = "TB_name_book";
            this.TB_name_book.Size = new System.Drawing.Size(247, 20);
            this.TB_name_book.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код книги:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clear_logs);
            this.groupBox5.Controls.Add(this.open_log);
            this.groupBox5.Controls.Add(this.Log_list);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(485, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(607, 450);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Лог-файл";
            // 
            // clear_logs
            // 
            this.clear_logs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clear_logs.Location = new System.Drawing.Point(443, 420);
            this.clear_logs.Name = "clear_logs";
            this.clear_logs.Size = new System.Drawing.Size(158, 23);
            this.clear_logs.TabIndex = 2;
            this.clear_logs.Text = "Очистить лог-файл";
            this.clear_logs.UseVisualStyleBackColor = true;
            this.clear_logs.Click += new System.EventHandler(this.clear_logs_Click);
            // 
            // open_log
            // 
            this.open_log.ForeColor = System.Drawing.SystemColors.ControlText;
            this.open_log.Location = new System.Drawing.Point(279, 421);
            this.open_log.Name = "open_log";
            this.open_log.Size = new System.Drawing.Size(158, 23);
            this.open_log.TabIndex = 1;
            this.open_log.Text = "Открыть лог-файл";
            this.open_log.UseVisualStyleBackColor = true;
            this.open_log.Click += new System.EventHandler(this.open_log_Click);
            // 
            // Log_list
            // 
            this.Log_list.FormattingEnabled = true;
            this.Log_list.HorizontalScrollbar = true;
            this.Log_list.ItemHeight = 14;
            this.Log_list.Location = new System.Drawing.Point(6, 19);
            this.Log_list.Name = "Log_list";
            this.Log_list.Size = new System.Drawing.Size(595, 382);
            this.Log_list.TabIndex = 0;
            // 
            // кодБилетаDataGridViewTextBoxColumn
            // 
            this.кодБилетаDataGridViewTextBoxColumn.DataPropertyName = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn.HeaderText = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодБилетаDataGridViewTextBoxColumn.Name = "кодБилетаDataGridViewTextBoxColumn";
            this.кодБилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодЧитателяDataGridViewTextBoxColumn
            // 
            this.кодЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.HeaderText = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодЧитателяDataGridViewTextBoxColumn.Name = "кодЧитателяDataGridViewTextBoxColumn";
            this.кодЧитателяDataGridViewTextBoxColumn.Width = 80;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 140;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 140;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 140;
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            this.номерПаспортаDataGridViewTextBoxColumn.Width = 70;
            // 
            // серияПаспортаDataGridViewTextBoxColumn
            // 
            this.серияПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияПаспортаDataGridViewTextBoxColumn.Name = "серияПаспортаDataGridViewTextBoxColumn";
            this.серияПаспортаDataGridViewTextBoxColumn.Width = 70;
            // 
            // домашнийАдресDataGridViewTextBoxColumn
            // 
            this.домашнийАдресDataGridViewTextBoxColumn.DataPropertyName = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn.HeaderText = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.домашнийАдресDataGridViewTextBoxColumn.Name = "домашнийАдресDataGridViewTextBoxColumn";
            this.домашнийАдресDataGridViewTextBoxColumn.Width = 270;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 150;
            // 
            // информацияОЧитателеBindingSource
            // 
            this.информацияОЧитателеBindingSource.DataMember = "Информация о читателе";
            this.информацияОЧитателеBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кодБилетаDataGridViewTextBoxColumn2
            // 
            this.кодБилетаDataGridViewTextBoxColumn2.DataPropertyName = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn2.HeaderText = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.кодБилетаDataGridViewTextBoxColumn2.Name = "кодБилетаDataGridViewTextBoxColumn2";
            this.кодБилетаDataGridViewTextBoxColumn2.Width = 165;
            // 
            // номерЧитательскогоБилетаDataGridViewTextBoxColumn
            // 
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер читательского билета";
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn.HeaderText = "Номер билета";
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn.Name = "номерЧитательскогоБилетаDataGridViewTextBoxColumn";
            this.номерЧитательскогоБилетаDataGridViewTextBoxColumn.Width = 160;
            // 
            // кодЧитателяDataGridViewTextBoxColumn1
            // 
            this.кодЧитателяDataGridViewTextBoxColumn1.DataPropertyName = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn1.HeaderText = "Код читателя";
            this.кодЧитателяDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодЧитателяDataGridViewTextBoxColumn1.Name = "кодЧитателяDataGridViewTextBoxColumn1";
            this.кодЧитателяDataGridViewTextBoxColumn1.Width = 160;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 230;
            // 
            // рейтингЧитателяDataGridViewTextBoxColumn
            // 
            this.рейтингЧитателяDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг читателя";
            this.рейтингЧитателяDataGridViewTextBoxColumn.HeaderText = "Рейтинг читателя";
            this.рейтингЧитателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рейтингЧитателяDataGridViewTextBoxColumn.Name = "рейтингЧитателяDataGridViewTextBoxColumn";
            this.рейтингЧитателяDataGridViewTextBoxColumn.Width = 170;
            // 
            // количествоЗадолжностейDataGridViewTextBoxColumn
            // 
            this.количествоЗадолжностейDataGridViewTextBoxColumn.DataPropertyName = "Количество задолжностей";
            this.количествоЗадолжностейDataGridViewTextBoxColumn.HeaderText = "Количество задолжностей";
            this.количествоЗадолжностейDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоЗадолжностейDataGridViewTextBoxColumn.Name = "количествоЗадолжностейDataGridViewTextBoxColumn";
            this.количествоЗадолжностейDataGridViewTextBoxColumn.Width = 170;
            // 
            // информацияОЧитательскомБилетеBindingSource1
            // 
            this.информацияОЧитательскомБилетеBindingSource1.DataMember = "Информация о читательском билете";
            this.информацияОЧитательскомБилетеBindingSource1.DataSource = this.libraryDataSet;
            // 
            // кодВыдачиDataGridViewTextBoxColumn
            // 
            this.кодВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.HeaderText = "Код выдачи";
            this.кодВыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодВыдачиDataGridViewTextBoxColumn.Name = "кодВыдачиDataGridViewTextBoxColumn";
            this.кодВыдачиDataGridViewTextBoxColumn.Width = 110;
            // 
            // наименованиеКнигиDataGridViewTextBoxColumn
            // 
            this.наименованиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Наименование книги";
            this.наименованиеКнигиDataGridViewTextBoxColumn.HeaderText = "Наименование книги";
            this.наименованиеКнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеКнигиDataGridViewTextBoxColumn.Name = "наименованиеКнигиDataGridViewTextBoxColumn";
            this.наименованиеКнигиDataGridViewTextBoxColumn.Width = 160;
            // 
            // стоимостьКнигиDataGridViewTextBoxColumn
            // 
            this.стоимостьКнигиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость книги";
            this.стоимостьКнигиDataGridViewTextBoxColumn.HeaderText = "Стоимость книги";
            this.стоимостьКнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьКнигиDataGridViewTextBoxColumn.Name = "стоимостьКнигиDataGridViewTextBoxColumn";
            this.стоимостьКнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодКнигиDataGridViewTextBoxColumn
            // 
            this.кодКнигиDataGridViewTextBoxColumn.DataPropertyName = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.HeaderText = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКнигиDataGridViewTextBoxColumn.Name = "кодКнигиDataGridViewTextBoxColumn";
            this.кодКнигиDataGridViewTextBoxColumn.Width = 110;
            // 
            // кодАвтораDataGridViewTextBoxColumn
            // 
            this.кодАвтораDataGridViewTextBoxColumn.DataPropertyName = "Код автора";
            this.кодАвтораDataGridViewTextBoxColumn.HeaderText = "Код автора";
            this.кодАвтораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАвтораDataGridViewTextBoxColumn.Name = "кодАвтораDataGridViewTextBoxColumn";
            this.кодАвтораDataGridViewTextBoxColumn.Width = 110;
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            this.датаВыдачиDataGridViewTextBoxColumn.Width = 110;
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "Дата возврата";
            this.датаВозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            this.датаВозвратаDataGridViewTextBoxColumn.Width = 110;
            // 
            // номерБилетаВозвращавшегоDataGridViewTextBoxColumn
            // 
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn.DataPropertyName = "Номер билета возвращавшего";
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn.HeaderText = "Номер билета возвращавшего";
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn.Name = "номерБилетаВозвращавшегоDataGridViewTextBoxColumn";
            this.номерБилетаВозвращавшегоDataGridViewTextBoxColumn.Width = 120;
            // 
            // кодБилетаDataGridViewTextBoxColumn1
            // 
            this.кодБилетаDataGridViewTextBoxColumn1.DataPropertyName = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn1.HeaderText = "Код билета";
            this.кодБилетаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодБилетаDataGridViewTextBoxColumn1.Name = "кодБилетаDataGridViewTextBoxColumn1";
            this.кодБилетаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // информацияОВыдачеBindingSource
            // 
            this.информацияОВыдачеBindingSource.DataMember = "Информация о выдаче";
            this.информацияОВыдачеBindingSource.DataSource = this.libraryDataSet;
            // 
            // кодКнигиDataGridViewTextBoxColumn1
            // 
            this.кодКнигиDataGridViewTextBoxColumn1.DataPropertyName = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn1.HeaderText = "Код книги";
            this.кодКнигиDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодКнигиDataGridViewTextBoxColumn1.Name = "кодКнигиDataGridViewTextBoxColumn1";
            this.кодКнигиDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеКнигиDataGridViewTextBoxColumn1
            // 
            this.наименованиеКнигиDataGridViewTextBoxColumn1.DataPropertyName = "Наименование книги";
            this.наименованиеКнигиDataGridViewTextBoxColumn1.HeaderText = "Наименование книги";
            this.наименованиеКнигиDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.наименованиеКнигиDataGridViewTextBoxColumn1.Name = "наименованиеКнигиDataGridViewTextBoxColumn1";
            this.наименованиеКнигиDataGridViewTextBoxColumn1.Width = 200;
            // 
            // фамилияАвтораDataGridViewTextBoxColumn
            // 
            this.фамилияАвтораDataGridViewTextBoxColumn.DataPropertyName = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn.HeaderText = "Фамилия автора";
            this.фамилияАвтораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияАвтораDataGridViewTextBoxColumn.Name = "фамилияАвтораDataGridViewTextBoxColumn";
            this.фамилияАвтораDataGridViewTextBoxColumn.Width = 200;
            // 
            // количествоСтраницDataGridViewTextBoxColumn
            // 
            this.количествоСтраницDataGridViewTextBoxColumn.DataPropertyName = "Количество страниц";
            this.количествоСтраницDataGridViewTextBoxColumn.HeaderText = "Количество страниц";
            this.количествоСтраницDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоСтраницDataGridViewTextBoxColumn.Name = "количествоСтраницDataGridViewTextBoxColumn";
            this.количествоСтраницDataGridViewTextBoxColumn.Width = 90;
            // 
            // наличиеDataGridViewTextBoxColumn
            // 
            this.наличиеDataGridViewTextBoxColumn.DataPropertyName = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.HeaderText = "Наличие";
            this.наличиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наличиеDataGridViewTextBoxColumn.Name = "наличиеDataGridViewTextBoxColumn";
            this.наличиеDataGridViewTextBoxColumn.Width = 70;
            // 
            // расположениеВРядуDataGridViewTextBoxColumn
            // 
            this.расположениеВРядуDataGridViewTextBoxColumn.DataPropertyName = "Расположение в ряду";
            this.расположениеВРядуDataGridViewTextBoxColumn.HeaderText = "Расположение в ряду";
            this.расположениеВРядуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.расположениеВРядуDataGridViewTextBoxColumn.Name = "расположениеВРядуDataGridViewTextBoxColumn";
            this.расположениеВРядуDataGridViewTextBoxColumn.Width = 110;
            // 
            // являетсяЛиБестселлеромDataGridViewTextBoxColumn
            // 
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn.DataPropertyName = "Является ли бестселлером";
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn.HeaderText = "Является ли бестселлером";
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn.Name = "являетсяЛиБестселлеромDataGridViewTextBoxColumn";
            this.являетсяЛиБестселлеромDataGridViewTextBoxColumn.Width = 110;
            // 
            // рейтингDataGridViewTextBoxColumn
            // 
            this.рейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рейтингDataGridViewTextBoxColumn.Name = "рейтингDataGridViewTextBoxColumn";
            this.рейтингDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код издательства";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код издательства";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // информацияОКнигеBindingSource
            // 
            this.информацияОКнигеBindingSource.DataMember = "Информация о книге";
            this.информацияОКнигеBindingSource.DataSource = this.libraryDataSet;
            // 
            // кодАвтораDataGridViewTextBoxColumn1
            // 
            this.кодАвтораDataGridViewTextBoxColumn1.DataPropertyName = "Код автора";
            this.кодАвтораDataGridViewTextBoxColumn1.HeaderText = "Код автора";
            this.кодАвтораDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодАвтораDataGridViewTextBoxColumn1.Name = "кодАвтораDataGridViewTextBoxColumn1";
            this.кодАвтораDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия и инициалы автора";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия и инициалы автора";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 270;
            // 
            // количествоНаписанныхКнигDataGridViewTextBoxColumn
            // 
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn.DataPropertyName = "Количество написанных книг";
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn.HeaderText = "Количество написанных книг";
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn.Name = "количествоНаписанныхКнигDataGridViewTextBoxColumn";
            this.количествоНаписанныхКнигDataGridViewTextBoxColumn.Width = 150;
            // 
            // среднийРейтингЕгоКнигDataGridViewTextBoxColumn
            // 
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn.DataPropertyName = "Средний рейтинг его книг";
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn.HeaderText = "Средний рейтинг его книг";
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn.Name = "среднийРейтингЕгоКнигDataGridViewTextBoxColumn";
            this.среднийРейтингЕгоКнигDataGridViewTextBoxColumn.Width = 150;
            // 
            // количестовБестселлеровDataGridViewTextBoxColumn
            // 
            this.количестовБестселлеровDataGridViewTextBoxColumn.DataPropertyName = "Количестов бестселлеров";
            this.количестовБестселлеровDataGridViewTextBoxColumn.HeaderText = "Количестов бестселлеров";
            this.количестовБестселлеровDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количестовБестселлеровDataGridViewTextBoxColumn.Name = "количестовБестселлеровDataGridViewTextBoxColumn";
            this.количестовБестселлеровDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование самой продоваемой книги";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование самой продоваемой книги";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // информацияОбАвтореBindingSource
            // 
            this.информацияОбАвтореBindingSource.DataMember = "Информация об авторе";
            this.информацияОбАвтореBindingSource.DataSource = this.libraryDataSet;
            // 
            // кодИздательстваDataGridViewTextBoxColumn1
            // 
            this.кодИздательстваDataGridViewTextBoxColumn1.DataPropertyName = "Код издательства";
            this.кодИздательстваDataGridViewTextBoxColumn1.HeaderText = "Код издательства";
            this.кодИздательстваDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодИздательстваDataGridViewTextBoxColumn1.Name = "кодИздательстваDataGridViewTextBoxColumn1";
            this.кодИздательстваDataGridViewTextBoxColumn1.Width = 125;
            // 
            // издательствоDataGridViewTextBoxColumn
            // 
            this.издательствоDataGridViewTextBoxColumn.DataPropertyName = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.HeaderText = "Издательство";
            this.издательствоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.издательствоDataGridViewTextBoxColumn.Name = "издательствоDataGridViewTextBoxColumn";
            this.издательствоDataGridViewTextBoxColumn.Width = 210;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.Width = 150;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 170;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // сайтИздательстваDataGridViewTextBoxColumn
            // 
            this.сайтИздательстваDataGridViewTextBoxColumn.DataPropertyName = "Сайт издательства";
            this.сайтИздательстваDataGridViewTextBoxColumn.HeaderText = "Сайт издательства";
            this.сайтИздательстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сайтИздательстваDataGridViewTextBoxColumn.Name = "сайтИздательстваDataGridViewTextBoxColumn";
            this.сайтИздательстваDataGridViewTextBoxColumn.Width = 230;
            // 
            // информацияОИздательствеBindingSource
            // 
            this.информацияОИздательствеBindingSource.DataMember = "Информация о издательстве";
            this.информацияОИздательствеBindingSource.DataSource = this.libraryDataSet;
            // 
            // информацияОЧитательскомБилетеBindingSource
            // 
            this.информацияОЧитательскомБилетеBindingSource.DataMember = "Информация о читательском билете";
            this.информацияОЧитательскомБилетеBindingSource.DataSource = this.libraryDataSet;
            // 
            // информация_о_читателеTableAdapter
            // 
            this.информация_о_читателеTableAdapter.ClearBeforeFill = true;
            // 
            // информация_о_читательском_билетеTableAdapter
            // 
            this.информация_о_читательском_билетеTableAdapter.ClearBeforeFill = true;
            // 
            // информация_о_выдачеTableAdapter
            // 
            this.информация_о_выдачеTableAdapter.ClearBeforeFill = true;
            // 
            // информация_о_книгеTableAdapter
            // 
            this.информация_о_книгеTableAdapter.ClearBeforeFill = true;
            // 
            // информация_об_автореTableAdapter
            // 
            this.информация_об_автореTableAdapter.ClearBeforeFill = true;
            // 
            // информация_о_издательствеTableAdapter
            // 
            this.информация_о_издательствеTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1108, 518);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReaders)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.PageReader.ResumeLayout(false);
            this.PageTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickets)).EndInit();
            this.PageGiveBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBook_give)).EndInit();
            this.PageBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.PageWriters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAuthor)).EndInit();
            this.PagePublishers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPublisher)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитателеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитательскомБилетеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОВыдачеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОКнигеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОбАвтореBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОИздательствеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОЧитательскомБилетеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVReaders;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton AddButton;
        public System.Windows.Forms.ToolStripButton DeleteButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton ChangeButton;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage PageReader;
        public System.Windows.Forms.TabPage PageTicket;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.TabPage PageGiveBook;
        public System.Windows.Forms.TabPage PageBooks;
        public System.Windows.Forms.TabPage PageWriters;
        public System.Windows.Forms.TabPage PagePublishers;
        public System.Windows.Forms.DataGridView DGVTickets;
        public System.Windows.Forms.DataGridView DGVBook_give;
        public System.Windows.Forms.DataGridView DGVBooks;
        public System.Windows.Forms.DataGridView DGVAuthor;
        public System.Windows.Forms.DataGridView DGVPublisher;
        public LibraryDataSet libraryDataSet;
        public System.Windows.Forms.BindingSource информацияОЧитателеBindingSource;
        public LibraryDataSetTableAdapters.Информация_о_читателеTableAdapter информация_о_читателеTableAdapter;
        public System.Windows.Forms.BindingSource информацияОЧитательскомБилетеBindingSource;
        public LibraryDataSetTableAdapters.Информация_о_читательском_билетеTableAdapter информация_о_читательском_билетеTableAdapter;
        public System.Windows.Forms.BindingSource информацияОВыдачеBindingSource;
        public LibraryDataSetTableAdapters.Информация_о_выдачеTableAdapter информация_о_выдачеTableAdapter;
        public System.Windows.Forms.BindingSource информацияОКнигеBindingSource;
        public LibraryDataSetTableAdapters.Информация_о_книгеTableAdapter информация_о_книгеTableAdapter;
        public System.Windows.Forms.BindingSource информацияОбАвтореBindingSource;
        public LibraryDataSetTableAdapters.Информация_об_автореTableAdapter информация_об_автореTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource информацияОЧитательскомБилетеBindingSource1;
        public System.Windows.Forms.BindingSource информацияОИздательствеBindingSource;
        public LibraryDataSetTableAdapters.Информация_о_издательствеTableAdapter информация_о_издательствеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийАдресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодБилетаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЧитательскогоБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧитателяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингЧитателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЗадолжностейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодИздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСамойПродаваемойКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодИздательстваDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn издательствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сайтИздательстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБилетаВозвращавшегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодБилетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКнигиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеКнигиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияАвтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоСтраницDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расположениеВРядуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn являетсяЛиБестселлеромDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Log_list;
        private System.Windows.Forms.Button clear_logs;
        private System.Windows.Forms.Button open_log;
        private System.Windows.Forms.Button Reader_find;
        private System.Windows.Forms.ComboBox CB_find_reader;
        private System.Windows.Forms.TextBox TB_inf_ser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_ser_pas;
        private System.Windows.Forms.TextBox TB_find_reader;
        private System.Windows.Forms.TextBox TB_find_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаписанныхКнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn среднийРейтингЕгоКнигDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количестовБестселлеровDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox b_pubname;
        private System.Windows.Forms.TextBox TB_pubbook;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Book_find;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TB_find_book;
        private System.Windows.Forms.TextBox TB_name_book;
        private System.Windows.Forms.Label label1;
    }
}

