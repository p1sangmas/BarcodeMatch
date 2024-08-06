using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            
        }

        private void SaveConfiguration()
        {
            if (AreAllTextBoxesFilled())
            {
                string[] lines = new string[]
                {
                    textBox1.Text.ToUpper(),
                    textBox2.Text.ToUpper(),
                    textBox3.Text.ToUpper(),
                    textBox4.Text.ToUpper(),
                    textBox6.Text.ToUpper(),
                    textBox7.Text.ToUpper(),
                    textBox8.Text.ToUpper()
                };

                string fileName = $"{textBox1.Text.ToUpper()}.ini";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Please fill in all the parameters before saving.");
            }
        }

        private bool AreAllTextBoxesFilled()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text) &&
                   !string.IsNullOrWhiteSpace(textBox6.Text) &&
                   !string.IsNullOrWhiteSpace(textBox7.Text) &&
                   !string.IsNullOrWhiteSpace(textBox8.Text);
        }

 
        }
    
}
