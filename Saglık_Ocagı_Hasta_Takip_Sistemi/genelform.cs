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
    public partial class genelform : Form
    {
        public genelform()
        {
            InitializeComponent();
        }

        private void hASTAKABULToolStripMenuItem_Click(object sender, EventArgs e)
        {
           hastakabulForm anaSayfa = new hastakabulForm();
            anaSayfa.Show();
            this.Hide();
        }

        private void rEFERANSLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            referanslargirisForm referanslar = new referanslargirisForm();
            referanslar.Show();
            this.Hide();
        }

        private void rAPORLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporlarForm rapor = new raporlarForm();
            rapor.Show();
            this.Hide();
        }

        private void genelform_Load(object sender, EventArgs e)
        {

        }
    }
}
