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
    public partial class frmADO : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_ConnStr = "Server = 94.73.144.17 ; Database = u7173324_NWind; user id=u7173324_NWind;password=Na79=YX2az@Co7-_; Trusted_Connection = False;Encrypt=false;"; // Connection String : veritabanına bağlanma için
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
            PrepareGrid();
            BindGrid(); // dg yi doldursun
        }

        private void PrepareGrid()
        {
            // Ekrandaki datagrid i ayarlar...

            // Set AutoGenerateColumns --> false
            dgrdCustomers.AutoGenerateColumns = false;

            // Set AllowUser..false...ekrandan grid üzerinden kayıt ekleme yapmasın...benim butonuma mahkum olsun. 
            dgrdCustomers.AllowUserToAddRows = false;
            dgrdCustomers.AllowUserToDeleteRows = false;

            // Set AutoSizeColumnsMode --> Fill -- colonların genişlikleriyle ilgili
            dgrdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrdCustomers.RowHeadersVisible = false;

            dgrdCustomers.AllowUserToResizeRows = false;

            dgrdCustomers.ReadOnly = true;

            dgrdCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgrdCustomers.ColumnCount = 4;

            // Add columns

            dgrdCustomers.Columns[0].Name = "CustomerID";
            dgrdCustomers.Columns[0].HeaderText = "Customer ID";
            dgrdCustomers.Columns[0].DataPropertyName = "CustomerID";

            dgrdCustomers.Columns[1].Name = "CompanyName";
            dgrdCustomers.Columns[1].HeaderText = "Company Name";
            dgrdCustomers.Columns[1].DataPropertyName = "CompanyName";

            dgrdCustomers.Columns[2].Name = "ContactName";
            dgrdCustomers.Columns[2].HeaderText = "Contact Name";
            dgrdCustomers.Columns[2].DataPropertyName = "ContactName";

            dgrdCustomers.Columns[3].Name = "Country";
            dgrdCustomers.Columns[3].HeaderText = "Country";
            dgrdCustomers.Columns[3].DataPropertyName = "Country";
        }

        private void BindGrid()
        {
            // VT nındaki bilgileri alıp DG içine gömmek için

            //using (SqlConnection connection = new SqlConnection(@"Data Source=BILCE\\ARIBILGI;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=True;Encrypt=False;"))

            vs_SQLCommand = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
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


        private void ShowData(string prmMode)
        {
            frmADO_Detail frmADO_Detail = new frmADO_Detail();

            frmADO_Detail.Mod = prmMode;

            // IUD durumuna göre ekran komponent ayarları yapılıyor

            switch (prmMode)
            {
                case "I": // Insert Modu için
                    frmADO_Detail.tboxCustomerID.Enabled = true;
                    frmADO_Detail.tboxCustomerID.Text = "";
                    frmADO_Detail.tboxCompanyName.Text = "";
                    frmADO_Detail.tboxContactName.Text = "";
                    frmADO_Detail.tboxCountry.Text = "";

                    break;

                case "U": // Update Modu için
                    frmADO_Detail.tboxCustomerID.Enabled = false;
                    // dg üzerindeki ilgili alanlardaki veriler detay formunun ilgili yerlerine yerleştiriliyor
                    frmADO_Detail.tboxCustomerID.Text = dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
                    frmADO_Detail.tboxCompanyName.Text = dgrdCustomers.CurrentRow.Cells[1].Value.ToString();
                    frmADO_Detail.tboxContactName.Text = dgrdCustomers.CurrentRow.Cells[2].Value.ToString();
                    frmADO_Detail.tboxCountry.Text = dgrdCustomers.CurrentRow.Cells[3].Value.ToString();

                    break;

                default:
                    break;
            }

            frmADO_Detail.ShowDialog();
        }


        private void btonAdd_Click(object sender, EventArgs e)
        {
            ShowData("I"); // 3 ayrı işlemi (I,U,D) tek metotda birleştiren benim yazdığım metot
            BindGrid();

        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U"); // 3 ayrı işlemi (I,U,D) tek metotda birleştiren benim yazdığım metot
            BindGrid();


        }

        private void dgrdCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // dg üzerinde herhangi bir satırda çift tıklama ile forma gitme...
            ShowData("U"); // 3 ayrı işlemi (I,U,D) tek metotda birleştiren benim yazdığım metot
            BindGrid();
        }
    }
}
