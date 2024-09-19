using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
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

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "INI Files (*.ini)|*.ini";
                    saveFileDialog.Title = "Save Configuration";
                    saveFileDialog.FileName = textBox1.Text.ToUpper();

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        File.WriteAllLines(filePath, lines);
                        MessageBox.Show("Saved successfully");
                    }
                }
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

