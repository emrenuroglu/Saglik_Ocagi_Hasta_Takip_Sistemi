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
    public partial class girisekranıForm : Form
    {
        public girisekranıForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        bool giriskontrol()
        {
            string isim = textBox1.Text.Trim();
            string soyad = textBox2.Text.Trim();

            if (File.Exists("user.txt"))
            {

                string[] satirlar = File.ReadAllLines("user.txt");
                foreach(var satir in satirlar)
                {
                    string[] kullanicibilgileri = satir.Split(',');
                    if (kullanicibilgileri.Length == 2 &&
                        kullanicibilgileri[0].Trim() == isim && kullanicibilgileri[1].Trim() == soyad) {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("YANLIŞ KULLANICI ADI VEYA ŞİFRE !!");
                    }

                }

            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (giriskontrol())
            {
                genelform genelForm = new genelform();
                genelForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
        

    }
    

