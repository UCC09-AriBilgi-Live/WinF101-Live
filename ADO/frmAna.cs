using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_ADO
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void menü1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void costomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmADO frmADO = new frmADO();

            frmADO.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();

            frmProducts.ShowDialog();
        }
    }
}
