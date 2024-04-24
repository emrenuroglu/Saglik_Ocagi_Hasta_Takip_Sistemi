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
    public partial class doktortanitmaForm : Form
    {
        public doktortanitmaForm()
        {
            InitializeComponent();
        }

        private void doktortanitmaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Girilen doktor kodunu alın
                string girilenDoktorKodu = txtDrKodu.Text.Trim(); // Kullanıcının girdiği doktor kodu burada olmalı

                // SQL sorgusu
                string sqlSorgu = $"SELECT * FROM Doktorlar WHERE DoktorKodu = @girilenDoktorKodu";

                // Veritabanı bağlantısı ve komut oluşturma işlemleri burada yapılmalıdır
                // Bu sadece SQL sorgusunu oluşturur ve çalıştırılmaz

                // Örnek: SqlConnection ve SqlCommand kullanımı
                using (SqlConnection baglanti = new SqlConnection("Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True"))
                {
                    baglanti.Open();




                    using (SqlCommand komut = new SqlCommand(sqlSorgu, baglanti))
                    {


                        komut.Parameters.AddWithValue("@girilenDoktorKodu", girilenDoktorKodu);


                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Doktor bilgilerini al
                                string doktorAdi = reader["DoktorAdi"].ToString();
                                string doktorSoyadi = reader["DoktorSoyadi"].ToString();

                                // Kullanıcıya mesaj göster
                                DialogResult secim = MessageBox.Show($"Doktor Bilgileri Bulundu Kaydı açmak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (secim == DialogResult.Yes)
                                {
                                    txtDrAdı.Text = doktorAdi;
                                    txtDrSoyadı.Text = doktorSoyadi;
                                }
                                else
                                {
                                    genelform has = new genelform();
                                    has.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Doktor bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            referanslarForm gnl = new referanslarForm();
            gnl.Show();
            this.Hide();
        }
    }
}
