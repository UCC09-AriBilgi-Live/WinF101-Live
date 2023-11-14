namespace _02_Controls
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programdan çýkar..(Sorgusuz sualsiz çýkar)
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckBox frmCheckBox = new frmCheckBox();

            frmCheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckedListBox frmCheckedListBox = new frmCheckedListBox();

            frmCheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComboBox frmComboBox = new frmComboBox();

            frmComboBox.ShowDialog();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOthers frmOthers = new frmOthers();

            frmOthers.ShowDialog();
        }
    }
}