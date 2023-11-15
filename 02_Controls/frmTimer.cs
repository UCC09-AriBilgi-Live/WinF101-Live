using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Controls
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            // forma girer girmez güncel saat dakka saniye göstersin

            int Saat = DateTime.Now.Hour; // saati çektim
            int Dakka = DateTime.Now.Minute;
            int Saniye = DateTime.Now.Second;


            lbelSaat.Text = Saat + ":" + Dakka + ":" + Saniye;
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonStart_Click(object sender, EventArgs e)
        {
            tmerSayac.Interval = Convert.ToInt32(nudSayac.Value);
            tmerSayac.Enabled = true;
        }

        private void btonStop_Click(object sender, EventArgs e)
        {
            tmerSayac.Enabled = false;
        }

        private void tmerSayac_Tick(object sender, EventArgs e)
        {
            int Saat = DateTime.Now.Hour; // saati çektim
            int Dakka = DateTime.Now.Minute;
            int Saniye = DateTime.Now.Second;


            lbelSaat.Text = Saat + ":" + Dakka + ":" + Saniye;
        }
    }
}
