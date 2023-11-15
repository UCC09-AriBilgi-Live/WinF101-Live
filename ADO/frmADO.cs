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

namespace ADO
{
    public partial class frmADO : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları





        public frmADO()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmADO_Load(object sender, EventArgs e)
        {
            //PrepareGrid();
            BindGrid(); // dg yi doldursun
        }

        private void PrepareGrid()
        {
            // Ekrandaki datagrid i ayarlar...

            dgrdCustomers.AutoGenerateColumns = true;

            dgrdCustomers.AllowUserToAddRows = true;

        }

        private void BindGrid()
        {
            // VT nındaki bilgileri alıp DG içine gömmek için

            //using (SqlConnection connection = new SqlConnection(@"Data Source=BILCE\\ARIBILGI;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=True;Encrypt=False;"))


            using (SqlConnection connection = new SqlConnection(@"Server = petdurak.duckdns.org,1433 ; Database = Northwind; user id=sa;password=wv2l5ct7m22056; Trusted_Connection = False;Encrypt=false;"))

                
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            dgrdCustomers.DataSource = dset.Tables[0];

                        }
                    }
                }

            }
        }
    }
}
