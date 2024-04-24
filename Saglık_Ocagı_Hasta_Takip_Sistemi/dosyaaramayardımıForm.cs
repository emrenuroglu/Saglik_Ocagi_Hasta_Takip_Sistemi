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
    public partial class dosyaaramayardımıForm : Form
    {
        string secilen;
        public dosyaaramayardımıForm()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";
            secilen = cmbAramakriteri.Text;

            string query;
            SqlCommand command;
            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    switch (secilen)
                    {
                        case "ADI-SOYAD":
                            string[] adSoyad = txtAramakriter.Text.Split(' ');

                            if (adSoyad.Length != 2)
                            {
                                MessageBox.Show("Lütfen hasta adı ve soyadını boşluk bırakarak giriniz.");
                            }
                            else
                            {
                                query = "SELECT dosya_numarasi FROM bilgiler WHERE hasta_adi = @hasta_adi AND hasta_soyadi = @hasta_soyadi";
                                command = new SqlCommand(query, connection);

                                command.Parameters.AddWithValue("@hasta_adi", adSoyad[0]);
                                command.Parameters.AddWithValue("@hasta_soyadi", adSoyad[1]);

                                reader = command.ExecuteReader();

                                int dosyaNumarasi = 0;
                                if (reader.Read())
                                {
                                    dosyaNumarasi = reader.GetInt32(0);
                                    label3.Text = dosyaNumarasi.ToString();
                                }
                            }
                            break;

                        case "TELEFON NUMARASI":
                            string numara = txtAramakriter.Text;
                            query = "SELECT dosya_no FROM bilgiler WHERE numara = @numara";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@numara", numara);
                            reader = command.ExecuteReader();
                            int dosyaNumarasiTelefon = 0;
                            if (reader.Read())
                            {
                                dosyaNumarasiTelefon = reader.GetInt32(0);
                                label3.Text = dosyaNumarasiTelefon.ToString();
                            }
                            break;

                        case "E-MAİL":
                            string e_mail = txtAramakriter.Text;
                            query = "SELECT dosya_no FROM bilgiler WHERE e_mail = @e_mail";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@e_mail", e_mail);
                            reader = command.ExecuteReader();
                            int dosyaNumarasiEmail = 0;
                            if (reader.Read())
                            {
                                dosyaNumarasiEmail = reader.GetInt32(0);
                                label3.Text = dosyaNumarasiEmail.ToString();
                            }
                            break;

                        default:
                            MessageBox.Show("Lütfen geçerli bir arama kriteri seçiniz.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Close the connection in the finally block to ensure it gets closed even if an exception occurs
                }
            }
        }
    }
}
