namespace WinFormsApp1
{
    partial class OperatorID
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(238, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(249, 285);
            button1.Name = "button1";
            button1.Size = new Size(112, 44);
            button1.TabIndex = 1;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(171, 203);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(124, 86);
            label2.Name = "label2";
            label2.Size = new Size(376, 45);
            label2.TabIndex = 3;
            label2.Text = "Please Enter Operator ID:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(249, 348);
            button2.Name = "button2";
            button2.Size = new Size(112, 46);
            button2.TabIndex = 4;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OperatorID
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 451);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "OperatorID";
            Text = "Barcode Checker v1";
            Load += OperatorID_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}