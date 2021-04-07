using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activity6_Castillo_Malit_Nacino
{
    public partial class Calculator : Form
    {
        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
    
        public Calculator()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total1 = total1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            minusButtonClicked = false;
            divideButtonClicked = false;
            plusButtonClicked = true;
            multiplyButtonClicked = false;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            total1 = total1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            minusButtonClicked = true;
            divideButtonClicked = false;
            plusButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            minusButtonClicked = false;
            divideButtonClicked = false;
            plusButtonClicked = false;
            multiplyButtonClicked = true;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            total1 = total1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            minusButtonClicked = false;
            divideButtonClicked = true;
            plusButtonClicked = false;
            multiplyButtonClicked = false;
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if(minusButtonClicked==true){
              
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
