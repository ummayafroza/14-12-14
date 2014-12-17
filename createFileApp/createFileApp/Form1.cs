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


namespace createFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileLocation = @"E:\ASP.Net\employee.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream FileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(FileStream);
            aStreamWriter.WriteLine(idInputTextBox.Text+ "," +nameInputTextBox.Text+ "," +salaryInputTextBox.Text +"\n");
           // aStreamWriter.WriteLine();
            aStreamWriter.Close();

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            FileStream FileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(FileStream);
            showAllListBox.Items.Clear();
            
            while (!aStreamReader.EndOfStream)
            {
                string Line = aStreamReader.ReadLine();
                showAllListBox.Items.Add(Line);
            }
            aStreamReader.Close();

            double sum = 0;
            foreach(string aLine in File.ReadAllLines(fileLocation))
            {
                showAllListBox.Items.Add(aLine);
                string[] str = aLine.Split(',');
                sum += double.Parse(str[2]);
            }
            totalAmounTextBox.Text = sum.ToString();

        }
    }
}
