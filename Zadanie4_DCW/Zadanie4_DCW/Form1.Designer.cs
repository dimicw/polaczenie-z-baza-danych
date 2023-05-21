namespace Zadanie4_DCW
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sklepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sklepToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sklepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sklepToolStripMenuItem
            // 
            this.sklepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sklepToolStripMenuItem1,
            this.produktToolStripMenuItem});
            this.sklepToolStripMenuItem.Name = "sklepToolStripMenuItem";
            this.sklepToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.sklepToolStripMenuItem.Text = "Tabela";
            // 
            // sklepToolStripMenuItem1
            // 
            this.sklepToolStripMenuItem1.Name = "sklepToolStripMenuItem1";
            this.sklepToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sklepToolStripMenuItem1.Text = "Sklep";
            this.sklepToolStripMenuItem1.Click += new System.EventHandler(this.sklepToolStripMenuItem1_Click);
            // 
            // produktToolStripMenuItem
            // 
            this.produktToolStripMenuItem.Name = "produktToolStripMenuItem";
            this.produktToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produktToolStripMenuItem.Text = "Produkt";
            this.produktToolStripMenuItem.Click += new System.EventHandler(this.produktToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 645);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Zadanie 4 - Baza Danych";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sklepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sklepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produktToolStripMenuItem;
    }
}

