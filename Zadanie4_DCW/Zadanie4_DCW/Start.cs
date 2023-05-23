using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4_DCW
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        // metoda otwierająca okno sklep wewnątrz okna głównego
        private void sklepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sklep sklep = new Sklep();
            sklep.MdiParent = this;
            sklep.Show();
        }

        // metoda otwierająca okno produkt wewnątrz okna głównego
        private void produktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            produkt.MdiParent = this;
            produkt.Show();
        }
    }
}
