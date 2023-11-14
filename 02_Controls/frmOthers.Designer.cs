namespace _02_Controls
{
    partial class frmOthers
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
            dtpTarih1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            linkLabel1 = new LinkLabel();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            dataGridView1 = new DataGridView();
            trackBar1 = new TrackBar();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(774, 581);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click_1;
            // 
            // dtpTarih1
            // 
            dtpTarih1.Location = new Point(12, 12);
            dtpTarih1.Name = "dtpTarih1";
            dtpTarih1.Size = new Size(200, 23);
            dtpTarih1.TabIndex = 1;
            toolTip1.SetToolTip(dtpTarih1, "Tarih bilgisinin girilmesi için kullanılır");
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 62);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(303, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(316, 199);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(308, 171);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(308, 171);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(308, 171);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(308, 171);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(308, 171);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(16, 251);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            toolTip1.SetToolTip(linkLabel1, "Bir internet sayfasına gider....");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Enabled = false;
            numericUpDown1.Location = new Point(16, 290);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 289);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 102);
            textBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(184, 417);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(234, 125);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(43, 462);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(523, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 9;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(80, 573);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(198, 45);
            trackBar1.TabIndex = 10;
            // 
            // frmOthers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 616);
            ControlBox = false;
            Controls.Add(trackBar1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(linkLabel1);
            Controls.Add(tabControl1);
            Controls.Add(monthCalendar1);
            Controls.Add(dtpTarih1);
            Controls.Add(btonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmOthers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOther";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private DateTimePicker dtpTarih1;
        private MonthCalendar monthCalendar1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private LinkLabel linkLabel1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private ColorDialog colorDialog1;
        private Button button1;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private TrackBar trackBar1;
    }
}