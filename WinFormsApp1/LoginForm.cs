using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Dictionary<string, (string Password, UserRole Role)> users;

        public UserRole UserRole { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            InitializeUsers();
            this.KeyPreview = true;
            this.KeyDown += Login_KeyDown;
        }

        private void InitializeUsers()
        {
            // Initialize user credentials and roles
            users = new Dictionary<string, (string Password, UserRole Role)>
            {
                { "engineer", ("123", UserRole.Engineer) },
                { "operator", ("456", UserRole.Operator) }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (users.ContainsKey(username) && users[username].Password == password)
            {
                UserRole = users[username].Role;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(274, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(274, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 39);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(200, 352);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 2;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(100, 183);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 3;
            label1.Text = "Engineer ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(100, 261);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(200, 420);
            button2.Name = "button2";
            button2.Size = new Size(112, 48);
            button2.TabIndex = 5;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(150, 84);
            label3.Name = "label3";
            label3.Size = new Size(237, 45);
            label3.TabIndex = 6;
            label3.Text = "Engineer Mode";
            // 
            // LoginForm
            // 
            ClientSize = new Size(541, 621);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LoginForm";
            Text = "Engineer Mode";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
