namespace Zadanie4_DCW
{
    partial class Sklep
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sklepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zadanie4DataSet = new Zadanie4_DCW.zadanie4DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sklepTableAdapter = new Zadanie4_DCW.zadanie4DataSetTableAdapters.sklepTableAdapter();
            this.tbMiasto = new System.Windows.Forms.TextBox();
            this.lMiasto = new System.Windows.Forms.Label();
            this.lUlica = new System.Windows.Forms.Label();
            this.tbUlica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUlicaNowy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiastoNowy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bAktualizuj = new System.Windows.Forms.Button();
            this.bUsun = new System.Windows.Forms.Button();
            this.bDodajNowy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadanie4DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sklepBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bDodajNowy);
            this.panel1.Controls.Add(this.bUsun);
            this.panel1.Controls.Add(this.bAktualizuj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbUlicaNowy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMiastoNowy);
            this.panel1.Controls.Add(this.lUlica);
            this.panel1.Controls.Add(this.tbUlica);
            this.panel1.Controls.Add(this.lMiasto);
            this.panel1.Controls.Add(this.tbMiasto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 450);
            this.panel1.TabIndex = 1;
            // 
            // sklepTableAdapter
            // 
            this.sklepTableAdapter.ClearBeforeFill = true;
            // 
            // tbMiasto
            // 
            this.tbMiasto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sklepBindingSource, "miasto", true));
            this.tbMiasto.Location = new System.Drawing.Point(55, 37);
            this.tbMiasto.Name = "tbMiasto";
            this.tbMiasto.Size = new System.Drawing.Size(256, 20);
            this.tbMiasto.TabIndex = 0;
            // 
            // lMiasto
            // 
            this.lMiasto.AutoSize = true;
            this.lMiasto.Location = new System.Drawing.Point(14, 37);
            this.lMiasto.Name = "lMiasto";
            this.lMiasto.Size = new System.Drawing.Size(41, 13);
            this.lMiasto.TabIndex = 1;
            this.lMiasto.Text = "Miasto:";
            // 
            // lUlica
            // 
            this.lUlica.AutoSize = true;
            this.lUlica.Location = new System.Drawing.Point(14, 63);
            this.lUlica.Name = "lUlica";
            this.lUlica.Size = new System.Drawing.Size(34, 13);
            this.lUlica.TabIndex = 3;
            this.lUlica.Text = "Ulica:";
            // 
            // tbUlica
            // 
            this.tbUlica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sklepBindingSource, "ulica", true));
            this.tbUlica.Location = new System.Drawing.Point(55, 63);
            this.tbUlica.Name = "tbUlica";
            this.tbUlica.Size = new System.Drawing.Size(256, 20);
            this.tbUlica.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ulica:";
            // 
            // tbUlicaNowy
            // 
            this.tbUlicaNowy.Location = new System.Drawing.Point(55, 183);
            this.tbUlicaNowy.Name = "tbUlicaNowy";
            this.tbUlicaNowy.Size = new System.Drawing.Size(256, 20);
            this.tbUlicaNowy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miasto:";
            // 
            // tbMiastoNowy
            // 
            this.tbMiastoNowy.Location = new System.Drawing.Point(55, 157);
            this.tbMiastoNowy.Name = "tbMiastoNowy";
            this.tbMiastoNowy.Size = new System.Drawing.Size(256, 20);
            this.tbMiastoNowy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dodaj wpis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aktualizuj/usuń wpis";
            // 
            // bAktualizuj
            // 
            this.bAktualizuj.Location = new System.Drawing.Point(55, 89);
            this.bAktualizuj.Name = "bAktualizuj";
            this.bAktualizuj.Size = new System.Drawing.Size(122, 23);
            this.bAktualizuj.TabIndex = 10;
            this.bAktualizuj.Text = "aktualizuj";
            this.bAktualizuj.UseVisualStyleBackColor = true;
            this.bAktualizuj.Click += new System.EventHandler(this.bAktualizuj_Click);
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(183, 89);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(128, 23);
            this.bUsun.TabIndex = 11;
            this.bUsun.Text = "usuń";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // bDodajNowy
            // 
            this.bDodajNowy.Location = new System.Drawing.Point(123, 209);
            this.bDodajNowy.Name = "bDodajNowy";
            this.bDodajNowy.Size = new System.Drawing.Size(188, 23);
            this.bDodajNowy.TabIndex = 12;
            this.bDodajNowy.Text = "dodaj nowy";
            this.bDodajNowy.UseVisualStyleBackColor = true;
            this.bDodajNowy.Click += new System.EventHandler(this.bDodajNowy_Click);
            // 
            // Sklep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sklep";
            this.Text = "Sklep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sklep_FormClosing);
            this.Load += new System.EventHandler(this.Sklep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sklepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zadanie4DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private zadanie4DataSet zadanie4DataSet;
        private System.Windows.Forms.BindingSource sklepBindingSource;
        private zadanie4DataSetTableAdapters.sklepTableAdapter sklepTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bDodajNowy;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Button bAktualizuj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUlicaNowy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiastoNowy;
        private System.Windows.Forms.Label lUlica;
        private System.Windows.Forms.TextBox tbUlica;
        private System.Windows.Forms.Label lMiasto;
        private System.Windows.Forms.TextBox tbMiasto;
    }
}