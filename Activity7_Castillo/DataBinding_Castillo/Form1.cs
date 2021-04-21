using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding_Castillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.tblStudent_Info' table. You can move, or remove it, as needed.
            this.tblStudent_InfoTableAdapter.Fill(this.studentsDataSet.tblStudent_Info);

        }

        private void rEFRESHToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.REFRESH(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bSCS_StudentsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.BSCS_Students(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bSIT_StudentsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.BSIT_Students(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void address_BALANGAToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.Address_BALANGA(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sECONDYEAR_StudentsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.SECONDYEAR_Students(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lASTNAME_Start_with_A_and_CToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.LASTNAME_Start_with_A_and_C(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sECTION_2BToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.SECTION_2B(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fIRSTNAME_ConsonantToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblStudent_InfoTableAdapter.FIRSTNAME_Consonant(this.studentsDataSet.tblStudent_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
