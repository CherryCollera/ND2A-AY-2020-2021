using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activity6_Castillo_Malit_Nacino
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            int number = 13;
            MessageBox.Show(number.ToString());
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float number = 13.56F;
            MessageBox.Show(number.ToString());
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double number = 13.5678;
            MessageBox.Show(number.ToString());
        }

        private void btnComputeSum_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            sum = num1 + num2;
            MessageBox.Show("The sum is " + Convert.ToString(sum));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
