namespace Zadanie4_DCW
{
    partial class Produkt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecieDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.lokalizacjaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sklepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadanie4DataSet = new Zadanie4_DCW.zadanie4DataSet();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lLokalizacjaNowy = new System.Windows.Forms.Label();
            this.cbLokalizacjaNowy = new System.Windows.Forms.ComboBox();
            this.lCenaNowy = new System.Windows.Forms.Label();
            this.lNazwaNowy = new System.Windows.Forms.Label();
            this.nudCenaNowy = new System.Windows.Forms.NumericUpDown();
            this.tbNazwaNowy = new System.Windows.Forms.TextBox();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bUsun = new System.Windows.Forms.Button();
            this.bZapisz = new System.Windows.Forms.Button();
            this.bWczytajZdjecie = new System.Windows.Forms.Button();
            this.lZdjecie = new System.Windows.Forms.Label();
            this.pbZdjecie = new System.Windows.Forms.PictureBox();
            this.lLokalizacja = new System.Windows.Forms.Label();
            this.cbLokalizacja = new System.Windows.Forms.ComboBox();
            this.lCena = new System.Windows.Forms.Label();
            this.lNazwa = new System.Windows.Forms.Label();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.produktTableAdapter = new Zadanie4_DCW.zadanie4DataSetTableAdapters.produktTableAdapter();
            this.sklepTableAdapter = new Zadanie4_DCW.zadanie4DataSetTableAdapters.sklepTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bWczytajZdjecieNowy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbZdjecieNowy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadanie4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaNowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecieNowy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.zdjecieDataGridViewImageColumn,
            this.lokalizacjaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 264;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 1162);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 120;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            dataGridViewCellStyle4.Format = "N2";
            this.cenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena [zł]";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 150;
            // 
            // zdjecieDataGridViewImageColumn
            // 
            this.zdjecieDataGridViewImageColumn.DataPropertyName = "zdjecie";
            this.zdjecieDataGridViewImageColumn.HeaderText = "zdjecie";
            this.zdjecieDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.zdjecieDataGridViewImageColumn.MinimumWidth = 8;
            this.zdjecieDataGridViewImageColumn.Name = "zdjecieDataGridViewImageColumn";
            this.zdjecieDataGridViewImageColumn.Width = 460;
            // 
            // lokalizacjaidDataGridViewTextBoxColumn
            // 
            this.lokalizacjaidDataGridViewTextBoxColumn.DataPropertyName = "lokalizacja_id";
            this.lokalizacjaidDataGridViewTextBoxColumn.DataSource = this.sklepBindingSource;
            this.lokalizacjaidDataGridViewTextBoxColumn.DisplayMember = "miasto";
            this.lokalizacjaidDataGridViewTextBoxColumn.HeaderText = "lokalizacja";
            this.lokalizacjaidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lokalizacjaidDataGridViewTextBoxColumn.Name = "lokalizacjaidDataGridViewTextBoxColumn";
            this.lokalizacjaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lokalizacjaidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lokalizacjaidDataGridViewTextBoxColumn.ValueMember = "id";
            this.lokalizacjaidDataGridViewTextBoxColumn.Width = 150;
            // 
            // sklepBindingSource
            // 
            this.sklepBindingSource.DataMember = "sklep";
            this.sklepBindingSource.DataSource = this.zadanie4DataSet;
            // 
            // zadanie4DataSet
            // 
            this.zadanie4DataSet.DataSetName = "zadanie4DataSet";
            this.zadanie4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "produkt";
            this.produktBindingSource.DataSource = this.zadanie4DataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1344, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 1162);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Aktualizuj zdjęcie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aktualizuj/usuń wpis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nowy wpis";
            // 
            // lLokalizacjaNowy
            // 
            this.lLokalizacjaNowy.AutoSize = true;
            this.lLokalizacjaNowy.Location = new System.Drawing.Point(3, 128);
            this.lLokalizacjaNowy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLokalizacjaNowy.Name = "lLokalizacjaNowy";
            this.lLokalizacjaNowy.Size = new System.Drawing.Size(85, 20);
            this.lLokalizacjaNowy.TabIndex = 17;
            this.lLokalizacjaNowy.Text = "lokalizacja:";
            // 
            // cbLokalizacjaNowy
            // 
            this.cbLokalizacjaNowy.DataSource = this.sklepBindingSource;
            this.cbLokalizacjaNowy.DisplayMember = "miasto";
            this.cbLokalizacjaNowy.FormattingEnabled = true;
            this.cbLokalizacjaNowy.Location = new System.Drawing.Point(101, 123);
            this.cbLokalizacjaNowy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLokalizacjaNowy.Name = "cbLokalizacjaNowy";
            this.cbLokalizacjaNowy.Size = new System.Drawing.Size(366, 28);
            this.cbLokalizacjaNowy.TabIndex = 16;
            this.cbLokalizacjaNowy.ValueMember = "id";
            // 
            // lCenaNowy
            // 
            this.lCenaNowy.AutoSize = true;
            this.lCenaNowy.Location = new System.Drawing.Point(41, 85);
            this.lCenaNowy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCenaNowy.Name = "lCenaNowy";
            this.lCenaNowy.Size = new System.Drawing.Size(48, 20);
            this.lCenaNowy.TabIndex = 15;
            this.lCenaNowy.Text = "cena:";
            // 
            // lNazwaNowy
            // 
            this.lNazwaNowy.AutoSize = true;
            this.lNazwaNowy.Location = new System.Drawing.Point(30, 45);
            this.lNazwaNowy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNazwaNowy.Name = "lNazwaNowy";
            this.lNazwaNowy.Size = new System.Drawing.Size(59, 20);
            this.lNazwaNowy.TabIndex = 14;
            this.lNazwaNowy.Text = "nazwa:";
            // 
            // nudCenaNowy
            // 
            this.nudCenaNowy.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudCenaNowy.DecimalPlaces = 2;
            this.nudCenaNowy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCenaNowy.Location = new System.Drawing.Point(101, 81);
            this.nudCenaNowy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCenaNowy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCenaNowy.Name = "nudCenaNowy";
            this.nudCenaNowy.Size = new System.Drawing.Size(368, 26);
            this.nudCenaNowy.TabIndex = 13;
            // 
            // tbNazwaNowy
            // 
            this.tbNazwaNowy.Location = new System.Drawing.Point(101, 40);
            this.tbNazwaNowy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNazwaNowy.Name = "tbNazwaNowy";
            this.tbNazwaNowy.Size = new System.Drawing.Size(366, 26);
            this.tbNazwaNowy.TabIndex = 12;
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(99, 516);
            this.bAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(368, 35);
            this.bAddNew.TabIndex = 11;
            this.bAddNew.Text = "Dodaj nowy";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(101, 166);
            this.bUsun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(182, 35);
            this.bUsun.TabIndex = 10;
            this.bUsun.Text = "Usuń";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // bZapisz
            // 
            this.bZapisz.Location = new System.Drawing.Point(291, 166);
            this.bZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bZapisz.Name = "bZapisz";
            this.bZapisz.Size = new System.Drawing.Size(177, 35);
            this.bZapisz.TabIndex = 9;
            this.bZapisz.Text = "Aktualizuj";
            this.bZapisz.UseVisualStyleBackColor = true;
            this.bZapisz.Click += new System.EventHandler(this.bZapisz_Click);
            // 
            // bWczytajZdjecie
            // 
            this.bWczytajZdjecie.Location = new System.Drawing.Point(7, 272);
            this.bWczytajZdjecie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bWczytajZdjecie.Name = "bWczytajZdjecie";
            this.bWczytajZdjecie.Size = new System.Drawing.Size(84, 35);
            this.bWczytajZdjecie.TabIndex = 8;
            this.bWczytajZdjecie.Text = "wczytaj";
            this.bWczytajZdjecie.UseVisualStyleBackColor = true;
            this.bWczytajZdjecie.Click += new System.EventHandler(this.bWczytajZdjecie_Click);
            // 
            // lZdjecie
            // 
            this.lZdjecie.AutoSize = true;
            this.lZdjecie.Location = new System.Drawing.Point(27, 247);
            this.lZdjecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lZdjecie.Name = "lZdjecie";
            this.lZdjecie.Size = new System.Drawing.Size(62, 20);
            this.lZdjecie.TabIndex = 7;
            this.lZdjecie.Text = "zdjęcie:";
            // 
            // pbZdjecie
            // 
            this.pbZdjecie.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.produktBindingSource, "zdjecie", true));
            this.pbZdjecie.Location = new System.Drawing.Point(101, 247);
            this.pbZdjecie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbZdjecie.Name = "pbZdjecie";
            this.pbZdjecie.Size = new System.Drawing.Size(368, 335);
            this.pbZdjecie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZdjecie.TabIndex = 6;
            this.pbZdjecie.TabStop = false;
            // 
            // lLokalizacja
            // 
            this.lLokalizacja.AutoSize = true;
            this.lLokalizacja.Location = new System.Drawing.Point(3, 129);
            this.lLokalizacja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLokalizacja.Name = "lLokalizacja";
            this.lLokalizacja.Size = new System.Drawing.Size(85, 20);
            this.lLokalizacja.TabIndex = 5;
            this.lLokalizacja.Text = "lokalizacja:";
            // 
            // cbLokalizacja
            // 
            this.cbLokalizacja.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produktBindingSource, "lokalizacja_id", true));
            this.cbLokalizacja.DataSource = this.sklepBindingSource;
            this.cbLokalizacja.DisplayMember = "miasto";
            this.cbLokalizacja.FormattingEnabled = true;
            this.cbLokalizacja.Location = new System.Drawing.Point(101, 124);
            this.cbLokalizacja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLokalizacja.Name = "cbLokalizacja";
            this.cbLokalizacja.Size = new System.Drawing.Size(366, 28);
            this.cbLokalizacja.TabIndex = 4;
            this.cbLokalizacja.ValueMember = "id";
            // 
            // lCena
            // 
            this.lCena.AutoSize = true;
            this.lCena.Location = new System.Drawing.Point(41, 86);
            this.lCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCena.Name = "lCena";
            this.lCena.Size = new System.Drawing.Size(48, 20);
            this.lCena.TabIndex = 3;
            this.lCena.Text = "cena:";
            // 
            // lNazwa
            // 
            this.lNazwa.AutoSize = true;
            this.lNazwa.Location = new System.Drawing.Point(30, 46);
            this.lNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNazwa.Name = "lNazwa";
            this.lNazwa.Size = new System.Drawing.Size(59, 20);
            this.lNazwa.TabIndex = 2;
            this.lNazwa.Text = "nazwa:";
            // 
            // nudCena
            // 
            this.nudCena.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudCena.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produktBindingSource, "cena", true));
            this.nudCena.DecimalPlaces = 2;
            this.nudCena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCena.Location = new System.Drawing.Point(101, 83);
            this.nudCena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(368, 26);
            this.nudCena.TabIndex = 1;
            // 
            // tbNazwa
            // 
            this.tbNazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "nazwa", true));
            this.tbNazwa.Location = new System.Drawing.Point(101, 41);
            this.tbNazwa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(366, 26);
            this.tbNazwa.TabIndex = 0;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // sklepTableAdapter
            // 
            this.sklepTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 1150);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bUsun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbNazwa);
            this.tabPage1.Controls.Add(this.nudCena);
            this.tabPage1.Controls.Add(this.lNazwa);
            this.tabPage1.Controls.Add(this.lCena);
            this.tabPage1.Controls.Add(this.cbLokalizacja);
            this.tabPage1.Controls.Add(this.lLokalizacja);
            this.tabPage1.Controls.Add(this.bZapisz);
            this.tabPage1.Controls.Add(this.bWczytajZdjecie);
            this.tabPage1.Controls.Add(this.lZdjecie);
            this.tabPage1.Controls.Add(this.pbZdjecie);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 871);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktualizuj";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bWczytajZdjecieNowy);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bAddNew);
            this.tabPage2.Controls.Add(this.pbZdjecieNowy);
            this.tabPage2.Controls.Add(this.tbNazwaNowy);
            this.tabPage2.Controls.Add(this.nudCenaNowy);
            this.tabPage2.Controls.Add(this.lLokalizacjaNowy);
            this.tabPage2.Controls.Add(this.lNazwaNowy);
            this.tabPage2.Controls.Add(this.cbLokalizacjaNowy);
            this.tabPage2.Controls.Add(this.lCenaNowy);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 1117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bWczytajZdjecieNowy
            // 
            this.bWczytajZdjecieNowy.Location = new System.Drawing.Point(5, 186);
            this.bWczytajZdjecieNowy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bWczytajZdjecieNowy.Name = "bWczytajZdjecieNowy";
            this.bWczytajZdjecieNowy.Size = new System.Drawing.Size(84, 35);
            this.bWczytajZdjecieNowy.TabIndex = 26;
            this.bWczytajZdjecieNowy.Text = "wczytaj";
            this.bWczytajZdjecieNowy.UseVisualStyleBackColor = true;
            this.bWczytajZdjecieNowy.Click += new System.EventHandler(this.bWczytajZdjecieNowy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "zdjęcie:";
            // 
            // pbZdjecieNowy
            // 
            this.pbZdjecieNowy.Location = new System.Drawing.Point(99, 161);
            this.pbZdjecieNowy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbZdjecieNowy.Name = "pbZdjecieNowy";
            this.pbZdjecieNowy.Size = new System.Drawing.Size(368, 335);
            this.pbZdjecieNowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZdjecieNowy.TabIndex = 24;
            this.pbZdjecieNowy.TabStop = false;
            this.pbZdjecieNowy.Tag = "0";
            // 
            // Produkt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 1162);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Produkt";
            this.Text = "Produkt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Produkt_FormClosing);
            this.Load += new System.EventHandler(this.Produkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadanie4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaNowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecieNowy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private zadanie4DataSet zadanie4DataSet;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private zadanie4DataSetTableAdapters.produktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource sklepBindingSource;
        private zadanie4DataSetTableAdapters.sklepTableAdapter sklepTableAdapter;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.Label lLokalizacja;
        private System.Windows.Forms.ComboBox cbLokalizacja;
        //private System.Windows.Forms.BindingSource sklepBindingSource1;
        private System.Windows.Forms.Label lCena;
        private System.Windows.Forms.Label lNazwa;
        private System.Windows.Forms.Button bWczytajZdjecie;
        private System.Windows.Forms.Label lZdjecie;
        private System.Windows.Forms.PictureBox pbZdjecie;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Button bZapisz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lLokalizacjaNowy;
        private System.Windows.Forms.ComboBox cbLokalizacjaNowy;
        private System.Windows.Forms.Label lCenaNowy;
        private System.Windows.Forms.Label lNazwaNowy;
        private System.Windows.Forms.NumericUpDown nudCenaNowy;
        private System.Windows.Forms.TextBox tbNazwaNowy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn zdjecieDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lokalizacjaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bWczytajZdjecieNowy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbZdjecieNowy;
    }
}