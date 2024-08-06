namespace WinFormsApp2
{
    partial class Form2
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(646, 525);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(764, 525);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 80);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 2;
            label1.Text = "SMK Drawing No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 142);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 3;
            label2.Text = "Product Type No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 204);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = "Starting Serial No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 264);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 5;
            label4.Text = "Fixed End Char:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 326);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 329);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 7;
            label6.Text = "Product No. Start Pos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 394);
            label7.Name = "label7";
            label7.Size = new Size(157, 25);
            label7.TabIndex = 8;
            label7.Text = "Serial No Start No:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 400);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 9;
            label8.Text = "Serial No. Length:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(244, 326);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(244, 391);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(589, 400);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 615);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Register Product No.";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
