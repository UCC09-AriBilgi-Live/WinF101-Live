namespace _01_HelloWorld
{
    partial class frmHelloWorld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tboxAd = new TextBox();
            tboxSoyad = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Mesaj Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tboxAd
            // 
            tboxAd.Location = new Point(71, 12);
            tboxAd.Name = "tboxAd";
            tboxAd.Size = new Size(186, 23);
            tboxAd.TabIndex = 2;
            // 
            // tboxSoyad
            // 
            tboxSoyad.Location = new Point(71, 41);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(186, 23);
            tboxSoyad.TabIndex = 3;
            // 
            // frmHelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 133);
            Controls.Add(tboxSoyad);
            Controls.Add(tboxAd);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmHelloWorld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DenemeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tboxAd;
        private TextBox tboxSoyad;
    }
}