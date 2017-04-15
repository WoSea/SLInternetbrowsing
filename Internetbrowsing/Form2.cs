using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internetbrowsing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2( string txt)
        {
            InitializeComponent();
             textBox1.Text = txt; 
        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(textBox1.Text);
            listView1.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try 
            { 
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]); 
            }
           
            catch  {
                  MessageBox.Show("You need to select an item"); 
            }

         }

        private void listview_doubleClick(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            Form1 frm1 = new Form1(firstSelectedItem.Text);
            frm1.Show();
        }
    }
}
