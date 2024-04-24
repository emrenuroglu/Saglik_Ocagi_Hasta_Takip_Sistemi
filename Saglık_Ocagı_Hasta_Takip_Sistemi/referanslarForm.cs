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
    public partial class referanslarForm : Form
    {
        public referanslarForm()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("LÜTFEN BİR POLİKLİNİK ADI GİRİNİZ");
                }
                else if (!string.IsNullOrEmpty(textBox1.Text))
                {

                    string poliklinikAdi = textBox1.Text;

                    string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "SELECT aciklama FROM poliklinik WHERE poliklinikAdi = @poliklinikAdi";

                            SqlCommand komut = new SqlCommand(query, connection);
                            komut.Parameters.AddWithValue("@poliklinikAdi", poliklinikAdi);

                            connection.Open();

                            SqlDataReader okuyucu = komut.ExecuteReader();

                            // Okuyucunun boş olup olmadığını kontrol et
                            if (okuyucu.HasRows)
                            {
                                PoliklinikForm poliklinikForm = new PoliklinikForm();
                                poliklinikForm.Gel(textBox1.Text);
                                poliklinikForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Okuyucunun satırı yoksa
                                // Bir uyarı mesajı göster
                                string msg = "Böyle bir poliklinik bulunamadı. Yeni bir kayıt açmak ister misiniz?";
                                string title = "Poliklinik Arama";
                                MessageBoxIcon icon = MessageBoxIcon.Question;
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult response = MessageBox.Show(msg, title, buttons, icon);

                                // Kullanıcının seçimine göre işlem yap
                                if (response == DialogResult.Yes)
                                {

                                    if (textBox1.Text.Length != 0 )
                                    {
                                        PoliklinikForm poli = new PoliklinikForm();
                                        poli.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("POLİKLİNİK ADI VE AÇIKLAMA BOŞ BIRAKILAMAZ");

                                        textBox1.Text = "";
                                    }

                                }
                                else
                                {
                                   textBox1.Text = "";
                                 
                                }
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata oluşursa, hata mesajını göster
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    e.Handled = true;
                }
            }
        }

        private void referanslarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıtanıtmaForm tanıtma = new kullanıcıtanıtmaForm();
            tanıtma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doktortanitmaForm doktortanitmaForm = new doktortanitmaForm();
            doktortanitmaForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personeltanitmaForm personeltanitmaForm = new personeltanitmaForm();
            personeltanitmaForm.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }
    }
}
