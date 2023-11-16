namespace _03_ADO
{
    partial class frmADO_Detail
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
            btnClose = new Button();
            tboxCustomerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tboxCompanyName = new TextBox();
            label3 = new Label();
            tboxContactName = new TextBox();
            label4 = new Label();
            tboxCountry = new TextBox();
            btonSave = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(401, 310);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tboxCustomerID
            // 
            tboxCustomerID.Location = new Point(142, 17);
            tboxCustomerID.Name = "tboxCustomerID";
            tboxCustomerID.Size = new Size(71, 23);
            tboxCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 61);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Company Name";
            // 
            // tboxCompanyName
            // 
            tboxCompanyName.Location = new Point(142, 58);
            tboxCompanyName.Name = "tboxCompanyName";
            tboxCompanyName.Size = new Size(165, 23);
            tboxCompanyName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Contact Name";
            // 
            // tboxContactName
            // 
            tboxContactName.Location = new Point(142, 101);
            tboxContactName.Name = "tboxContactName";
            tboxContactName.Size = new Size(184, 23);
            tboxContactName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 146);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Contry";
            // 
            // tboxCountry
            // 
            tboxCountry.Location = new Point(142, 146);
            tboxCountry.Name = "tboxCountry";
            tboxCountry.Size = new Size(100, 23);
            tboxCountry.TabIndex = 8;
            // 
            // btonSave
            // 
            btonSave.Location = new Point(142, 205);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(75, 23);
            btonSave.TabIndex = 9;
            btonSave.Text = "Kaydet";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // frmADO_Detail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 345);
            ControlBox = false;
            Controls.Add(btonSave);
            Controls.Add(tboxCountry);
            Controls.Add(label4);
            Controls.Add(tboxContactName);
            Controls.Add(label3);
            Controls.Add(tboxCompanyName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tboxCustomerID);
            Controls.Add(btnClose);
            Name = "frmADO_Detail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detay";
            Load += frmADO_Detail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btonSave;
        public TextBox tboxCustomerID;
        public TextBox tboxCompanyName;
        public TextBox tboxContactName;
        public TextBox tboxCountry;
    }
}