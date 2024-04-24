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
    

    public partial class hastabilgileriForm : Form
    {
        int dosya_no;
        public void dosyanogetir(int dosya_no1)
        {
            dosya_no = dosya_no1;

        }
        public hastabilgileriForm()
        {
            InitializeComponent();
        }
        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }

        private void hastabilgileriForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = "SELECT dosya_no,hasta_adi,hasta_soyadi,numara,kurum_adi,taburcu,e_mail FROM bilgiler WHERE dosya_no = @dosya_no";

                    SqlCommand komut = new SqlCommand(query, connection);

                    // Parametre ekleyerek SQL injection saldırılarından korunun.
                    komut.Parameters.AddWithValue("@dosya_no", dosya_no);

                    // Bağlantıyı açın.
                    connection.Open();

                    // SqlDataReader nesnesini kullanarak verileri okuyun.
                    SqlDataReader okuyucu = komut.ExecuteReader();

                    if (okuyucu.Read())
                    {
                        // Verileri TextBox kontrollerine ata.
                        txtDosyaNo.Text = okuyucu["dosya_no"].ToString();
                        txtAd.Text = okuyucu["hasta_adi"].ToString();
                        txtSoyad.Text = okuyucu["hasta_soyadi"].ToString();
                        txtKurumAd.Text = okuyucu["kurum_adi"].ToString();
                        txtNumara.Text = okuyucu["numara"].ToString();
                        txtEmail.Text = okuyucu["e_mail"].ToString();               
                    }
                    else
                    {
                        MessageBox.Show("Veri bulunamadı");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";



            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    int dosya_numarasi = int.Parse(txtDosyaNo.Text);
                    string hasta_adi = txtAd.Text.Trim();
                    string hasta_soyadi = txtSoyad.Text.Trim();
                    string kurum_adi = txtKurumAd.Text.Trim();
                    string numara = txtNumara.Text.Trim();
                    string e_mail = txtEmail.Text.Trim();
                    

                    string query = "UPDATE bilgiler SET dosya_no = @dosya_no, hasta_adi = @hasta_adi,hasta_soyadi =@hasta_soyadi,kurum_adi=@kurum_adi,numara=@numara,e_mail=@e_mail WHERE dosya_no =@dosya_no";



                    SqlCommand komut = new SqlCommand(query, connection);
                    connection.Open();

                    // Parametre ekleyerek SQL injection saldırılarından korunun.
                    komut.Parameters.AddWithValue("@dosya_no", dosya_no);
                    komut.Parameters.AddWithValue("@hasta_adi", hasta_adi);
                    komut.Parameters.AddWithValue("@hasta_soyadi", hasta_soyadi);
                    komut.Parameters.AddWithValue("kurum_adi", kurum_adi);
                    komut.Parameters.AddWithValue("@numara", numara);
                    komut.Parameters.AddWithValue("@e_mail", e_mail);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("KAYIT GÜNCELLENDİ");

                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
