using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    public partial class referanslargirisForm : Form
    {
        public referanslargirisForm()
        {
            InitializeComponent();
        }

        private void referanslarForm_Load(object sender, EventArgs e)
        {

        }
        bool giriskontrol()
        {
            string ad = txtYetkiliAd.Text.Trim();
            string sifre = txtYetkiliSifre.Text.Trim();

            string dosyaYolu = "yetkiliuser.txt";

            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (var satir in satirlar)
                {
                    string[] kullaniciBilgileri = satir.Split(',');

                    if (kullaniciBilgileri.Length == 2 &&
                        kullaniciBilgileri[0].Trim() == ad &&
                        kullaniciBilgileri[1].Trim() == sifre)
                    {
                        return true;
                    }
                }

                MessageBox.Show("YANLIŞ KULLANICI ADI VE/VEYA ŞİFRE");
            }
            else
            {
                MessageBox.Show("Kullanıcı dosyası bulunamadı.");
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (giriskontrol())
            {
                referanslarForm referans = new referanslarForm();
                referans.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtYetkiliAd.Clear();
            txtYetkiliSifre.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
