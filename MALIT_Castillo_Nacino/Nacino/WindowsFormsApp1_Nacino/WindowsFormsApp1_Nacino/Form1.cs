using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Malit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HappyBirthday hb = new HappyBirthday();
            MessageBox.Show(hb.GetMessage(" Shrine"));
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 two = new Form2();
            two.Show();
            this.Hide();
            
        }
       
    }
}
