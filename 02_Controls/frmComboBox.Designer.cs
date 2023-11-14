namespace _02_Controls
{
    partial class frmComboBox
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
            cbocSehir = new ComboBox();
            btonSay = new Button();
            lbelMessage = new Label();
            cboxHangi = new ComboBox();
            cboxSonuc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(233, 191);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // cbocSehir
            // 
            cbocSehir.FormattingEnabled = true;
            cbocSehir.Items.AddRange(new object[] { "Ankara", "Bursa", "İstanbul", "İzmir", "Adana" });
            cbocSehir.Location = new Point(32, 26);
            cbocSehir.Name = "cbocSehir";
            cbocSehir.Size = new Size(135, 23);
            cbocSehir.TabIndex = 1;
            // 
            // btonSay
            // 
            btonSay.Location = new Point(197, 26);
            btonSay.Name = "btonSay";
            btonSay.Size = new Size(75, 23);
            btonSay.TabIndex = 2;
            btonSay.Text = "Say";
            btonSay.UseVisualStyleBackColor = true;
            btonSay.Click += btonSay_Click;
            // 
            // lbelMessage
            // 
            lbelMessage.AutoSize = true;
            lbelMessage.Location = new Point(197, 71);
            lbelMessage.Name = "lbelMessage";
            lbelMessage.Size = new Size(38, 15);
            lbelMessage.TabIndex = 3;
            lbelMessage.Text = "label1";
            // 
            // cboxHangi
            // 
            cboxHangi.FormattingEnabled = true;
            cboxHangi.Items.AddRange(new object[] { "Haftanın günleri", "Yıllar" });
            cboxHangi.Location = new Point(32, 135);
            cboxHangi.Name = "cboxHangi";
            cboxHangi.Size = new Size(121, 23);
            cboxHangi.TabIndex = 4;
            cboxHangi.SelectedIndexChanged += cboxHangi_SelectedIndexChanged;
            // 
            // cboxSonuc
            // 
            cboxSonuc.FormattingEnabled = true;
            cboxSonuc.Location = new Point(175, 135);
            cboxSonuc.Name = "cboxSonuc";
            cboxSonuc.Size = new Size(121, 23);
            cboxSonuc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 117);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Seçenekler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Sonuc";
            // 
            // frmComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(320, 226);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxSonuc);
            Controls.Add(cboxHangi);
            Controls.Add(lbelMessage);
            Controls.Add(btonSay);
            Controls.Add(cbocSehir);
            Controls.Add(btonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComboBox";
            Load += frmComboBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private ComboBox cbocSehir;
        private Button btonSay;
        private Label lbelMessage;
        private ComboBox cboxHangi;
        private ComboBox cboxSonuc;
        private Label label1;
        private Label label2;
    }
}