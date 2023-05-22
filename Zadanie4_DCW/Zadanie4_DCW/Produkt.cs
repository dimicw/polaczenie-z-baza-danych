using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace Zadanie4_DCW
{
    public partial class Produkt : Form
    {
        public Produkt()
        {
            InitializeComponent();
        }

        private void Produkt_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadanie4DataSet.sklep' . Możesz go przenieść lub usunąć.
            this.sklepTableAdapter.Fill(this.zadanie4DataSet.sklep);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'zadanie4DataSet.produkt' . Możesz go przenieść lub usunąć.
            this.produktTableAdapter.Fill(this.zadanie4DataSet.produkt);
        }

        //usuwa wybrany wiersz
        private void bUsun_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string sqlCommand = "DELETE FROM produkt WHERE id=@ID";
                    SqlCommand cmd = new SqlCommand(sqlCommand, con);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Usunięto dane", "Usunięto pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

                produktTableAdapter.Fill(zadanie4DataSet.produkt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //aktualizuje dane dla wybranego wiersza
        private void bZapisz_Click(object sender, EventArgs e)
        {            
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string sqlCommand = "UPDATE produkt SET nazwa=@Nazwa, cena=@Cena, lokalizacja_id=@LokID WHERE id=@ID";
                    SqlCommand cmd = new SqlCommand(sqlCommand, con);
                    cmd.Parameters.AddWithValue("@Nazwa", tbNazwa.Text);
                    cmd.Parameters.AddWithValue("@Cena", nudCena.Value);
                    cmd.Parameters.AddWithValue("@LokID", cbLokalizacja.SelectedValue);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Zaaktualizowano dane", "Zaaktualizowano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

                produktTableAdapter.Fill(zadanie4DataSet.produkt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //wczytuje nowe zdjęcie z pliku 
        private void bWczytajZdjecie_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files(*.bmp;*.jpg;*.gif)| *.bmp; *.jpg; *.gif" };
            string path = "";

            if (ofd.ShowDialog() == DialogResult.OK) 
                path = ofd.FileName;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataRow dr = zadanie4DataSet.produkt.Select("id=" + id).FirstOrDefault();
            if (path != "") 
                dr["zdjecie"] = ImageToByte(path);
            produktTableAdapter.Update(zadanie4DataSet.produkt);
        }


        //funkcja wywoływana przy zamknięciu, pozwala zaakceptować lub odrzucić aktualizacje wartości, dla których nie było indywidualnie wciśnięte "aktualizuj"
        private void Produkt_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(
                    "Czy chcesz zapisać wprowadzone zmiany?", "Uwaga",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    produktTableAdapter.Update(zadanie4DataSet.produkt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //zmienia obraz w tablicę byte
        public static byte[] ImageToByte(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] photo = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return photo;
        }

        //dodaje nowy wiersz do tabeli
        private void bAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string path = pbZdjecieNowy.Tag as string;
                    if (path != "0")
                    {
                        string sqlCommand = "INSERT INTO produkt (nazwa, cena, lokalizacja_id, zdjecie) VALUES(@Nazwa, @Cena, @Lokalizacja, @Zdjecie);";

                        SqlCommand cmd = new SqlCommand(sqlCommand, con);
                        cmd.Parameters.AddWithValue("@Nazwa", tbNazwaNowy.Text);
                        cmd.Parameters.AddWithValue("@Cena", nudCenaNowy.Value);
                        cmd.Parameters.AddWithValue("@Lokalizacja", cbLokalizacjaNowy.SelectedValue);
                        cmd.Parameters.AddWithValue("@Zdjecie", File.ReadAllBytes(path));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Wprowadzono dane", "Wprowadzono pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        string sqlCommand = "INSERT INTO produkt (nazwa, cena, lokalizacja_id) VALUES(@Nazwa, @Cena, @Lokalizacja);";

                        SqlCommand cmd = new SqlCommand(sqlCommand, con);
                        cmd.Parameters.AddWithValue("@Nazwa", tbNazwaNowy.Text);
                        cmd.Parameters.AddWithValue("@Cena", nudCenaNowy.Value);
                        cmd.Parameters.AddWithValue("@Lokalizacja", cbLokalizacjaNowy.SelectedValue);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Wprowadzono dane", "Wprowadzono pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    con.Close();
                }

                produktTableAdapter.Fill(zadanie4DataSet.produkt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //wczytanie zdjęcia 
        private void bWczytajZdjecieNowy_Click(object sender, EventArgs e)
        {
            //okno dialogowe wyboru pliku obrazu
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files(*.bmp;*.jpg;*.gif)| *.bmp; *.jpg; *.gif" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbZdjecieNowy.Image = Image.FromFile(ofd.FileName);
                pbZdjecieNowy.Tag = ofd.FileName;
            }
        }
    }
}
