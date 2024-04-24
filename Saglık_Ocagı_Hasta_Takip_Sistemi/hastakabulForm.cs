using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    public partial class hastakabulForm : Form
    {
        public int poliklinikSiraNo = 1;
        decimal toplamTutar = 0;
        int rowIndex;
        public hastakabulForm()
        {
            InitializeComponent();
          
        }
        public void Kaydet()
        {
            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Yeni bir kayıt eklemek için SqlCommand oluşturun
                    string insertQuery = "INSERT INTO bilgiler (dosya_no, sevk_tarihi, poliklinik, hasta_adi, hasta_soyadi, yapilan_islem, dr_kodu, miktar, birim_fiyat,taburcu,taburcu_saat,kurum_adi,e_mail,numara) " +
                                         "VALUES (@dosya_no, @sevk_tarihi, @poliklinik, @hasta_adi, @hasta_soyadi, @yapilan_islem, @dr_kodu, @miktar, @birim_fiyat,@taburcu,@taburcu_saat,@kurum_adi,@e_mail,@numara)";


                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    connection.Open();

                    insertCommand.Parameters.AddWithValue("@dosya_no", int.Parse(txtDosyaNo.Text));
                    insertCommand.Parameters.AddWithValue("@sevk_tarihi", dateTimePicker1.Value);
                    insertCommand.Parameters.AddWithValue("@poliklinik", string.Format(cmbPoliklinik.Text));
                    insertCommand.Parameters.AddWithValue("@hasta_adi", txtHastaAd.Text); 
                    insertCommand.Parameters.AddWithValue("@hasta_soyadi", txtHastaSoyad.Text); 
                    insertCommand.Parameters.AddWithValue("@yapilan_islem", cmbYapılanİslem.Text); 
                    insertCommand.Parameters.AddWithValue("@dr_kodu", int.Parse(cmbDrKodu.Text));
                    insertCommand.Parameters.AddWithValue("@miktar", int.Parse(nudMiktar.Value.ToString()));
                    insertCommand.Parameters.AddWithValue("@birim_fiyat", decimal.Parse(txtBirimFİyat.Text));
                    insertCommand.Parameters.AddWithValue("@taburcu", 0);
                    insertCommand.Parameters.AddWithValue("@taburcu_saat", DateTime.Now);
                    insertCommand.Parameters.AddWithValue("@kurum_adi", txtKurumAd.Text);
                    insertCommand.Parameters.AddWithValue("@e_mail", "emrenuroglu@gmail.com");
                    insertCommand.Parameters.AddWithValue("@numara", "05537112853");

                    // Yeni kaydı ekleyin
                    insertCommand.ExecuteNonQuery();

                    // Başarılı bir şekilde eklendiğine dair bir mesaj
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajını göster
                MessageBox.Show("BOK: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Hesapla(int adet, decimal fiyat)
        {
            toplamTutar += adet * fiyat;
            label15.Text = toplamTutar.ToString();
        }
        private void txtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.Rows.Clear();
                if (string.IsNullOrEmpty(txtDosyaNo.Text))
                {
                    MessageBox.Show("DOSYA NUMARASI GİRİNİZ");
                }
                else if (!string.IsNullOrEmpty(txtDosyaNo.Text))
                {
                    // burada enter yaptığımız zaman hasta adı ve soyadı gelsin
                    int dosya_no = int.Parse(txtDosyaNo.Text);

                    string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "SELECT hasta_adi,hasta_soyadi,kurum_adi,poliklinik,yapilan_islem,dr_kodu,miktar,birim_fiyat FROM bilgiler WHERE dosya_no = @dosya_no";

                            SqlCommand komut = new SqlCommand(query, connection);
                            komut.Parameters.AddWithValue("@dosya_no", dosya_no);

                            connection.Open();

                            SqlDataReader okuyucu = komut.ExecuteReader();

                            while (okuyucu.Read())
                            {
                                txtHastaAd.Text = okuyucu["hasta_adi"].ToString();
                                txtHastaSoyad.Text = okuyucu["hasta_soyadi"].ToString();
                                txtKurumAd.Text = okuyucu["kurum_adi"].ToString();

                                string poliklinik = okuyucu["poliklinik"].ToString();
                                DateTime saat = DateTime.Now;
                                string yapilanislem = okuyucu["yapilan_islem"].ToString();
                                string drkodu = okuyucu["dr_kodu"].ToString();
                                string adet = okuyucu["miktar"].ToString();
                                string fiyat = okuyucu["birim_fiyat"].ToString();

                                Hesapla(int.Parse(adet), decimal.Parse(fiyat));
                                poliklinikSiraNo++;

                                dataGridView1.Rows.Add(poliklinik, poliklinikSiraNo, saat, yapilanislem, drkodu, adet, fiyat);
                            }

                            okuyucu.Close();

                            if (dataGridView1.Rows.Count == 0)
                            {
                                MessageBox.Show("Veri bulunamadı");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    e.Handled = true;
                }
            }


        }


        string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";
        private void anasayfa_Load(object sender, EventArgs e)
        {
           
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            girisekranıForm form1 = new girisekranıForm();
            form1.Show();
            this.Hide();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtDosyaNo.Clear();
            txtBirimFİyat.Clear();
            txtHastaAd.Clear();
            txtHastaSoyad.Clear();
            txtKurumAd.Clear();
            txtSıraNo.Clear();
            txtÖncekiİslem.Clear();
            cmbDrKodu.Text = "";
            cmbPoliklinik.Text = "";
            cmbYapılanİslem.Text = "";
            nudMiktar.Value = 0;
            dataGridView1.Rows.Clear();
            toplamTutar = 0;
            
        }

        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            hastabilgileriForm hastaBilgileri = new hastabilgileriForm();
            hastaBilgileri.dosyanogetir(Convert.ToInt32(txtDosyaNo.Text));
            hastaBilgileri.Show();
            this.Hide();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kaydet();
                string poliklinik = cmbPoliklinik.Text;
                DateTime saat = DateTime.Now;
                string yapilanislem = cmbYapılanİslem.Text;
                int drkodu = int.Parse(cmbDrKodu.Text);
                int adet = int.Parse(nudMiktar.Text);
                int fiyat = int.Parse(txtBirimFİyat.Text);

                dataGridView1.Rows.Add(poliklinik, poliklinikSiraNo, saat, yapilanislem, drkodu, adet, fiyat);

                txtSıraNo.Text = string.Format("{0}", poliklinikSiraNo);
                poliklinikSiraNo++;
                txtSıraNo.ReadOnly = true;
                Hesapla(adet, fiyat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dosyaaramayardımıForm dosyanoarama = new dosyaaramayardımıForm();
            dosyanoarama.Show();
            this.Hide();
        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçili satır sayısını al
                int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                
                if (selectedRowCount > 0)
                {
                    // İlk seçili satırı al
                    DataGridViewRow selectedRow1 = dataGridView1.SelectedRows[0];
                    // Satırın index numarasını al
                    rowIndex = selectedRow1.Index;
                    // MessageBox'ta göster
                    MessageBox.Show("Seçili satır: " + rowIndex);


                }

                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                
                taburcuForm taburcu = new taburcuForm(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[3].Value.ToString(), int.Parse(txtDosyaNo.Text.ToString()));
               taburcu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
       
        
        private void btnÖnizle_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridViewRow selectedRow;

            // Seçili satırları al
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedRow = row;

                // Yazdırma işlemini gerçekleştir

                e.Graphics.DrawString("HASTA ADI : " + txtHastaAd.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 10);
                e.Graphics.DrawString("HASTA SOYADI : " + txtHastaSoyad.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 40);
                e.Graphics.DrawString("KURUM ADI : " + txtKurumAd.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 70);
                e.Graphics.DrawString("POLİKLİNİK ADI  :" + selectedRow.Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 100);
                e.Graphics.DrawString("SIRA NUMARASI : " + selectedRow.Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 130);
                e.Graphics.DrawString("SAAT : " + selectedRow.Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 160);
                e.Graphics.DrawString("YAPILAN İŞLEM : " + selectedRow.Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 190);
                e.Graphics.DrawString("DOKTOR KODU : " + selectedRow.Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 210);
                e.Graphics.DrawString("MİKTAR : " + selectedRow.Cells[5].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 230);
                e.Graphics.DrawString("BİRİM FİYATI : " + selectedRow.Cells[6].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 260);
            }
        }
    }
}
