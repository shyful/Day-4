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

namespace WritingInFileApp
{
    public partial class CustomerInfoUI : Form
    {
        public CustomerInfoUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = @"D:\info.txt";
            string customerInfo = customerInfoTextBox.Text;
            FileStream aFileStream = new FileStream(path, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(customerInfo);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
            /*
            if (!File.Exists(path))
            {
                File.WriteAllText(path, customerInfo);
            }
            else if (File.Exists(path))
            {
                File.AppendAllText(path, customerInfo);
            }
            */

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {

        }
    }
}
