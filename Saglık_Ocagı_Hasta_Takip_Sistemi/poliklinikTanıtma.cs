using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saglık_Ocagı_Hasta_Takip_Sistemi
{
    public partial class poliklinikTanıtma : Form
    {
        public poliklinikTanıtma()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            genelform geri = new genelform();
            geri.Show();
            this.Hide();
        }

        private void poliklinikTanıtma_Load(object sender, EventArgs e)
        {

        }
    }
}
