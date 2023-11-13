namespace _01_HelloWorld
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            lbelMessage = new Label();
            btonExit = new Button();
            btonOK = new Button();
            vScrollBar1 = new VScrollBar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            splitter1 = new Splitter();
            radioButton1 = new RadioButton();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbelMessage
            // 
            lbelMessage.AutoSize = true;
            lbelMessage.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbelMessage.Location = new Point(25, 34);
            lbelMessage.Name = "lbelMessage";
            lbelMessage.Size = new Size(65, 25);
            lbelMessage.TabIndex = 0;
            lbelMessage.Text = "label1";
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.DialogResult = DialogResult.Cancel;
            btonExit.Location = new Point(677, 358);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(75, 23);
            btonExit.TabIndex = 1;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // btonOK
            // 
            btonOK.DialogResult = DialogResult.OK;
            btonOK.Location = new Point(12, 99);
            btonOK.Name = "btonOK";
            btonOK.Size = new Size(75, 23);
            btonOK.TabIndex = 2;
            btonOK.Text = "OK";
            btonOK.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(728, 3);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(14, 137);
            vScrollBar1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(175, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 393);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(224, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(73, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 393);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(radioButton1);
            Controls.Add(splitter1);
            Controls.Add(tabControl1);
            Controls.Add(vScrollBar1);
            Controls.Add(btonOK);
            Controls.Add(btonExit);
            Controls.Add(lbelMessage);
            Name = "frmMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesaj";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btonExit;
        public Label lbelMessage;
        private Button btonOK;
        private VScrollBar vScrollBar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Splitter splitter1;
        private RadioButton radioButton1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}