using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    public partial class kullanıcıtanıtmaForm : Form
    {
        public kullanıcıtanıtmaForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void Kaydet()
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Yeni bir kayıt eklemek için SqlCommand oluşturun
                    string insertQuery = "INSERT INTO kullanicilar (ad, soyad, numara, email,kurumAdi) " +
                                         "VALUES (@ad, @soyad, @numara, @email,@kurumAdi)";


                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    connection.Open();

                    insertCommand.Parameters.AddWithValue("@ad", txtAd.Text);
                    insertCommand.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    insertCommand.Parameters.AddWithValue("@kurumAdi", txtKurumAd.Text);
                    insertCommand.Parameters.AddWithValue("@numara", txtNumara.Text);
                    insertCommand.Parameters.AddWithValue("@email", txtEmail.Text);


                    // Yeni kaydı ekleyin
                    insertCommand.ExecuteNonQuery();

                    // Başarılı bir şekilde eklendiğine dair bir mesaj
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("BİR HATA OLUŞTU: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            Kaydet();
            if (checkBox1.Checked)
            {
                
                string ad = txtAd.Text.Trim();
                string sifre = txtSifre.Text.Trim();


                string dosyaYolu = "yetkiliuser.txt";

                try
                {
                    using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
                    {
                        // Kullanıcı bilgilerini dosyaya yaz
                        sw.WriteLine($"{ad},{sifre}");
                        Console.WriteLine("Yetkili kullanıcı bilgileri dosyaya eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
            }
            // normal kullaicilara ekle
            if (checkBox2.Checked)
            {
                string ad = txtAd.Text.Trim();
                string sifre = txtSifre.Text.Trim();


                string dosyaYolu = "user.txt";

                try
                {
                    using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
                    {
                        // Kullanıcı bilgilerini dosyaya yaz
                        sw.WriteLine($"{ad},{sifre}");
                        Console.WriteLine("Normal kullanıcı bilgileri dosyaya eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            referanslarForm gnl = new referanslarForm();
            gnl.Show();
            this.Hide();
        }

        private void kullanıcıtanıtmaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
