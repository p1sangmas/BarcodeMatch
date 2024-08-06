namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            productNumberToolStripMenuItem = new ToolStripMenuItem();
            loadNumberToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            listBoxLogs = new ListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 113);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Scanned Barcode:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productNumberToolStripMenuItem, loadNumberToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // productNumberToolStripMenuItem
            // 
            productNumberToolStripMenuItem.Name = "productNumberToolStripMenuItem";
            productNumberToolStripMenuItem.Size = new Size(277, 34);
            productNumberToolStripMenuItem.Text = "Register Product No.";
            productNumberToolStripMenuItem.Click += productNumberToolStripMenuItem_Click;
            // 
            // loadNumberToolStripMenuItem
            // 
            loadNumberToolStripMenuItem.Name = "loadNumberToolStripMenuItem";
            loadNumberToolStripMenuItem.Size = new Size(277, 34);
            loadNumberToolStripMenuItem.Text = "Load Product No.";
            loadNumberToolStripMenuItem.Click += loadNumberToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(738, 108);
            button1.Name = "button1";
            button1.Size = new Size(126, 33);
            button1.TabIndex = 6;
            button1.Text = "SCAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(827, 909);
            button2.Name = "button2";
            button2.Size = new Size(170, 34);
            button2.TabIndex = 7;
            button2.Text = "OPEN LOG FILE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBoxLogs
            // 
            listBoxLogs.FormattingEnabled = true;
            listBoxLogs.HorizontalScrollbar = true;
            listBoxLogs.ItemHeight = 25;
            listBoxLogs.Location = new Point(238, 495);
            listBoxLogs.Name = "listBoxLogs";
            listBoxLogs.Size = new Size(759, 354);
            listBoxLogs.TabIndex = 8;
            listBoxLogs.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 495);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 9;
            label3.Text = "Activity Log:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(238, 193);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(447, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 193);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 11;
            label4.Text = "Master List Barcode:";
            // 
            // button3
            // 
            button3.Location = new Point(885, 107);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 12;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(238, 285);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(759, 135);
            textBox3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 285);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 14;
            label2.Text = "Status:";
            // 
            // button4
            // 
            button4.Location = new Point(738, 188);
            button4.Name = "button4";
            button4.Size = new Size(188, 34);
            button4.TabIndex = 15;
            button4.Text = "CLEAR MASTER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(672, 909);
            button5.Name = "button5";
            button5.Size = new Size(138, 34);
            button5.TabIndex = 16;
            button5.Text = "EXPORT LOG";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 978);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listBoxLogs);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Barcode Checker v1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private Button button1;
        private Button button2;
        private ListBox listBoxLogs;
        private Label label3;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem productNumberToolStripMenuItem;
        private ToolStripMenuItem loadNumberToolStripMenuItem;
        private TextBox textBox2;
        private Label label4;
        private Button button3;
        private TextBox textBox3;
        private Label label2;
        private Button button4;
        private Button button5;
    }
}
