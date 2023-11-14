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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            lbelMessage.Visible = false;

        }

        private void btonSay_Click(object sender, EventArgs e)
        {
            // ekrandaki combobox içinde kaç eleman var

            lbelMessage.Text = "Combobox içinde " + cbocSehir.Items.Count.ToString() + " adet Şehir vardır...";

            lbelMessage.Visible = true;
        }

        private void cboxHangi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // öncelikle yeni bilgi için için temizleyim. Sonuç kısmının
            cboxSonuc.Items.Clear();
            cboxSonuc.Text = "";

            string secilen = (string)cboxHangi.SelectedItem;

            if (secilen == "Haftanın günleri")
            {
                // önce bir dizi yarat - manuel ve içini doldur
                string[] gunler = { "Pzt", "Salı", "Çarş", "Perş", "Cuma", "Cmrts", "Paz" };

                cboxSonuc.Items.AddRange(gunler);

            }
            else
            {
                string[] yillar = { "2020", "2021", "2022", "2023", "2024", "2025", "2026" };

                cboxSonuc.Items.AddRange(yillar);
            }
        }
    }
}
