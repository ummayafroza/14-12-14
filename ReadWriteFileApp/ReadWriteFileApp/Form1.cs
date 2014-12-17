using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWriteFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        string path = "D:\\info.txt";
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (customerInfoTextBox.Text != string.Empty)
            {
                StreamWriter textFile = new StreamWriter(path,true);
                textFile.WriteLine(customerInfoTextBox.Text);
                textFile.Close();
            }
            else
            {
                MessageBox.Show("Enter name & phone no.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            viewBoxListBox.Items.Clear();
            if (File.Exists(path))
            {
                StreamReader textReader = new StreamReader(path);
                while (!textReader.EndOfStream)
                    viewBoxListBox.Items.Add(textReader.ReadLine());
            }
            else
            {
                MessageBox.Show("There is no data in file " + path);
            }
        }
    }
}
