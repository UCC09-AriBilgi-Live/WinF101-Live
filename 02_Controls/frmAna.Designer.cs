namespace _02_Controls
{
    partial class frmAna
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
            btonExit = new Button();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            kontrollerToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            checkedListBoxToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            othersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.BackColor = Color.FromArgb(255, 128, 0);
            btonExit.Location = new Point(706, 395);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(97, 43);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = false;
            btonExit.Click += btonExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, kontrollerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(99, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // kontrollerToolStripMenuItem
            // 
            kontrollerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxToolStripMenuItem, checkedListBoxToolStripMenuItem, comboBoxToolStripMenuItem, othersToolStripMenuItem });
            kontrollerToolStripMenuItem.Name = "kontrollerToolStripMenuItem";
            kontrollerToolStripMenuItem.Size = new Size(71, 20);
            kontrollerToolStripMenuItem.Text = "Kontroller";
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(180, 22);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // checkedListBoxToolStripMenuItem
            // 
            checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            checkedListBoxToolStripMenuItem.Size = new Size(180, 22);
            checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            checkedListBoxToolStripMenuItem.Click += checkedListBoxToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(180, 22);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += comboBoxToolStripMenuItem_Click;
            // 
            // othersToolStripMenuItem
            // 
            othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            othersToolStripMenuItem.Size = new Size(180, 22);
            othersToolStripMenuItem.Text = "Others";
            othersToolStripMenuItem.Click += othersToolStripMenuItem_Click;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAna";
            Text = "Ana Form - Controls";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kontrollerToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem othersToolStripMenuItem;
    }
}