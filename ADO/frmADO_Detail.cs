using Microsoft.Data.SqlClient;
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



    public partial class frmADO_Detail : Form
    {
        string vs_ConnStr = "Server = 94.73.144.17 ; Database = u7173324_NWind; user id=u7173324_NWind;password=Na79=YX2az@Co7-_; Trusted_Connection = False;Encrypt=false;";

        public string Mod = ""; // bu formun I,U,D işlemlerinden hangisini yapacağını tutan değişgen

        public frmADO_Detail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmADO_Detail_Load(object sender, EventArgs e)
        {

        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            string vs_SQLCommand = ""; // sql server tarafında calışacak insert komut satırını tutacak değişgen

            switch (Mod)
            {
                // aman dikkat.eğer verinizi dış dünyadaki hackerlardan korumak istorsanız asağıdaki parametresel yapıyı kullanmanız şiddetle önerilir.
                case "I":
                    vs_SQLCommand = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,Country) VALUES (@CustomerID,@CompanyName,@ContactName,@Country)";

                    break;

                case "U":
                    vs_SQLCommand = "UPDATE Customers SET ";
                    vs_SQLCommand += "CompanyName=@CompanyName,";
                    vs_SQLCommand += "ContactName=@ContactName,";
                    vs_SQLCommand += "Country=@Country ";
                    vs_SQLCommand += "WHERE CustomerID=@CustomerID";//*******

                    break;

                default:
                    break;
            }
            // yani işlemi yapabilmek için gerekli sql kod yapısı oluşturuldu.tek eksik için veri yok


            using (SqlConnection con= new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd=new SqlCommand(vs_SQLCommand,con))
                {
                    // yani şimdi parametrelerin doldurulma zamanı...

                    cmd.Parameters.AddWithValue("CustomerID", tboxCustomerID.Text);
                    cmd.Parameters.AddWithValue("CompanyName", tboxCompanyName.Text);
                    cmd.Parameters.AddWithValue("ContactName", tboxContactName.Text);
                    cmd.Parameters.AddWithValue("Country", tboxCountry.Text);

                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bilgileriniz veri tabanına başarıyla kayıt edildi");

                        this.Close();
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());

                    }
                }

            }
        }
    }
}

