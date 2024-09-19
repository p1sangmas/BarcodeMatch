using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using ExcelDataReader;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;
using OfficeOpenXml;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DataTable serialNumbersTable;
        private string logFilePath = "C:\\Users\\fakhr\\OneDrive\\Documents\\Intern\\test\\scan_log.txt";
        private HashSet<string> scannedSerialNumbers = new HashSet<string>();
        private int okCounter = 0;
        private int ngCounter = 0;
        private UserRole userRole;

        public Form1()
        {
            InitializeComponent();
            DisplayWaitingText();
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

            // Initialize
            textBox4.Text = "0";
            textBox5.Text = "0";
            productNumberToolStripMenuItem.Enabled = false;
            exitEngineerModeToolStripMenuItem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenOperatorIDForm();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void OpenOperatorIDForm()
        {
            using (OperatorID operatorIDForm = new OperatorID())
            {
                operatorIDForm.ShowDialog();
                textBox6.Text = operatorIDForm.OperatorIDValue;
            }
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

            var serialNumberExists = scannedSerialNumber == comparisonValue;

            if (serialNumberExists)
            {
                //MessageBox.Show("Serial number match in the master list.");
                DisplayOKText();
                LogMessage($"OK Scanned serial number match: {scannedSerialNumber}");

                // Add the serial number to the scanned list
                scannedSerialNumbers.Add(scannedSerialNumber);

                okCounter++;
                textBox4.Text = okCounter.ToString();

            }
            else
            {
                //MessageBox.Show("Serial number not found in the master list.");
                DisplayNGText();
                LogMessage($"NG Scanned serial number unmatch: {scannedSerialNumber}");

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

        private void ExportLogsToExcel(string filePath)
        {
            // Create a new Excel package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())

            {
                // Create a new worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Logs");

                // Set the column headers
                worksheet.Cells[1, 1].Value = "Operator ID";
                worksheet.Cells[1, 2].Value = "No.";
                worksheet.Cells[1, 3].Value = "Date";
                worksheet.Cells[1, 4].Value = "Time";
                worksheet.Cells[1, 5].Value = "Status";
                worksheet.Cells[1, 6].Value = "Scanned Serial Number";
                

                // Set the column widths
                worksheet.Column(1).Width = 20;
                worksheet.Column(2).Width = 10;
                worksheet.Column(3).Width = 10;
                worksheet.Column(4).Width = 10;
                worksheet.Column(5).Width = 10;
                worksheet.Column(6).Width = 20;

                // Set the data starting row
                int row = 2;

                // Export the logs to the worksheet
                foreach (string log in listBoxLogs.Items)
                {
                    string[] logParts = log.Split(' ');
                    string date = logParts[0].Trim();
                    string time = logParts[1].Trim();
                    string status = logParts[3].Trim();
                    string serialNum = logParts[8].Trim();
                    string opID = textBox6.Text;

                    worksheet.Cells[row, 1].Value = opID;
                    worksheet.Cells[row, 2].Value = row - 1;
                    worksheet.Cells[row, 3].Value = date;
                    worksheet.Cells[row, 4].Value = time;
                    worksheet.Cells[row, 5].Value = status;
                    worksheet.Cells[row, 6].Value = serialNum;
                    

                    row++;
                }

                // Save the Excel package to the specified file path
                package.SaveAs(new FileInfo(filePath));
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
            //SystemSounds.Beep.Play();
        }
        private void DisplayNGText()
        {
            textBox3.ReadOnly = true;
            textBox3.Font = new Font(textBox3.Font.FontFamily, 44, FontStyle.Regular);
            textBox3.Text = "NG";
            textBox3.ForeColor = Color.Black;
            textBox3.BackColor = Color.Red;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //SystemSounds.Exclamation.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompareSerialNumber(textBox1.Text);
            textBox1.Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Log File";
            //saveFileDialog.FileName = "log";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportLogsToExcel(filePath);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void productNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinFormsApp1.Form2 form2 = new WinFormsApp1.Form2();
            form2.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   SMK-ML 2024. Designed by Fakhrul Fauzi");
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

        private void engineerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthenticateUser();
        }

        private void AuthenticateUser()
        {
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    userRole = loginForm.UserRole;
                    ApplyRolePermissions();
                }
            }
        }

        private void ApplyRolePermissions()
        {
            if (userRole == UserRole.Engineer)
            {
                productNumberToolStripMenuItem.Enabled = true;
                exitEngineerModeToolStripMenuItem.Enabled = true;
                textBox6.Enabled = false;
                button3.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;

            }
            else
            {
                // Disable features for Operator
                productNumberToolStripMenuItem.Enabled = false;
                
            }
        }

        private void exitEngineerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productNumberToolStripMenuItem.Enabled = false;
            exitEngineerModeToolStripMenuItem.Enabled = false;
            textBox6.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
