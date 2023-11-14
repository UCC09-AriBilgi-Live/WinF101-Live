namespace _02_Controls
{
    partial class frmCheckBox
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
            chkbMessage = new CheckBox();
            lbelMessage = new Label();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(280, 247);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // chkbMessage
            // 
            chkbMessage.AutoSize = true;
            chkbMessage.Location = new Point(48, 12);
            chkbMessage.Name = "chkbMessage";
            chkbMessage.Size = new Size(85, 19);
            chkbMessage.TabIndex = 1;
            chkbMessage.Text = "Mesaj ver...";
            chkbMessage.UseVisualStyleBackColor = true;
            chkbMessage.CheckedChanged += chkbMessage_CheckedChanged;
            // 
            // lbelMessage
            // 
            lbelMessage.AutoSize = true;
            lbelMessage.Location = new Point(48, 73);
            lbelMessage.Name = "lbelMessage";
            lbelMessage.Size = new Size(38, 15);
            lbelMessage.TabIndex = 2;
            lbelMessage.Text = "label1";
            lbelMessage.Click += label1_Click;
            // 
            // frmCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 282);
            ControlBox = false;
            Controls.Add(lbelMessage);
            Controls.Add(chkbMessage);
            Controls.Add(btonClose);
            Name = "frmCheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox Kontrolu";
            Load += frmCheckBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private CheckBox chkbMessage;
        private Label lbelMessage;
    }
}