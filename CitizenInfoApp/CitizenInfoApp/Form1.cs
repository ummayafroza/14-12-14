using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> citizenInfo = new Dictionary<int, string>();

        private void saveButton_Click(object sender, EventArgs e)

         {
            if (citizenInfo.ContainsKey(Convert.ToInt32(idInputTextBox.Text)))
            {
                MessageBox.Show("Same ID");
            }
            else
            {
                citizenInfo.Add(Convert.ToInt32(idInputTextBox.Text), detailsTextBox.Text);
                MessageBox.Show("Information Added");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (citizenInfo.ContainsKey(Convert.ToInt32(findIdTextBox.Text)))
            {
                string name = Convert.ToString(citizenInfo[Convert.ToInt32(findIdTextBox.Text)]);
                MessageBox.Show(name);
            }
            else
            {
                MessageBox.Show("There is no entry");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInfo = " ";
            foreach (KeyValuePair<int,string> pair in citizenInfo)

            {
                allInfo += pair.Key + " : " + pair.Value + "\n";
                
            }
            MessageBox.Show(allInfo);

        }
    }
}
