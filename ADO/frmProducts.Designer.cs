namespace _03_ADO
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btonClose = new Button();
            tabcProducts = new TabControl();
            tabpGeneral = new TabPage();
            dgrdProducts = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cboxQSupplier = new ComboBox();
            label2 = new Label();
            cboxQCategory = new ComboBox();
            chklCategory = new CheckedListBox();
            btnQuery = new Button();
            tboxProductName = new TextBox();
            label1 = new Label();
            tabpDetail = new TabPage();
            tabPage1 = new TabPage();
            tabcProducts.SuspendLayout();
            tabpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrdProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(767, 415);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // tabcProducts
            // 
            tabcProducts.Controls.Add(tabpGeneral);
            tabcProducts.Controls.Add(tabpDetail);
            tabcProducts.Controls.Add(tabPage1);
            tabcProducts.Location = new Point(12, 12);
            tabcProducts.Name = "tabcProducts";
            tabcProducts.SelectedIndex = 0;
            tabcProducts.Size = new Size(749, 410);
            tabcProducts.TabIndex = 1;
            // 
            // tabpGeneral
            // 
            tabpGeneral.Controls.Add(dgrdProducts);
            tabpGeneral.Controls.Add(groupBox1);
            tabpGeneral.Location = new Point(4, 24);
            tabpGeneral.Name = "tabpGeneral";
            tabpGeneral.Padding = new Padding(3);
            tabpGeneral.Size = new Size(741, 382);
            tabpGeneral.TabIndex = 0;
            tabpGeneral.Text = "General";
            tabpGeneral.UseVisualStyleBackColor = true;
            // 
            // dgrdProducts
            // 
            dgrdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdProducts.Location = new Point(10, 184);
            dgrdProducts.Name = "dgrdProducts";
            dgrdProducts.RowTemplate.Height = 25;
            dgrdProducts.Size = new Size(725, 179);
            dgrdProducts.TabIndex = 1;
            dgrdProducts.CellDoubleClick += dgrdProducts_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboxQSupplier);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboxQCategory);
            groupBox1.Controls.Add(chklCategory);
            groupBox1.Controls.Add(btnQuery);
            groupBox1.Controls.Add(tboxProductName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorgu Seçenekleri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Tedarikçi";
            // 
            // cboxQSupplier
            // 
            cboxQSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxQSupplier.FormattingEnabled = true;
            cboxQSupplier.Location = new Point(84, 86);
            cboxQSupplier.Name = "cboxQSupplier";
            cboxQSupplier.Size = new Size(185, 23);
            cboxQSupplier.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Kategori";
            // 
            // cboxQCategory
            // 
            cboxQCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxQCategory.FormattingEnabled = true;
            cboxQCategory.Location = new Point(83, 57);
            cboxQCategory.Name = "cboxQCategory";
            cboxQCategory.Size = new Size(186, 23);
            cboxQCategory.TabIndex = 4;
            // 
            // chklCategory
            // 
            chklCategory.FormattingEnabled = true;
            chklCategory.Location = new Point(508, 57);
            chklCategory.Name = "chklCategory";
            chklCategory.Size = new Size(120, 76);
            chklCategory.TabIndex = 3;
            // 
            // btnQuery
            // 
            btnQuery.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnQuery.Location = new Point(6, 136);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(75, 23);
            btnQuery.TabIndex = 2;
            btnQuery.Text = "Sorgula";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // tboxProductName
            // 
            tboxProductName.Location = new Point(84, 28);
            tboxProductName.Name = "tboxProductName";
            tboxProductName.Size = new Size(185, 23);
            tboxProductName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // tabpDetail
            // 
            tabpDetail.Location = new Point(4, 24);
            tabpDetail.Name = "tabpDetail";
            tabpDetail.Padding = new Padding(3);
            tabpDetail.Size = new Size(741, 382);
            tabpDetail.TabIndex = 1;
            tabpDetail.Text = "Detail";
            tabpDetail.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(741, 382);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            ControlBox = false;
            Controls.Add(tabcProducts);
            Controls.Add(btonClose);
            Name = "frmProducts";
            Text = "Ürünler";
            Load += frmProducts_Load;
            tabcProducts.ResumeLayout(false);
            tabpGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrdProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btonClose;
        private TabControl tabcProducts;
        private TabPage tabpGeneral;
        private TabPage tabpDetail;
        private GroupBox groupBox1;
        private DataGridView dgrdProducts;
        private Button btnQuery;
        private TextBox tboxProductName;
        private Label label1;
        private CheckedListBox chklCategory;
        private Label label3;
        private ComboBox cboxQSupplier;
        private Label label2;
        private ComboBox cboxQCategory;
        private TabPage tabPage1;
    }
}