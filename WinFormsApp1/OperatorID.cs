using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class OperatorID : Form
    {
        public string OperatorIDValue { get; private set; }

        public OperatorID()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += OperatorID_KeyDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter Operator ID");
                return;
            }
            else
            {
                OperatorIDValue = textBox1.Text;
            }

            Close();
        }

        private void OperatorID_KeyDown(object sender, KeyEventArgs e)
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
            Application.Exit();
        }

        private void OperatorID_Load(object sender, EventArgs e)
        {

        }
    }

}
