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
            aboutToolStripMenuItem = new ToolStripMenuItem();
            engineerModeToolStripMenuItem = new ToolStripMenuItem();
            exitEngineerModeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
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
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button6 = new Button();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            textBox6 = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(37, 201);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 0;
            label1.Text = "Scanned Barcode:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(288, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 39);
            textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, aboutToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 33);
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
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { engineerModeToolStripMenuItem, exitEngineerModeToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(75, 29);
            aboutToolStripMenuItem.Text = "Mode";
            //aboutToolStripMenuItem.Click += changeUserToolStripMenuItem_Click;
            // 
            // engineerModeToolStripMenuItem
            // 
            engineerModeToolStripMenuItem.Name = "engineerModeToolStripMenuItem";
            engineerModeToolStripMenuItem.Size = new Size(238, 34);
            engineerModeToolStripMenuItem.Text = "Engineer Mode";
            engineerModeToolStripMenuItem.Click += engineerModeToolStripMenuItem_Click;
            // 
            // exitEngineerModeToolStripMenuItem
            // 
            exitEngineerModeToolStripMenuItem.Name = "exitEngineerModeToolStripMenuItem";
            exitEngineerModeToolStripMenuItem.Size = new Size(238, 34);
            exitEngineerModeToolStripMenuItem.Text = "Operator Mode";
            exitEngineerModeToolStripMenuItem.Click += exitEngineerModeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(78, 29);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(736, 159);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 6;
            button1.Text = "SCAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(837, 967);
            button2.Name = "button2";
            button2.Size = new Size(201, 46);
            button2.TabIndex = 7;
            button2.Text = "OPEN LOG FILE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBoxLogs
            // 
            listBoxLogs.Font = new Font("Segoe UI", 12F);
            listBoxLogs.FormattingEnabled = true;
            listBoxLogs.HorizontalScrollbar = true;
            listBoxLogs.ItemHeight = 32;
            listBoxLogs.Location = new Point(236, 557);
            listBoxLogs.Name = "listBoxLogs";
            listBoxLogs.Size = new Size(811, 324);
            listBoxLogs.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 557);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 9;
            label3.Text = "Activity Log:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(288, 286);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(425, 39);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(37, 283);
            label4.Name = "label4";
            label4.Size = new Size(227, 32);
            label4.TabIndex = 11;
            label4.Text = "Master List Barcode:";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(524, 967);
            button3.Name = "button3";
            button3.Size = new Size(112, 46);
            button3.TabIndex = 12;
            button3.Text = "RESET";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 369);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(425, 135);
            textBox3.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 369);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 14;
            label2.Text = "Status:";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(797, 240);
            button4.Name = "button4";
            button4.Size = new Size(188, 47);
            button4.TabIndex = 15;
            button4.Text = "CLEAR MASTER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(668, 967);
            button5.Name = "button5";
            button5.Size = new Size(138, 46);
            button5.TabIndex = 16;
            button5.Text = "EXPORT LOG";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(736, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 175);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "OK/NG Counter";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(98, 110);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(150, 39);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(98, 48);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 39);
            textBox4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 110);
            label6.Name = "label6";
            label6.Size = new Size(53, 32);
            label6.TabIndex = 1;
            label6.Text = "NG:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 51);
            label5.Name = "label5";
            label5.Size = new Size(51, 32);
            label5.TabIndex = 0;
            label5.Text = "OK:";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(887, 159);
            button6.Name = "button6";
            button6.Size = new Size(151, 44);
            button6.TabIndex = 18;
            button6.Text = "CLEAR SCAN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(37, 980);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 19;
            label7.Text = "SMK-ML";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(37, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 111);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operator ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(45, 44);
            label8.Name = "label8";
            label8.Size = new Size(42, 32);
            label8.TabIndex = 21;
            label8.Text = "ID:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(106, 41);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(150, 39);
            textBox6.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1118, 1056);
            Controls.Add(groupBox2);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Button button6;
        private Label label7;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem engineerModeToolStripMenuItem;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox textBox6;
        private ToolStripMenuItem exitEngineerModeToolStripMenuItem;
    }
}
