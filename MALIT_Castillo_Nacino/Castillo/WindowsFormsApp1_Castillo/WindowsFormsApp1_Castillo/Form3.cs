using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1_Malit
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! "+fname.Text+" "+lname.Text+"\nBirthday\t: \tNovember 10, 2002 \nCourse\t: \tBCSC-ND \nYear\t: \t2nd year \nSection\t: \tA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fo = new Form4();
            fo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 to = new Form2();
            to.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
