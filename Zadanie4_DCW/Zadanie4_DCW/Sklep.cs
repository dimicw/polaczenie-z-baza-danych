using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zadanie4_DCW
{
    public partial class Sklep : Form
    {
        public Sklep()
        {
            InitializeComponent();
        }

        private void Sklep_Load(object sender, EventArgs e)
        {
            // wczytanie danych z bazy do tabel
            this.sklepTableAdapter.Fill(this.zadanie4DataSet.sklep);

        }

        // metoda aktualizująca wartości dla wybranego wiersza
        private void bAktualizuj_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string sqlCommand = "UPDATE sklep SET miasto=@Miasto, ulica=@Ulica WHERE id=@ID";
                    SqlCommand cmd = new SqlCommand(sqlCommand, con);
                    cmd.Parameters.AddWithValue("@Miasto", tbMiasto.Text);
                    cmd.Parameters.AddWithValue("@Ulica", tbUlica.Text);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Zaaktualizowano dane", "Zaaktualizowano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

                // odświeżenie danych w tabeli sklep
                sklepTableAdapter.Fill(zadanie4DataSet.sklep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metoda usuwająca wybrany wiersz (wyrzuca błąd jeśli sklep jest przypisany do produktu w tabeli produkt)
        private void bUsun_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string sqlCommand = "DELETE FROM sklep WHERE id=@ID";
                    SqlCommand cmd = new SqlCommand(sqlCommand, con);
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Usunięto dane", "Usunięto pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

                // odświeżenie danych w tabeli sklep
                sklepTableAdapter.Fill(zadanie4DataSet.sklep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metoda dodająca nowy wiersz do tabeli
        private void bDodajNowy_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.zadanie4ConnectionString))
                {
                    con.Open();
                    string sqlCommand = "INSERT INTO sklep (miasto, ulica) VALUES(@Miasto, @Ulica);";

                    SqlCommand cmd = new SqlCommand(sqlCommand, con);
                    cmd.Parameters.AddWithValue("@Miasto", tbMiastoNowy.Text);
                    cmd.Parameters.AddWithValue("@Ulica", tbUlicaNowy.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Wprowadzono dane", "Wprowadzono pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }

                // odświeżenie danych w tabeli sklep
                sklepTableAdapter.Fill(zadanie4DataSet.sklep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // metoda wywoływana przy zamknięciu, pozwala zaakceptować lub odrzucić aktualizacje wartości, dla których nie było indywidualnie wciśnięte "aktualizuj"
        private void Sklep_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(
                    "Czy chcesz zapisać wprowadzone zmiany?", "Uwaga",
                    MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    sklepTableAdapter.Update(zadanie4DataSet.sklep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
