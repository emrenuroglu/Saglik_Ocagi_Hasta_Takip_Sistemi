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
    public partial class raporlarForm : Form
    {
        public raporlarForm()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.Clear();
                if (radioButton1.Checked)
                {
                    string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT dosya_no, taburcu, hasta_adi, hasta_soyadi, sevk_tarihi, poliklinik, yapilan_islem FROM bilgiler WHERE sevk_tarihi BETWEEN @dateTime1 and @dateTime2 and taburcu = 'True'";

                        SqlCommand komut = new SqlCommand(query, connection);

                        // Parametre ekleyerek SQL injection saldırılarından korunun.
                        komut.Parameters.AddWithValue("@dateTime1", SqlDbType.Date).Value = dateTimePicker1.Value;
                        komut.Parameters.AddWithValue("@dateTime2", SqlDbType.Date).Value = dateTimePicker2.Value;

                        // Bağlantıyı açın.
                        connection.Open();

                        // SqlDataReader nesnesini kullanarak verileri okuyun.
                        SqlDataReader okuyucu = komut.ExecuteReader();

                        // Tüm satırları okumak için while döngüsü kullanın.
                        while (okuyucu.Read())
                        {
                            // Okunan her satırı DataGridView'e ekleyin.
                            dataGridView1.Rows.Add(
                                okuyucu["dosya_no"].ToString(),
                                okuyucu["taburcu"].ToString(),
                                okuyucu["hasta_adi"].ToString(),
                                okuyucu["hasta_soyadi"].ToString(),
                                okuyucu["sevk_tarihi"].ToString(),
                                okuyucu["poliklinik"].ToString(),
                                okuyucu["yapilan_islem"].ToString()
                            );
                        }

                        // SqlDataReader'ı kapatın.
                        okuyucu.Close();

                        // Veri bulunamadıysa kullanıcıya bilgi verin.
                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("Veri bulunamadı");
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT dosya_no, taburcu, hasta_adi, hasta_soyadi, sevk_tarihi, poliklinik, yapilan_islem FROM bilgiler WHERE sevk_tarihi BETWEEN @dateTime1 and @dateTime2 and taburcu = 'False'";

                        SqlCommand komut = new SqlCommand(query, connection);

                        // Parametre ekleyerek SQL injection saldırılarından korunun.
                        komut.Parameters.AddWithValue("@dateTime1", SqlDbType.Date).Value = dateTimePicker1.Value;
                        komut.Parameters.AddWithValue("@dateTime2", SqlDbType.Date).Value = dateTimePicker2.Value;

                        // Bağlantıyı açın.
                        connection.Open();

                        // SqlDataReader nesnesini kullanarak verileri okuyun.
                        SqlDataReader okuyucu = komut.ExecuteReader();

                        // Tüm satırları okumak için while döngüsü kullanın.
                        while (okuyucu.Read())
                        {
                            // Okunan her satırı DataGridView'e ekleyin.
                            dataGridView1.Rows.Add(
                                okuyucu["dosya_no"].ToString(),
                                okuyucu["taburcu"].ToString(),
                                okuyucu["hasta_adi"].ToString(),
                                okuyucu["hasta_soyadi"].ToString(),
                                okuyucu["sevk_tarihi"].ToString(),
                                okuyucu["poliklinik"].ToString(),
                                okuyucu["yapilan_islem"].ToString()
                            );
                        }

                        // SqlDataReader'ı kapatın.
                        okuyucu.Close();

                        // Veri bulunamadıysa kullanıcıya bilgi verin.
                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("Veri bulunamadı");
                        }
                    }

                }
                else if (radioButton3.Checked)
                {
                    string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT dosya_no, taburcu, hasta_adi, hasta_soyadi, sevk_tarihi, poliklinik, yapilan_islem FROM bilgiler WHERE sevk_tarihi BETWEEN @dateTime1 and @dateTime2";

                        SqlCommand komut = new SqlCommand(query, connection);

                        // Parametre ekleyerek SQL injection saldırılarından korunun.
                        komut.Parameters.AddWithValue("@dateTime1", SqlDbType.Date).Value = dateTimePicker1.Value;
                        komut.Parameters.AddWithValue("@dateTime2", SqlDbType.Date).Value = dateTimePicker2.Value;

                        // Bağlantıyı açın.
                        connection.Open();

                        // SqlDataReader nesnesini kullanarak verileri okuyun.
                        SqlDataReader okuyucu = komut.ExecuteReader();

                        // Tüm satırları okumak için while döngüsü kullanın.
                        while (okuyucu.Read())
                        {
                            // Okunan her satırı DataGridView'e ekleyin.
                            dataGridView1.Rows.Add(
                                okuyucu["dosya_no"].ToString(),
                                okuyucu["taburcu"].ToString(),
                                okuyucu["hasta_adi"].ToString(),
                                okuyucu["hasta_soyadi"].ToString(),
                                okuyucu["sevk_tarihi"].ToString(),
                                okuyucu["poliklinik"].ToString(),
                                okuyucu["yapilan_islem"].ToString()
                            );
                        }

                        // SqlDataReader'ı kapatın.
                        okuyucu.Close();

                        // Veri bulunamadıysa kullanıcıya bilgi verin.
                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("Veri bulunamadı");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
