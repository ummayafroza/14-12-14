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

namespace AddressBookApp
{
    public partial class addressBookForm : Form
    {
        public addressBookForm()
        {
            InitializeComponent();
        }
        string fileLocation = @"E:\ASP.Net\address.CSV";

        private void saveButton_Click(object sender, EventArgs e)
        {
            int validFile = 1;
            if (File.Exists(fileLocation))
            {
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> aList = new List<string>();
                while (aReader.ReadRow(aList))
                {
                    string contactNumber = aList[2];
                    if (contactNumber == contactNumberTextBox.Text)
                    {
                        validFile = 0;
                        break;
                    }
                    
                }
                aStream.Close();
            }
            if (validFile == 0)
            {
                MessageBox.Show("Same Contact Number");
            }

            else if (validFile == 1)
            {
                FileStream aStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aStream);
                List<string> aList = new List<string>();
                aList.Add(nameInputTextBox.Text);
                aList.Add(emailInputTextBox.Text);
                aList.Add(contactNumberTextBox.Text);
                aList.Add(homeContactTextBox.Text);
                aList.Add(addressTextBox.Text);
                aWriter.WriteRow(aList);
                aStream.Close();
                MessageBox.Show("Saved in file");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation,FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aList = new List<string>();
            listView.Items.Clear();
            while (aReader.ReadRow(aList))
            {
                string name = aList[0];
                string email = aList[1];
                string contactNumber = aList[2];
                string homeNum = aList[3];
                string address = aList[4];
                listView.Items.Add(name+" " +email+ " " +contactNumber+ " " +homeNum + " " +address);
            }
            aStream.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            listView.Items.Clear(); 
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aList = new List<string>();
            if (getComboBox.Text == "Name")
            {
                while (aReader.ReadRow( aList))
                {
                         bool check = false;
                         foreach (char c in inputForSearchTextBox.Text)
                        {
                            if (aList[0].ToLower().Contains(c.ToString().ToLower()))
                            {
                                check = true;
                                break;
                            }
                        }
                    if (check)
                    {
                        listView.Items.Add(aList[0]);
                    }
                }
                    aStream.Close();
            }
            else if (getComboBox.Text == "Email")
            {
                while (aReader.ReadRow( aList))
                {
                         bool check = false;
                         foreach (char c in inputForSearchTextBox.Text)
                        {
                            if (aList[1].ToLower().Contains(c.ToString().ToLower()))
                            {
                                check = true;
                                break;
                            }
                        }
                    if (check)
                    {
                        listView.Items.Add(aList[1]);
                    }
                }
                    aStream.Close();
            }
            else 
            {
                while (aReader.ReadRow(aList))
                {
                    bool check = false;
                    foreach (char c in inputForSearchTextBox.Text)
                    {
                        if (aList[2].ToLower().Contains(c.ToString().ToLower()))
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check)
                    {
                        listView.Items.Add(aList[2]);
                    }
                }
                aStream.Close();
            }
         }
          
           
      }
           


}
    

