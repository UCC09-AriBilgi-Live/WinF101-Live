namespace _01_HelloWorld
{
    // Formun arka planda �al��an kodlar� buraya yaz�l�yor.yani class�n i�ine
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent(); // Constructor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.yol
            //MessageBox.Show("Merhaba sevgili " + tboxAd.Text + " " + tboxSoyad.Text.ToUpper() + "....Bug�n nass�n?..");

            using(frmMessage frmMessage = new frmMessage()) // �unu kullanarak...yani burada frmMessage class�n�(form) kullanarak
            {
                frmMessage.Text = "Mesaj�n�z var....."; // formun title
                frmMessage.lbelMessage.Text = "Merhaba sevgili " + tboxAd.Text + " " + tboxSoyad.Text.ToUpper() + "....Bug�n nass�n?.."; // Modifiers a dikkat

                if (frmMessage.ShowDialog() == DialogResult.OK) // gelen ekrandan OK mi/Cancel mi yap�ld� acaba kontrolu
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