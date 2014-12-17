using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace CsvApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fileLocation = @"E:\ASP.Net\Projects\file.csv";

        private void saveButton_Click(object sender, EventArgs e)
        {
            int valid = 1;
            if (File.Exists(fileLocation))
            {
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> studentRecord = new List<string>();
                while (aReader.ReadRow(studentRecord))
                {
                    string regNo = studentRecord[0];
                    if (regNo == regNoTextBox.Text)
                    {
                        valid = 0;
                        break;
                    }
                }
                aStream.Close();
            }

            if (valid == 0)
            {
                MessageBox.Show("Same Reg No");
            }
            else if (valid == 1)
            {
            
                FileStream fileStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(fileStream);
                List<string> record = new List<string>();

                record.Add(regNoTextBox.Text);
                record.Add(nameInputTextBox.Text);
                aWriter.WriteRow(record);
                fileStream.Close();
                MessageBox.Show("Saved.");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> studentRecord = new List<string>();
            showAllLListBox.Items.Clear();
            while (aReader.ReadRow(studentRecord))
            {
                string regNo = studentRecord[0];
                string name = studentRecord[1];
                showAllLListBox.Items.Add(regNo + " " + name);
            }
            aStream.Close();
          
        }
    }
}
