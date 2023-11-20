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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _03_ADO
{
    public partial class frmProducts : Form
    {
        // Tüm uygulama dahilinde geçerli olması için değişgenlerimi burada yaratıyorum
        //string vs_ConnStr = @"Data Source=BILCE;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=False;Encrypt=False;"; // Connection String : veritabanına bağlanma için
        string vs_ConnStr = "Server = 94.73.144.17 ; Database = u7173324_NWind; user id=u7173324_NWind;password=Na79=YX2az@Co7-_; Trusted_Connection = False;Encrypt=false;"; // Connection String : veritabanına bağlanma için
        string vs_SQLCommand; // SQL Command : SQL tarafın çalışacak SQL Komutları

        string vs_Query; // Sorgulamalarda kullanacağım SQL Kriter cümleciğini tutacak...
        string vs_SQLText; // Genel SQL Sorgulama textini tutacak

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            GetCategory();
            GetSupplier();
            PrepareGrid();

            vs_SQLText = "select ProductID, ProductName, Categories.CategoryName,Suppliers.CompanyName,UnitPrice,UnitsInStock,Discontinued from Products inner join Suppliers on Products.SupplierID = Suppliers.SupplierID inner join Categories on Products.CategoryID = Categories.CategoryID WHERE ProductID > 0";

            BindGrid(vs_SQLText); // dg yi doldursun
        }

        private void PrepareGrid()
        {
            // Ekrandaki datagrid i ayarlar...

            // Set AutoGenerateColumns --> false
            //dgrdProducts.AutoGenerateColumns = false;

            // Set AllowUser..false...ekrandan grid üzerinden kayıt ekleme yapmasın...benim butonuma mahkum olsun. 
            dgrdProducts.AllowUserToAddRows = false;
            dgrdProducts.AllowUserToDeleteRows = false;

            // Set AutoSizeColumnsMode --> Fill -- colonların genişlikleriyle ilgili
            dgrdProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrdProducts.RowHeadersVisible = false;

            dgrdProducts.AllowUserToResizeRows = false;

            dgrdProducts.ReadOnly = true;

            dgrdProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dgrdProducts.ColumnCount = 4;

            //// Add columns

            //dgrdProducts.Columns[0].Name = "CustomerID";
            //dgrdProducts.Columns[0].HeaderText = "Customer ID";
            //dgrdProducts.Columns[0].DataPropertyName = "CustomerID";

            //dgrdProducts.Columns[1].Name = "CompanyName";
            //dgrdProducts.Columns[1].HeaderText = "Company Name";
            //dgrdProducts.Columns[1].DataPropertyName = "CompanyName";

            //dgrdProducts.Columns[2].Name = "ContactName";
            //dgrdProducts.Columns[2].HeaderText = "Contact Name";
            //dgrdProducts.Columns[2].DataPropertyName = "ContactName";

            //dgrdProducts.Columns[3].Name = "Country";
            //dgrdProducts.Columns[3].HeaderText = "Country";
            //dgrdProducts.Columns[3].DataPropertyName = "Country";
        }

        private void BindGrid(string prmSQLText)
        {
            // VT nındaki bilgileri alıp DG içine gömmek için

            //using (SqlConnection connection = new SqlConnection(@"Data Source=BILCE\\ARIBILGI;Initial Catalog=Northwind;TrustServerCertificate=True;Persist Security Info=True;Encrypt=False;"))

            //vs_SQLCommand = "SELECT * FROM Products";
            vs_SQLCommand = prmSQLText;

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

                            dgrdProducts.DataSource = dset.Tables[0];

                        }
                    }
                }

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vs_Query = "";

            vs_SQLText = "select ProductID, ProductName, Categories.CategoryName,Suppliers.CompanyName,UnitPrice,UnitsInStock,Discontinued from Products inner join Suppliers on Products.SupplierID = Suppliers.SupplierID inner join Categories on Products.CategoryID = Categories.CategoryID WHERE ProductID > 0 ";

            // sorgulama text i oluşturuluyor

            if (tboxProductName.Text != "") // eğer textbox a bişi yazılmışsa sorgulama textine göm...
            {
                vs_Query += " AND ProductName LIKE '%" + tboxProductName.Text + "%'";
            }

            if (cboxQCategory.SelectedIndex > 0)
            {
                vs_Query += " AND Products.CategoryID = " + cboxQCategory.SelectedValue;
            }

            if (cboxQSupplier.SelectedIndex > 0)
            {
                vs_Query += " AND Products.SupplierID = " + cboxQSupplier.SelectedValue;
            }

            BindGrid(vs_SQLText + vs_Query); // oluşan veri setini gösteriyorum.
        }

        private void GetCategory()
        {
            // DB tarafındaki Kategori tablosunun ilgili alanlarını okur

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT CategoryID,CategoryName FROM Categories";

                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            // checkbox doldurma
                            // ama kullanıcının doğru değeri seçebilmesi için düzenleme.
                            // çünkü sorgu textini oluştururken comboların 0.indexi kontrol edilir.

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["CategoryID"] = 0;
                            newRow["CategoryName"] = "--- Lütfen Seçiniz ---";
                            dset.Tables[0].Rows.InsertAt(newRow, 0);

                            cboxQCategory.DataSource = dset.Tables[0];
                            cboxQCategory.ValueMember = "CategoryID";
                            cboxQCategory.DisplayMember = "CategoryName";



                        }
                    }
                }

            }

        }

        private void GetSupplier()
        {
            // DB tarafındaki Tedarikçi tablosunun ilgili alanlarını okur

            using (SqlConnection connection = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT SupplierID,CompanyName FROM Suppliers ORDER BY CompanyName";

                using (SqlCommand command = new SqlCommand(vs_SQLCommand, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            adapter.Fill(dset);

                            // combobox doldurma

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["SupplierID"] = 0;
                            newRow["CompanyName"] = "--- Lütfen Seçiniz ---";
                            dset.Tables[0].Rows.InsertAt(newRow, 0);

                            cboxQSupplier.DataSource = dset.Tables[0];
                            cboxQSupplier.ValueMember = "SupplierID"; // db tarafındaki tableın kolon adları
                            cboxQSupplier.DisplayMember = "CompanyName";

                        }
                    }
                }

            }


        }

        private void dgrdProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabcProducts.SelectedIndex = 2;
        }
    }
}
