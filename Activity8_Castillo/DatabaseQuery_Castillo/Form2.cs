using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseQuery_Castillo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartmanCollegeDataSet1.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet1.tblStudents);

        }

        private void Btn_HighGPA_Click(object sender, EventArgs e)
        {
            listBox_HighGPA.Items.Clear();
            const double CUTOFF = 3.00;
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet1.tblStudents);
            var goodStudents =
                from s in this.cartmanCollegeDataSet1.tblStudents
                where s.GradePointAverage > CUTOFF
                orderby s.GradePointAverage descending
                select s;
            foreach (var s in goodStudents)
                listBox_HighGPA.Items.Add(s.LastName + " " + s.FirstName);
        }

        private void Btn_ShowRecord_Click(object sender, EventArgs e)
        {
            listBox_ShowRecord.Items.Clear();
            double minGPA = Convert.ToDouble(textBox_MinGPA.Text);
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet1.tblStudents);
            var goodStudents =
                from s in this.cartmanCollegeDataSet1.tblStudents
                where s.GradePointAverage > minGPA
                orderby s.GradePointAverage descending
                select s;
            foreach (var s in goodStudents)
                listBox_ShowRecord.Items.Add(s.LastName + " " + s.FirstName);
        }

        private void Btn_ShowStat_Click(object sender, EventArgs e)
        {
            var gpas =
                from s in this.cartmanCollegeDataSet1.tblStudents
                select s.GradePointAverage;
            labelCount.Text = "Count is \t" + gpas.Count();
            labelMin.Text = "Lowest is \t" + gpas.Min();
            labelMax.Text = "Highest is \t" + gpas.Max();
            labelAverage.Text = "Average of all GPA is \t" + gpas.Average();
        }

        private void Btn_GroupBy_Click(object sender, EventArgs e)
        {
            listBox_GroupRecord.Items.Clear();
            var studgpa =
                from s in this.cartmanCollegeDataSet1.tblStudents
                orderby s.GradePointAverage descending
                group s by (int)s.GradePointAverage;
            foreach (var GroupGPA in studgpa)
            {
                listBox_GroupRecord.Items.Add("GPA: " + GroupGPA.Key);
                foreach (var s in GroupGPA)
                    listBox_GroupRecord.Items.Add(" " + s.GradePointAverage + " " + s.LastName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}