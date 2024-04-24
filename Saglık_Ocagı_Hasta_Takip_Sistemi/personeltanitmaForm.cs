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
    public partial class personeltanitmaForm : Form
    {
        public personeltanitmaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Girilen doktor kodunu alın
                string girilenPersonelKodu = txtPrsKodu.Text.Trim(); // Kullanıcının girdiği doktor kodu burada olmalı

                // SQL sorgusu
                string sqlSorgu = $"SELECT * FROM SaglikOcagiPersonel WHERE PersonelKodu = @girilenPersonelKodu";

                // Veritabanı bağlantısı ve komut oluşturma işlemleri burada yapılmalıdır
                // Bu sadece SQL sorgusunu oluşturur ve çalıştırılmaz

                // Örnek: SqlConnection ve SqlCommand kullanımı
                using (SqlConnection baglanti = new SqlConnection("Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True"))
                {
                    baglanti.Open();




                    using (SqlCommand komut = new SqlCommand(sqlSorgu, baglanti))
                    {


                        komut.Parameters.AddWithValue("@girilenPersonelKodu", girilenPersonelKodu);


                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Doktor bilgilerini al
                                string PersonelAdi = reader["PersonelAdi"].ToString();
                                string PersonelSoyadi = reader["PersonelSoyadi"].ToString();

                                // Kullanıcıya mesaj göster
                                DialogResult secim = MessageBox.Show($"Personel Bilgileri Bulundu Kaydı açmak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (secim == DialogResult.Yes)
                                {
                                    txtPrsAdı.Text = PersonelAdi;
                                    txtPrsSoyadı.Text = PersonelSoyadi;
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
                                MessageBox.Show("Personel bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
