namespace _01_HelloWorld
{
    // Formun arka planda çalýþan kodlarý buraya yazýlýyor.yani classýn içine
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent(); // Constructor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.yol
            //MessageBox.Show("Merhaba sevgili " + tboxAd.Text + " " + tboxSoyad.Text.ToUpper() + "....Bugün nassýn?..");

            using(frmMessage frmMessage = new frmMessage()) // þunu kullanarak...yani burada frmMessage classýný(form) kullanarak
            {
                frmMessage.Text = "Mesajınız var....."; // formun title
                frmMessage.lbelMessage.Text = "Merhaba sevgili " + tboxAd.Text + " " + tboxSoyad.Text.ToUpper() + "....Bugün nassın?.."; // Modifiers a dikkat

                if (frmMessage.ShowDialog() == DialogResult.OK) // gelen ekrandan OK mi/Cancel mi yapýldý acaba kontrolu
                {
                    tboxAd.Text = "";
                    tboxSoyad.Text = "";
                }
                else
                {
                    tboxAd.BackColor = Color.Red;
                    tboxSoyad.BackColor = Color.Blue;
                }



            }


        }
    }
}