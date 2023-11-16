namespace _03_ADO
{
    partial class frmADO
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
            label1 = new Label();
            dgrdCustomers = new DataGridView();
            btonAdd = new Button();
            btonUpdate = new Button();
            btonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Location = new Point(713, 415);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 33);
            label1.TabIndex = 1;
            label1.Text = "Customers Data";
            // 
            // dgrdCustomers
            // 
            dgrdCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdCustomers.Location = new Point(12, 45);
            dgrdCustomers.Name = "dgrdCustomers";
            dgrdCustomers.RowTemplate.Height = 25;
            dgrdCustomers.Size = new Size(755, 326);
            dgrdCustomers.TabIndex = 2;
            dgrdCustomers.CellContentDoubleClick += dgrdCustomers_CellContentDoubleClick;
            // 
            // btonAdd
            // 
            btonAdd.Location = new Point(12, 393);
            btonAdd.Name = "btonAdd";
            btonAdd.Size = new Size(75, 23);
            btonAdd.TabIndex = 3;
            btonAdd.Text = "Ekle";
            btonAdd.UseVisualStyleBackColor = true;
            btonAdd.Click += btonAdd_Click;
            // 
            // btonUpdate
            // 
            btonUpdate.Location = new Point(98, 393);
            btonUpdate.Name = "btonUpdate";
            btonUpdate.Size = new Size(75, 23);
            btonUpdate.TabIndex = 4;
            btonUpdate.Text = "Güncelle";
            btonUpdate.UseVisualStyleBackColor = true;
            btonUpdate.Click += btonUpdate_Click;
            // 
            // btonDelete
            // 
            btonDelete.Location = new Point(179, 393);
            btonDelete.Name = "btonDelete";
            btonDelete.Size = new Size(75, 23);
            btonDelete.TabIndex = 5;
            btonDelete.Text = "Sil";
            btonDelete.UseVisualStyleBackColor = true;
            // 
            // frmADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btonDelete);
            Controls.Add(btonUpdate);
            Controls.Add(btonAdd);
            Controls.Add(dgrdCustomers);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmADO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADO.Net Sample";
            Load += frmADO_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private DataGridView dgrdCustomers;
        private Button btonAdd;
        private Button btonUpdate;
        private Button btonDelete;
    }
}