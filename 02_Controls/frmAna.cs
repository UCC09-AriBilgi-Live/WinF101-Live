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
            Application.Exit(); // Programdan ��kar..(Sorgusuz sualsiz ��kar)
        }

        private void ��k��ToolStripMenuItem_Click(object sender, EventArgs e)
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


    }
}