using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoApp
{
    public partial class BookInfoUI : Form
    {
        public BookInfoUI()
        {
            InitializeComponent();
        }
        Hashtable BooksInfo = new Hashtable();
         //string isbn;
       //string bookDetails = string.Empty;
        private void add_Click(object sender, EventArgs e)
        {
            if (BooksInfo.ContainsKey(ISBN_textBox.Text) == true)
            {
                MessageBox.Show("Information has been added berofe");
            }
            else
            {
               BooksInfo.Add(ISBN_textBox.Text, detailstextBox.Text);
                MessageBox.Show("Information has been saved"); 
            }
            //isbn = ISBN_textBox.Text;
            //bookDetails = detailstextBox.Text;
            
            }
        

        private void find_Click(object sender, EventArgs e)
        {
            if (BooksInfo.ContainsKey(ISBN1_textbox.Text))
            {
                string bookdetails = Convert.ToString(BooksInfo[ISBN1_textbox.Text]);
                bookdetails1listBox.Items.Add(bookdetails);
            }
            else
            {
                MessageBox.Show("There is no book with your ISBN");
            }
            

        }
    }
}
