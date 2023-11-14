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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCheckBox_Load(object sender, EventArgs e)
        {
            // Formun ekrana ilk geldiğinde mutlaka çalışan yerdir (OnLoad event)

            lbelMessage.Visible = false;
        }

        private void chkbMessage_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox ın işaretli olup/olmamasına göre burası tetiklenecek
            if (chkbMessage.Checked == true) // ekrandaki chkb eğer seçilmişse olay true lanır
            {
                lbelMessage.Text = "Checkbox seçildi...";
            lbelMessage.Visible = true;
            }
            else
            {
                lbelMessage.Visible = false;
                //lbelMessage.Text = "Checkbox seçim kaldırıldı...";
            }



        }
    }
}
