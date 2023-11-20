namespace _03_ADO
{
    partial class frmAna
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
            menuStrip1 = new MenuStrip();
            menü1ToolStripMenuItem = new ToolStripMenuItem();
            costomersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            prToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menü1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menü1ToolStripMenuItem
            // 
            menü1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { costomersToolStripMenuItem, productsToolStripMenuItem, toolStripSeparator1, prToolStripMenuItem });
            menü1ToolStripMenuItem.Name = "menü1ToolStripMenuItem";
            menü1ToolStripMenuItem.Size = new Size(65, 20);
            menü1ToolStripMenuItem.Text = "Program";
            menü1ToolStripMenuItem.Click += menü1ToolStripMenuItem_Click;
            // 
            // costomersToolStripMenuItem
            // 
            costomersToolStripMenuItem.Name = "costomersToolStripMenuItem";
            costomersToolStripMenuItem.Size = new Size(180, 22);
            costomersToolStripMenuItem.Text = "Customers";
            costomersToolStripMenuItem.Click += costomersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(180, 22);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // prToolStripMenuItem
            // 
            prToolStripMenuItem.Name = "prToolStripMenuItem";
            prToolStripMenuItem.Size = new Size(180, 22);
            prToolStripMenuItem.Text = "Çıkış";
            prToolStripMenuItem.Click += prToolStripMenuItem_Click;
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAna";
            Text = "ADO Samples";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menü1ToolStripMenuItem;
        private ToolStripMenuItem prToolStripMenuItem;
        private ToolStripMenuItem costomersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}