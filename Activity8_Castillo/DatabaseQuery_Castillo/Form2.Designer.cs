
namespace DatabaseQuery_Castillo
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradePointAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartmanCollegeDataSet1 = new DatabaseQuery_Castillo.CartmanCollegeDataSet1();
            this.Btn_HighGPA = new System.Windows.Forms.Button();
            this.listBox_HighGPA = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MinGPA = new System.Windows.Forms.TextBox();
            this.Btn_ShowRecord = new System.Windows.Forms.Button();
            this.listBox_ShowRecord = new System.Windows.Forms.ListBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.listBox_GroupRecord = new System.Windows.Forms.ListBox();
            this.Btn_GroupBy = new System.Windows.Forms.Button();
            this.Btn_ShowStat = new System.Windows.Forms.Button();
            this.tblStudentsTableAdapter = new DatabaseQuery_Castillo.CartmanCollegeDataSet1TableAdapters.tblStudentsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.gradePointAverageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentsBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(519, 178);
            this.dataGridView1.TabIndex = 1;
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
            this.tblStudentsBindingSource.DataSource = this.cartmanCollegeDataSet1;
            // 
            // cartmanCollegeDataSet1
            // 
            this.cartmanCollegeDataSet1.DataSetName = "CartmanCollegeDataSet1";
            this.cartmanCollegeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_HighGPA
            // 
            this.Btn_HighGPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_HighGPA.Location = new System.Drawing.Point(12, 196);
            this.Btn_HighGPA.Name = "Btn_HighGPA";
            this.Btn_HighGPA.Size = new System.Drawing.Size(169, 30);
            this.Btn_HighGPA.TabIndex = 2;
            this.Btn_HighGPA.Text = "Show students with High GPA";
            this.Btn_HighGPA.UseVisualStyleBackColor = true;
            this.Btn_HighGPA.Click += new System.EventHandler(this.Btn_HighGPA_Click);
            // 
            // listBox_HighGPA
            // 
            this.listBox_HighGPA.FormattingEnabled = true;
            this.listBox_HighGPA.Location = new System.Drawing.Point(12, 232);
            this.listBox_HighGPA.Name = "listBox_HighGPA";
            this.listBox_HighGPA.Size = new System.Drawing.Size(169, 95);
            this.listBox_HighGPA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(208, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter minimum GPA:";
            // 
            // textBox_MinGPA
            // 
            this.textBox_MinGPA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MinGPA.Location = new System.Drawing.Point(332, 193);
            this.textBox_MinGPA.Multiline = true;
            this.textBox_MinGPA.Name = "textBox_MinGPA";
            this.textBox_MinGPA.Size = new System.Drawing.Size(100, 28);
            this.textBox_MinGPA.TabIndex = 10;
            // 
            // Btn_ShowRecord
            // 
            this.Btn_ShowRecord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ShowRecord.Location = new System.Drawing.Point(438, 193);
            this.Btn_ShowRecord.Name = "Btn_ShowRecord";
            this.Btn_ShowRecord.Size = new System.Drawing.Size(85, 29);
            this.Btn_ShowRecord.TabIndex = 11;
            this.Btn_ShowRecord.Text = "Show Records";
            this.Btn_ShowRecord.UseVisualStyleBackColor = true;
            this.Btn_ShowRecord.Click += new System.EventHandler(this.Btn_ShowRecord_Click);
            // 
            // listBox_ShowRecord
            // 
            this.listBox_ShowRecord.FormattingEnabled = true;
            this.listBox_ShowRecord.Location = new System.Drawing.Point(331, 228);
            this.listBox_ShowRecord.Name = "listBox_ShowRecord";
            this.listBox_ShowRecord.Size = new System.Drawing.Size(191, 95);
            this.listBox_ShowRecord.TabIndex = 12;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAverage.Location = new System.Drawing.Point(552, 176);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(0, 15);
            this.labelAverage.TabIndex = 20;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMax.Location = new System.Drawing.Point(552, 138);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(0, 15);
            this.labelMax.TabIndex = 19;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMin.Location = new System.Drawing.Point(552, 100);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 15);
            this.labelMin.TabIndex = 18;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCount.Location = new System.Drawing.Point(552, 68);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 15);
            this.labelCount.TabIndex = 17;
            // 
            // listBox_GroupRecord
            // 
            this.listBox_GroupRecord.FormattingEnabled = true;
            this.listBox_GroupRecord.Location = new System.Drawing.Point(712, 56);
            this.listBox_GroupRecord.Name = "listBox_GroupRecord";
            this.listBox_GroupRecord.Size = new System.Drawing.Size(169, 147);
            this.listBox_GroupRecord.TabIndex = 16;
            // 
            // Btn_GroupBy
            // 
            this.Btn_GroupBy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_GroupBy.Location = new System.Drawing.Point(712, 12);
            this.Btn_GroupBy.Name = "Btn_GroupBy";
            this.Btn_GroupBy.Size = new System.Drawing.Size(169, 38);
            this.Btn_GroupBy.TabIndex = 15;
            this.Btn_GroupBy.Text = "Group Record by GPA";
            this.Btn_GroupBy.UseVisualStyleBackColor = true;
            this.Btn_GroupBy.Click += new System.EventHandler(this.Btn_GroupBy_Click);
            // 
            // Btn_ShowStat
            // 
            this.Btn_ShowStat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ShowStat.Location = new System.Drawing.Point(537, 12);
            this.Btn_ShowStat.Name = "Btn_ShowStat";
            this.Btn_ShowStat.Size = new System.Drawing.Size(169, 38);
            this.Btn_ShowStat.TabIndex = 14;
            this.Btn_ShowStat.Text = "View Grade Statistics";
            this.Btn_ShowStat.UseVisualStyleBackColor = true;
            this.Btn_ShowStat.Click += new System.EventHandler(this.Btn_ShowStat_Click);
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(731, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 22;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(585, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Go to Form1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(938, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.listBox_GroupRecord);
            this.Controls.Add(this.Btn_GroupBy);
            this.Controls.Add(this.Btn_ShowStat);
            this.Controls.Add(this.listBox_ShowRecord);
            this.Controls.Add(this.Btn_ShowRecord);
            this.Controls.Add(this.textBox_MinGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_HighGPA);
            this.Controls.Add(this.Btn_HighGPA);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_HighGPA;
        private System.Windows.Forms.ListBox listBox_HighGPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MinGPA;
        private System.Windows.Forms.Button Btn_ShowRecord;
        private System.Windows.Forms.ListBox listBox_ShowRecord;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ListBox listBox_GroupRecord;
        private System.Windows.Forms.Button Btn_GroupBy;
        private System.Windows.Forms.Button Btn_ShowStat;
        private CartmanCollegeDataSet1 cartmanCollegeDataSet1;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private CartmanCollegeDataSet1TableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradePointAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}