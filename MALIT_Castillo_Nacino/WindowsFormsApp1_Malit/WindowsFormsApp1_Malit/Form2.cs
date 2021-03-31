using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1_Malit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Happy Birthday "+fn.Text+""+ln.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 tree = new Form3();
            tree.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 uno = new Form1();
            uno.Show();
            this.Hide();
        }
    }
}
