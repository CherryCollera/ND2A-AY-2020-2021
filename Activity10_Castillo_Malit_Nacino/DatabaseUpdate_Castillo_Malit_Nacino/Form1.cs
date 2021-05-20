using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace DatabaseUpdate_Castillo_Malit_Nacino
{
    public partial class Form1 : Form
    {
        private OleDbConnection bookConn;
        private OleDbCommand oleDbCmd = new OleDbCommand();

        private String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Administrator\Documents\Activity10_Castillo_Malit_Nacino\book3.mdb";
       // private String connParam = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Activity10_Castillo_Malit_Nacino\book3.accdb";
        public Form1()
        {
            bookConn = new OleDbConnection(connParam);
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book3DataSet1.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter1.Fill(this.book3DataSet1.bookrecords);
            // TODO: This line of code loads data into the 'book3DataSet.bookrecords' table. You can move, or remove it, as needed.
            this.bookrecordsTableAdapter.Fill(this.book3DataSet.bookrecords);

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            bookConn.Open();
            oleDbCmd.Connection = bookConn;
            oleDbCmd.CommandText = "Insert into bookrecords (booktitle, description)" + " " + " values('" + this.text_BookTitle.Text + "', '" + this.text_Desc.Text + "');";

            int temp = oleDbCmd.ExecuteNonQuery();
            if (temp > 0)
            {
                text_BookTitle.Text = null;
                text_Desc.Text = null;
                MessageBox.Show("Record Successfully Added");
            }
            else
            {
                MessageBox.Show("Failed to add Record");
            }
            bookConn.Close();
        }

        private void Btn_ShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("SELECT * FROM bookrecords", connParam);
            OleDbDataAdapter dAdapter1 = new OleDbDataAdapter("SELECT * FROM bookrecords", connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this data?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookConn.Open();
                OleDbCommand cmd = bookConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from bookrecords where booktitle ='" + this.text_BookTitle.Text + "'";
                cmd.ExecuteNonQuery();
                bookConn.Close();

                MessageBox.Show("Record Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Successfully Cancelled!");
            }
            
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

