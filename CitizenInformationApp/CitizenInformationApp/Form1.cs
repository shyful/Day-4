using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenInformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string,string> citizeninfo=new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            citizeninfo.Add(user_idtextBox.Text,detailsinfotextBox.Text);
        }

        private void searchbyidButton_Click(object sender, EventArgs e)
        {
            bool hasThisId = citizeninfo.ContainsKey(searchuseridtextBox.Text);
            if (hasThisId)
            {
                string citizenDetails = citizeninfo[searchuseridtextBox.Text];
                MessageBox.Show(citizenDetails);
                
            }
            else
            {
                MessageBox.Show(@"No data is found");
            }
            
        }

        private void showallinfoButton_Click(object sender, EventArgs e)
        {
            string allInfo = "";
            foreach (KeyValuePair<string,string> pair in citizeninfo)
            {
                allInfo += pair.Key + " " + pair.Value + "\n";
                
            }
            MessageBox.Show(allInfo);
        }
    }
}
