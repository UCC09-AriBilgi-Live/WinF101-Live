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
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void frmCheckedListBox_Load(object sender, EventArgs e)
        {
            lbelMessage.Visible = false;
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MesajiVer()
        {
            var secilenDiller = new List<string>(); // checklist içinde seçmiş olduğum elemanlar tutacak(sanki dizi)

            foreach (var dil in chkbDiller.CheckedItems) // sadece ve sadece seçilmiş elemanları alacağım..
            {
                secilenDiller.Add(dil.ToString()); // listeye add metoduyla ekledi
            }

            // dizimi doldurdum...seçili elemanlarla

            lbelMessage.Text = $"Üzerinde uğraşmakta olduğunuz diller : {string.Join(", ", secilenDiller)}";

            lbelMessage.Visible = true;
        }

        private void btonMessage_Click(object sender, EventArgs e)
        {
            MesajiVer();
        }

        private void rbtnHepsi_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(true);
        }

        private void rbtnHicbiri_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(false);
        }

        private void CheckAyarla(bool checkState)
        {
            for (int i = 0; i < chkbDiller.Items.Count; i++)
            {
                chkbDiller.SetItemChecked(i, checkState);
            }

            MesajiVer();

        }
    }
}
