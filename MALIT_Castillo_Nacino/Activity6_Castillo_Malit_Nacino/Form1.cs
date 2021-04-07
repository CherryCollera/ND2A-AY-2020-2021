using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity6_Castillo_Malit_Nacino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to use Calculator", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Calculator calc = new Calculator();
                calc.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }
    }
}
