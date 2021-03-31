using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1_Malit
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void SUM_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(n1.Text);
            int num2 = int.Parse(n2.Text);
            ans.Text = (num1 + num2).ToString();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(n1.Text);
            int num2 = int.Parse(n2.Text);
            int answer = num1 - num2;
            ans.Text = (answer).ToString();
        }

        private void TOT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The answer is: " + ans.Text);
        }


        private void MUL_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(n1.Text);
            int num2 = int.Parse(n2.Text);
            ans.Text = (num1 * num2).ToString();
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(n1.Text);
            int num2 = int.Parse(n2.Text);
            ans.Text = (num1 / num2).ToString();
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ans_TextChanged(object sender, EventArgs e)
        {

        }

        private void rem_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(n1.Text);
            int num2 = int.Parse(n2.Text);
            ans.Text = (num1 % num2).ToString();
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            n1.Text = String.Empty;
            n2.Text = String.Empty;
            ans.Text = String.Empty;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 three = new Form3();
            three.Show();
            this.Hide();
        }

        private void bthide_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }
    }
}
