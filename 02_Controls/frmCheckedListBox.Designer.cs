namespace _02_Controls
{
    partial class frmCheckedListBox
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
            chkbDiller = new CheckedListBox();
            label1 = new Label();
            btonMessage = new Button();
            lbelMessage = new Label();
            rbtnHepsi = new RadioButton();
            rbtnHicbiri = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(367, 373);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // chkbDiller
            // 
            chkbDiller.FormattingEnabled = true;
            chkbDiller.Items.AddRange(new object[] { "CSharp", "Java", "C++", "Embarcadero Pascal", "C", "Javascript", "PHP", "Python" });
            chkbDiller.Location = new Point(26, 53);
            chkbDiller.Name = "chkbDiller";
            chkbDiller.Size = new Size(139, 148);
            chkbDiller.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 15);
            label1.TabIndex = 2;
            label1.Text = "Hangi programlama dilleri ile uğraşıyorsunuz?";
            // 
            // btonMessage
            // 
            btonMessage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btonMessage.Location = new Point(26, 218);
            btonMessage.Name = "btonMessage";
            btonMessage.Size = new Size(139, 37);
            btonMessage.TabIndex = 3;
            btonMessage.Text = "Mesaj ver...";
            btonMessage.UseVisualStyleBackColor = true;
            btonMessage.Click += btonMessage_Click;
            // 
            // lbelMessage
            // 
            lbelMessage.Location = new Point(26, 286);
            lbelMessage.Name = "lbelMessage";
            lbelMessage.Size = new Size(319, 58);
            lbelMessage.TabIndex = 4;
            lbelMessage.Text = "label2";
            // 
            // rbtnHepsi
            // 
            rbtnHepsi.AutoSize = true;
            rbtnHepsi.Location = new Point(23, 22);
            rbtnHepsi.Name = "rbtnHepsi";
            rbtnHepsi.Size = new Size(86, 19);
            rbtnHepsi.TabIndex = 5;
            rbtnHepsi.TabStop = true;
            rbtnHepsi.Text = "Hepsini Seç";
            rbtnHepsi.UseVisualStyleBackColor = true;
            rbtnHepsi.CheckedChanged += rbtnHepsi_CheckedChanged;
            // 
            // rbtnHicbiri
            // 
            rbtnHicbiri.AutoSize = true;
            rbtnHicbiri.Location = new Point(23, 53);
            rbtnHicbiri.Name = "rbtnHicbiri";
            rbtnHicbiri.Size = new Size(102, 19);
            rbtnHicbiri.TabIndex = 6;
            rbtnHicbiri.TabStop = true;
            rbtnHicbiri.Text = "Hepsini seçme";
            rbtnHicbiri.UseVisualStyleBackColor = true;
            rbtnHicbiri.CheckedChanged += rbtnHicbiri_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnHepsi);
            groupBox1.Controls.Add(rbtnHicbiri);
            groupBox1.Location = new Point(204, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 84);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seçiminiz";
            // 
            // frmCheckedListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 408);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(lbelMessage);
            Controls.Add(btonMessage);
            Controls.Add(label1);
            Controls.Add(chkbDiller);
            Controls.Add(btonClose);
            Name = "frmCheckedListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckedListBox";
            Load += frmCheckedListBox_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private CheckedListBox chkbDiller;
        private Label label1;
        private Button btonMessage;
        private Label lbelMessage;
        private RadioButton rbtnHepsi;
        private RadioButton rbtnHicbiri;
        private GroupBox groupBox1;
    }
}