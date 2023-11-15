namespace _02_Controls
{
    partial class frmDateTime
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
            dtpTarih = new DateTimePicker();
            btonShow = new Button();
            tboxAdSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(301, 184);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(110, 45);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapa&t";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(111, 54);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 23);
            dtpTarih.TabIndex = 1;
            // 
            // btonShow
            // 
            btonShow.Location = new Point(29, 164);
            btonShow.Name = "btonShow";
            btonShow.Size = new Size(75, 23);
            btonShow.TabIndex = 2;
            btonShow.Text = "Göster";
            btonShow.UseVisualStyleBackColor = true;
            btonShow.Click += btonShow_Click;
            // 
            // tboxAdSoyad
            // 
            tboxAdSoyad.Location = new Point(111, 12);
            tboxAdSoyad.Name = "tboxAdSoyad";
            tboxAdSoyad.Size = new Size(170, 23);
            tboxAdSoyad.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "Doğum Tarihiniz";
            // 
            // frmDateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 241);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tboxAdSoyad);
            Controls.Add(btonShow);
            Controls.Add(dtpTarih);
            Controls.Add(btonClose);
            Name = "frmDateTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Date Time Ornek";
            Load += frmDateTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private DateTimePicker dtpTarih;
        private Button btonShow;
        private TextBox tboxAdSoyad;
        private Label label1;
        private Label label2;
    }
}