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
    public partial class taburcuForm : Form
    {
        string poliklinik;
        string yapilan_islem;
        int dosya_no;
        string taburcu;
        public taburcuForm(string poli, string islem, int dosyano1)
        {
            InitializeComponent();
            poliklinik = poli;
            yapilan_islem = islem;
            dosya_no = dosyano1;

            string connectionString = "Data Source = EMRE\\SQLEXPRESS; Initial Catalog = Sağlıkocağıkayıt; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT taburcu FROM bilgiler WHERE dosya_no = @dosya_no";

                SqlCommand komut = new SqlCommand(query, connection);
                komut.Parameters.AddWithValue("@dosya_no", dosya_no);

                connection.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();

                while (okuyucu.Read())
                {
                    // Verileri TextBox kontrollerine ata.
                    cmbTaburcu.Text = okuyucu["taburcu"].ToString();
                }

                okuyucu.Close();
            }
        }

        private void taburcuForm_Load(object sender, EventArgs e)
        {
            txtPoliklinik.Text = poliklinik.ToString();
            txtYapılanislem.Text = yapilan_islem.ToString();
        }

        private void btnTaburcuet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaburcuet_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
