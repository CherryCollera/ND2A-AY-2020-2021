
namespace DatabaseQuery_Castillo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePointAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartmanCollegeDataSet = new DatabaseQuery_Castillo.CartmanCollegeDataSet();
            this.tblStudentsTableAdapter = new DatabaseQuery_Castillo.CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter();
            this.Btn_HighGPA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_HighGPA = new System.Windows.Forms.ListBox();
            this.Btn_ShowRecord = new System.Windows.Forms.Button();
            this.Btn_ShowStat = new System.Windows.Forms.Button();
            this.Btn_GroupBy = new System.Windows.Forms.Button();
            this.listBox_ShowRecord = new System.Windows.Forms.ListBox();
            this.listBox_GroupRecord = new System.Windows.Forms.ListBox();
            this.textBox_MinGPA = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.gradePointAverageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(510, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // gradePointAverageDataGridViewTextBoxColumn
            // 
            this.gradePointAverageDataGridViewTextBoxColumn.DataPropertyName = "GradePointAverage";
            this.gradePointAverageDataGridViewTextBoxColumn.HeaderText = "GradePointAverage";
            this.gradePointAverageDataGridViewTextBoxColumn.Name = "gradePointAverageDataGridViewTextBoxColumn";
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.cartmanCollegeDataSet;
            // 
            // cartmanCollegeDataSet
            // 
            this.cartmanCollegeDataSet.DataSetName = "CartmanCollegeDataSet";
            this.cartmanCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_HighGPA
            // 
            this.Btn_HighGPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_HighGPA.Location = new System.Drawing.Point(12, 197);
            this.Btn_HighGPA.Name = "Btn_HighGPA";
            this.Btn_HighGPA.Size = new System.Drawing.Size(169, 30);
            this.Btn_HighGPA.TabIndex = 1;
            this.Btn_HighGPA.Text = "Show students with High GPA";
            this.Btn_HighGPA.UseVisualStyleBackColor = true;
            this.Btn_HighGPA.Click += new System.EventHandler(this.Btn_HighGPA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(209, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter minimum GPA:";
            // 
            // listBox_HighGPA
            // 
            this.listBox_HighGPA.FormattingEnabled = true;
            this.listBox_HighGPA.Location = new System.Drawing.Point(12, 233);
            this.listBox_HighGPA.Name = "listBox_HighGPA";
            this.listBox_HighGPA.Size = new System.Drawing.Size(169, 95);
            this.listBox_HighGPA.TabIndex = 3;
            // 
            // Btn_ShowRecord
            // 
            this.Btn_ShowRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ShowRecord.Location = new System.Drawing.Point(436, 196);
            this.Btn_ShowRecord.Name = "Btn_ShowRecord";
            this.Btn_ShowRecord.Size = new System.Drawing.Size(85, 29);
            this.Btn_ShowRecord.TabIndex = 4;
            this.Btn_ShowRecord.Text = "Show Records";
            this.Btn_ShowRecord.UseVisualStyleBackColor = true;
            this.Btn_ShowRecord.Click += new System.EventHandler(this.Btn_ShowRecord_Click);
            // 
            // Btn_ShowStat
            // 
            this.Btn_ShowStat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ShowStat.Location = new System.Drawing.Point(525, 12);
            this.Btn_ShowStat.Name = "Btn_ShowStat";
            this.Btn_ShowStat.Size = new System.Drawing.Size(169, 38);
            this.Btn_ShowStat.TabIndex = 5;
            this.Btn_ShowStat.Text = "View Grade Statistics";
            this.Btn_ShowStat.UseVisualStyleBackColor = true;
            this.Btn_ShowStat.Click += new System.EventHandler(this.Btn_ShowStat_Click);
            // 
            // Btn_GroupBy
            // 
            this.Btn_GroupBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_GroupBy.Location = new System.Drawing.Point(700, 12);
            this.Btn_GroupBy.Name = "Btn_GroupBy";
            this.Btn_GroupBy.Size = new System.Drawing.Size(169, 38);
            this.Btn_GroupBy.TabIndex = 6;
            this.Btn_GroupBy.Text = "Group Record by GPA";
            this.Btn_GroupBy.UseVisualStyleBackColor = true;
            this.Btn_GroupBy.Click += new System.EventHandler(this.Btn_GroupBy_Click);
            // 
            // listBox_ShowRecord
            // 
            this.listBox_ShowRecord.FormattingEnabled = true;
            this.listBox_ShowRecord.Location = new System.Drawing.Point(330, 231);
            this.listBox_ShowRecord.Name = "listBox_ShowRecord";
            this.listBox_ShowRecord.Size = new System.Drawing.Size(191, 95);
            this.listBox_ShowRecord.TabIndex = 7;
            this.listBox_ShowRecord.SelectedIndexChanged += new System.EventHandler(this.listBox_ShowRecord_SelectedIndexChanged);
            // 
            // listBox_GroupRecord
            // 
            this.listBox_GroupRecord.FormattingEnabled = true;
            this.listBox_GroupRecord.Location = new System.Drawing.Point(700, 56);
            this.listBox_GroupRecord.Name = "listBox_GroupRecord";
            this.listBox_GroupRecord.Size = new System.Drawing.Size(169, 147);
            this.listBox_GroupRecord.TabIndex = 8;
            // 
            // textBox_MinGPA
            // 
            this.textBox_MinGPA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MinGPA.Location = new System.Drawing.Point(330, 197);
            this.textBox_MinGPA.Multiline = true;
            this.textBox_MinGPA.Name = "textBox_MinGPA";
            this.textBox_MinGPA.Size = new System.Drawing.Size(100, 28);
            this.textBox_MinGPA.TabIndex = 9;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCount.Location = new System.Drawing.Point(540, 68);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 15);
            this.labelCount.TabIndex = 10;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMin.Location = new System.Drawing.Point(540, 100);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 15);
            this.labelMin.TabIndex = 11;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMax.Location = new System.Drawing.Point(540, 138);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(0, 15);
            this.labelMax.TabIndex = 12;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAverage.Location = new System.Drawing.Point(540, 176);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 15);
            this.labelAverage.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(573, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go to Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(719, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(881, 368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBox_MinGPA);
            this.Controls.Add(this.listBox_GroupRecord);
            this.Controls.Add(this.listBox_ShowRecord);
            this.Controls.Add(this.Btn_GroupBy);
            this.Controls.Add(this.Btn_ShowStat);
            this.Controls.Add(this.Btn_ShowRecord);
            this.Controls.Add(this.listBox_HighGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_HighGPA);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CartmanCollegeDataSet cartmanCollegeDataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradePointAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_HighGPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_HighGPA;
        private System.Windows.Forms.Button Btn_ShowRecord;
        private System.Windows.Forms.Button Btn_ShowStat;
        private System.Windows.Forms.Button Btn_GroupBy;
        private System.Windows.Forms.ListBox listBox_ShowRecord;
        private System.Windows.Forms.ListBox listBox_GroupRecord;
        private System.Windows.Forms.TextBox textBox_MinGPA;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

