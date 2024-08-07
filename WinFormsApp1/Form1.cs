using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using ExcelDataReader;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DataTable serialNumbersTable;
        private string logFilePath = "C:\\Users\\fakhr\\OneDrive\\Documents\\Intern\\test\\scan_log.txt";
        private HashSet<string> scannedSerialNumbers = new HashSet<string>();
        private int okCounter = 0;
        private int ngCounter = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayWaitingText();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

            // Initialize textbox4 and textbox5 to 0
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void ClearFile()
        {
            textBox1.Clear();
            listBoxLogs.Items.Clear();
            scannedSerialNumbers.Clear();
            DisplayWaitingText();
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void BarcodeScanner_BarcodeScanned(object? sender, BarcodeScannerEventArgs e)
        {
            textBox1.Text = e.Barcode;
            CompareSerialNumber(e.Barcode);
        }

        private void CompareSerialNumber(string scannedSerialNumber)
        {
            string comparisonValue = textBox2.Text;
            string productNumber = textBox1.Text;

            if (string.IsNullOrEmpty(comparisonValue))
            {
                MessageBox.Show("Serial number not initialized.");
                return;
            }

            if (string.IsNullOrEmpty(productNumber))
            {
                MessageBox.Show("Please input product number");
                return;
            }

            /*if (scannedSerialNumbers.Contains(scannedSerialNumber))
            {
                MessageBox.Show("This serial number has already been scanned.");
                LogMessage($"NG: Serial number already scanned. Scanned Serial Number: {scannedSerialNumber}");
                return;
            }*/

            var serialNumberExists = scannedSerialNumber == comparisonValue;

            if (serialNumberExists)
            {
                //MessageBox.Show("Serial number match in the master list.");
                DisplayOKText();
                LogMessage($"OK: Scanned serial number match: {scannedSerialNumber}");

                // Add the serial number to the scanned list
                scannedSerialNumbers.Add(scannedSerialNumber);

                okCounter++;
                textBox4.Text = okCounter.ToString();

            }
            else
            {
                //MessageBox.Show("Serial number not found in the master list.");
                DisplayNGText();
                LogMessage($"NG: Scanned serial number not match: {scannedSerialNumber}");

                ngCounter++;
                textBox5.Text = ngCounter.ToString();

            }
        }

        private void LogMessage(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }

            // Add the log message to the ListBox
            listBoxLogs.Items.Add($"{DateTime.Now}: {message}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompareSerialNumber(textBox1.Text);
            textBox1.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(logFilePath))
            {
                Process.Start(new ProcessStartInfo(logFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Log file not found.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsApp2.Form2 form2 = new WinFormsApp2.Form2();
            form2.Show();
        }

        private void loadNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "INI Files|*.ini";
                openFileDialog.Title = "Select an INI File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string iniFilePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(iniFilePath);
                    if (lines.Length > 0)
                    {
                        textBox2.Text = lines[0];
                    }
                }
            }
        }

        private void DisplayWaitingText()
        {
            textBox3.ReadOnly = true;
            textBox3.Font = new Font(textBox3.Font.FontFamily, 44, FontStyle.Regular);
            textBox3.Text = "WAITING...";
            textBox3.ForeColor = Color.Black;
            textBox3.BackColor = Color.White;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void DisplayOKText()
        {
            textBox3.ReadOnly = true;
            textBox3.Font = new Font(textBox3.Font.FontFamily, 44, FontStyle.Regular);
            textBox3.Text = "OK";
            textBox3.ForeColor = Color.Black;
            textBox3.BackColor = Color.MediumTurquoise;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }
        private void DisplayNGText()
        {
            textBox3.ReadOnly = true;
            textBox3.Font = new Font(textBox3.Font.FontFamily, 44, FontStyle.Regular);
            textBox3.Text = "NG";
            textBox3.ForeColor = Color.Black;
            textBox3.BackColor = Color.Red;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }


    }
}
