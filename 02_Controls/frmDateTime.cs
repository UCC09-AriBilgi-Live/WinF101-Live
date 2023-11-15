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
    // Form ilk ekrana geldiğinde 20 yıl öncesini göstersin...

    // Bizden ad soyad bilgisi ve doğum tarihi alınsın ve mesaj yazılsın
    // ama günü,ayı,yılı ayrıştırılmış şekilde olsun
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDateTime_Load(object sender, EventArgs e)
        {
            // 
            //dtpTarih.Value= DateTime.Now; // C# da varolan DateTime classının Now metodunu kullanmış oluyorum   bu satırla...

            dtpTarih.Value = DateTime.Today.AddYears(-20);

        }

        private void btonShow_Click(object sender, EventArgs e)
        {
            DateTime dgun = new DateTime();

            dgun = dtpTarih.Value;

            int dYil = dtpTarih.Value.Year; // sadece yıl bilgisi ogrenilir
            int dAy = dtpTarih.Value.Month; // sadece ay bilgisi ogrenilir
            int dGun = dtpTarih.Value.Day; // sadece gün bilgisi ogrenilir

            int buYil = DateTime.Now.Year;

            int yas = buYil - dYil;

            MessageBox.Show($"Sayın {tboxAdSoyad.Text} - Siz {dYil} yılının {dAy}. ayının {dGun}. gününde doğdunuz.....Dolayısıyla {yas} yaşındasınız...");

        }
    }
}
