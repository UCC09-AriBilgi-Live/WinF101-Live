namespace _02_Controls
{
    partial class frmTimer
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
            components = new System.ComponentModel.Container();
            btonClose = new Button();
            tmerSayac = new System.Windows.Forms.Timer(components);
            lbelSaat = new Label();
            btonStart = new Button();
            btonStop = new Button();
            nudSayac = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSayac).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(437, 199);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapa&t";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // tmerSayac
            // 
            tmerSayac.Interval = 1000;
            tmerSayac.Tick += tmerSayac_Tick;
            // 
            // lbelSaat
            // 
            lbelSaat.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbelSaat.Location = new Point(135, 24);
            lbelSaat.Name = "lbelSaat";
            lbelSaat.Size = new Size(214, 65);
            lbelSaat.TabIndex = 1;
            lbelSaat.Text = "label1";
            // 
            // btonStart
            // 
            btonStart.Location = new Point(12, 141);
            btonStart.Name = "btonStart";
            btonStart.Size = new Size(75, 23);
            btonStart.TabIndex = 2;
            btonStart.Text = "Başlat";
            btonStart.UseVisualStyleBackColor = true;
            btonStart.Click += btonStart_Click;
            // 
            // btonStop
            // 
            btonStop.Location = new Point(12, 170);
            btonStop.Name = "btonStop";
            btonStop.Size = new Size(75, 23);
            btonStop.TabIndex = 3;
            btonStop.Text = "Durdur";
            btonStop.UseVisualStyleBackColor = true;
            btonStop.Click += btonStop_Click;
            // 
            // nudSayac
            // 
            nudSayac.Location = new Point(229, 143);
            nudSayac.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudSayac.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSayac.Name = "nudSayac";
            nudSayac.Size = new Size(54, 23);
            nudSayac.TabIndex = 4;
            nudSayac.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 145);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "sayac değeri";
            // 
            // frmTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 234);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(nudSayac);
            Controls.Add(btonStop);
            Controls.Add(btonStart);
            Controls.Add(lbelSaat);
            Controls.Add(btonClose);
            Name = "frmTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer Sample";
            Load += frmTimer_Load;
            ((System.ComponentModel.ISupportInitialize)nudSayac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private System.Windows.Forms.Timer tmerSayac;
        private Label lbelSaat;
        private Button btonStart;
        private Button btonStop;
        private NumericUpDown nudSayac;
        private Label label1;
    }
}