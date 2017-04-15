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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string txt)
        {
            InitializeComponent();
            textBox1.Text = txt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void url_keypress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
                webBrowser1.Navigate((textBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "google.com";
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e) //go button
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
                webBrowser1.Navigate(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)//add button
        { 
            Form2 frm2 = new Form2(textBox1.Text); 
            frm2.Show(); 
        }

        private void button7_Click(object sender, EventArgs e) //view bookmark button
        {
            Form2 frm = new Form2();
            frm.Show(); 
        } 
    }
} 
