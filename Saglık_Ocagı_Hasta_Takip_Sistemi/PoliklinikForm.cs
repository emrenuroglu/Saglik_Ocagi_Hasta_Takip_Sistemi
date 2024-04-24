using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    public partial class PoliklinikForm : Form
    {

        string poliklinikAdi;
        public PoliklinikForm()
        {
            InitializeComponent();
        }
       public void Gel(string poliklinikadi)
        {
            poliklinikAdi=poliklinikadi;
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoliklinikForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM poliklinik WHERE poliklinikAdi = @poliklinikAdi";

                    SqlCommand komut = new SqlCommand(query, connection);
                    komut.Parameters.AddWithValue("@poliklinikAdi", poliklinikAdi);


                    connection.Open();

                    SqlDataReader okuyucu = komut.ExecuteReader();

                    // Okuyucunun boş olup olmadığını kontrol et
                    if (okuyucu.HasRows)
                    {
                        // Okuyucunun satırı varsa
                        while (okuyucu.Read())
                        {
                            // Verileri TextBox kontrollerine ata.
                            textBox1.Text = okuyucu["poliklinikAdi"].ToString();
                            textBox2.Text = okuyucu["aciklama"].ToString();
                           

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa, hata mesajını göster
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string poliklinikAdi = textBox1.Text.Trim();
            string aciklama = textBox2.Text.Trim();


            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE poliklinik SET poliklinikAdi = @poliklinikAdi, aciklama=@aciklama WHERE poliklinikAdi = @poliklinikAdi";

                    SqlCommand komut = new SqlCommand(query, connection);

                    connection.Open();
                    komut.Parameters.AddWithValue("@poliklinikAdi", poliklinikAdi);
                    komut.Parameters.AddWithValue("@aciklama", aciklama);


                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT GÜNCELLENDİ");

                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string poliklinikAdi = textBox1.Text.Trim();
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM poliklinik WHERE poliklinikAdi =@poliklinikAdi";

                    SqlCommand komut = new SqlCommand(query, connection);

                    connection.Open();
                    komut.Parameters.AddWithValue("@poliklinikAdi", poliklinikAdi);


                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT SİLİNDİ");

                    connection.Close();
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Ekleme(string poliklinikAdi, string aciklama)
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query2 = "INSERT INTO poliklinik (poliklinikAdi, aciklama) VALUES (@poliklinikAdi,@aciklama)";

                    SqlCommand insertCommand = new SqlCommand(query2, connection);

                    connection.Open();

                    insertCommand.Parameters.AddWithValue("@poliklinikAdi", poliklinikAdi);
                    insertCommand.Parameters.AddWithValue("@aciklama", aciklama);

                    insertCommand.ExecuteNonQuery();

                    // Başarılı bir şekilde eklendiğine dair bir mesaj
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            string poliklinikAdi = textBox1.Text.Trim();
            string aciklama = textBox2.Text.Trim();
            Ekleme(poliklinikAdi, aciklama);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            referanslargirisForm rfm = new referanslargirisForm();
            rfm.Show();
            this.Hide();
        }
    }
}
