
namespace DataBinding_Castillo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rEFRESHToolStrip = new System.Windows.Forms.ToolStrip();
            this.rEFRESHToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new DataBinding_Castillo.studentsDataSet();
            this.tblStudent_InfoTableAdapter = new DataBinding_Castillo.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSCS_StudentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCS_StudentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSIT_StudentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSIT_StudentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.address_BALANGAToolStrip = new System.Windows.Forms.ToolStrip();
            this.address_BALANGAToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECONDYEAR_StudentsToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECONDYEAR_StudentsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lASTNAME_Start_with_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lASTNAME_Start_with_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECTION_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECTION_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fIRSTNAME_ConsonantToolStrip = new System.Windows.Forms.ToolStrip();
            this.fIRSTNAME_ConsonantToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rEFRESHToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSCS_StudentsToolStrip.SuspendLayout();
            this.bSIT_StudentsToolStrip.SuspendLayout();
            this.address_BALANGAToolStrip.SuspendLayout();
            this.sECONDYEAR_StudentsToolStrip.SuspendLayout();
            this.lASTNAME_Start_with_A_and_CToolStrip.SuspendLayout();
            this.sECTION_2BToolStrip.SuspendLayout();
            this.fIRSTNAME_ConsonantToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT RECORD MONITORING SYSTEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(28, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // rEFRESHToolStrip
            // 
            this.rEFRESHToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.rEFRESHToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEFRESHToolStripButton});
            this.rEFRESHToolStrip.Location = new System.Drawing.Point(714, 66);
            this.rEFRESHToolStrip.Name = "rEFRESHToolStrip";
            this.rEFRESHToolStrip.Size = new System.Drawing.Size(71, 25);
            this.rEFRESHToolStrip.TabIndex = 3;
            this.rEFRESHToolStrip.Text = "rEFRESHToolStrip";
            // 
            // rEFRESHToolStripButton
            // 
            this.rEFRESHToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rEFRESHToolStripButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEFRESHToolStripButton.Name = "rEFRESHToolStripButton";
            this.rEFRESHToolStripButton.Size = new System.Drawing.Size(59, 22);
            this.rEFRESHToolStripButton.Text = "REFRESH";
            this.rEFRESHToolStripButton.Click += new System.EventHandler(this.rEFRESHToolStripButton_Click);
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "StudID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "StudID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
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
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tblStudent_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // bSCS_StudentsToolStrip
            // 
            this.bSCS_StudentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCS_StudentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCS_StudentsToolStripButton});
            this.bSCS_StudentsToolStrip.Location = new System.Drawing.Point(714, 101);
            this.bSCS_StudentsToolStrip.Name = "bSCS_StudentsToolStrip";
            this.bSCS_StudentsToolStrip.Size = new System.Drawing.Size(101, 25);
            this.bSCS_StudentsToolStrip.TabIndex = 4;
            this.bSCS_StudentsToolStrip.Text = "bSCS_StudentsToolStrip";
            // 
            // bSCS_StudentsToolStripButton
            // 
            this.bSCS_StudentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCS_StudentsToolStripButton.Name = "bSCS_StudentsToolStripButton";
            this.bSCS_StudentsToolStripButton.Size = new System.Drawing.Size(89, 22);
            this.bSCS_StudentsToolStripButton.Text = "BSCS_Students";
            this.bSCS_StudentsToolStripButton.Click += new System.EventHandler(this.bSCS_StudentsToolStripButton_Click);
            // 
            // bSIT_StudentsToolStrip
            // 
            this.bSIT_StudentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSIT_StudentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSIT_StudentsToolStripButton});
            this.bSIT_StudentsToolStrip.Location = new System.Drawing.Point(714, 136);
            this.bSIT_StudentsToolStrip.Name = "bSIT_StudentsToolStrip";
            this.bSIT_StudentsToolStrip.Size = new System.Drawing.Size(96, 25);
            this.bSIT_StudentsToolStrip.TabIndex = 5;
            this.bSIT_StudentsToolStrip.Text = "bSIT_StudentsToolStrip";
            // 
            // bSIT_StudentsToolStripButton
            // 
            this.bSIT_StudentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSIT_StudentsToolStripButton.Name = "bSIT_StudentsToolStripButton";
            this.bSIT_StudentsToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.bSIT_StudentsToolStripButton.Text = "BSIT_Students";
            this.bSIT_StudentsToolStripButton.Click += new System.EventHandler(this.bSIT_StudentsToolStripButton_Click);
            // 
            // address_BALANGAToolStrip
            // 
            this.address_BALANGAToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.address_BALANGAToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.address_BALANGAToolStripButton});
            this.address_BALANGAToolStrip.Location = new System.Drawing.Point(714, 170);
            this.address_BALANGAToolStrip.Name = "address_BALANGAToolStrip";
            this.address_BALANGAToolStrip.Size = new System.Drawing.Size(124, 25);
            this.address_BALANGAToolStrip.TabIndex = 6;
            this.address_BALANGAToolStrip.Text = "address_BALANGAToolStrip";
            // 
            // address_BALANGAToolStripButton
            // 
            this.address_BALANGAToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.address_BALANGAToolStripButton.Name = "address_BALANGAToolStripButton";
            this.address_BALANGAToolStripButton.Size = new System.Drawing.Size(112, 22);
            this.address_BALANGAToolStripButton.Text = "Address_BALANGA";
            this.address_BALANGAToolStripButton.Click += new System.EventHandler(this.address_BALANGAToolStripButton_Click);
            // 
            // sECONDYEAR_StudentsToolStrip
            // 
            this.sECONDYEAR_StudentsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECONDYEAR_StudentsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECONDYEAR_StudentsToolStripButton});
            this.sECONDYEAR_StudentsToolStrip.Location = new System.Drawing.Point(714, 205);
            this.sECONDYEAR_StudentsToolStrip.Name = "sECONDYEAR_StudentsToolStrip";
            this.sECONDYEAR_StudentsToolStrip.Size = new System.Drawing.Size(148, 25);
            this.sECONDYEAR_StudentsToolStrip.TabIndex = 7;
            this.sECONDYEAR_StudentsToolStrip.Text = "sECONDYEAR_StudentsToolStrip";
            // 
            // sECONDYEAR_StudentsToolStripButton
            // 
            this.sECONDYEAR_StudentsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sECONDYEAR_StudentsToolStripButton.Name = "sECONDYEAR_StudentsToolStripButton";
            this.sECONDYEAR_StudentsToolStripButton.Size = new System.Drawing.Size(136, 22);
            this.sECONDYEAR_StudentsToolStripButton.Text = "SECONDYEAR_Students";
            this.sECONDYEAR_StudentsToolStripButton.Click += new System.EventHandler(this.sECONDYEAR_StudentsToolStripButton_Click);
            // 
            // lASTNAME_Start_with_A_and_CToolStrip
            // 
            this.lASTNAME_Start_with_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lASTNAME_Start_with_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lASTNAME_Start_with_A_and_CToolStripButton});
            this.lASTNAME_Start_with_A_and_CToolStrip.Location = new System.Drawing.Point(714, 239);
            this.lASTNAME_Start_with_A_and_CToolStrip.Name = "lASTNAME_Start_with_A_and_CToolStrip";
            this.lASTNAME_Start_with_A_and_CToolStrip.Size = new System.Drawing.Size(191, 25);
            this.lASTNAME_Start_with_A_and_CToolStrip.TabIndex = 8;
            this.lASTNAME_Start_with_A_and_CToolStrip.Text = "lASTNAME_Start_with_A_and_CToolStrip";
            // 
            // lASTNAME_Start_with_A_and_CToolStripButton
            // 
            this.lASTNAME_Start_with_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lASTNAME_Start_with_A_and_CToolStripButton.Name = "lASTNAME_Start_with_A_and_CToolStripButton";
            this.lASTNAME_Start_with_A_and_CToolStripButton.Size = new System.Drawing.Size(179, 22);
            this.lASTNAME_Start_with_A_and_CToolStripButton.Text = "LASTNAME_Start_with_A_and_C";
            this.lASTNAME_Start_with_A_and_CToolStripButton.Click += new System.EventHandler(this.lASTNAME_Start_with_A_and_CToolStripButton_Click);
            // 
            // sECTION_2BToolStrip
            // 
            this.sECTION_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECTION_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECTION_2BToolStripButton});
            this.sECTION_2BToolStrip.Location = new System.Drawing.Point(714, 273);
            this.sECTION_2BToolStrip.Name = "sECTION_2BToolStrip";
            this.sECTION_2BToolStrip.Size = new System.Drawing.Size(88, 25);
            this.sECTION_2BToolStrip.TabIndex = 9;
            this.sECTION_2BToolStrip.Text = "sECTION_2BToolStrip";
            // 
            // sECTION_2BToolStripButton
            // 
            this.sECTION_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sECTION_2BToolStripButton.Name = "sECTION_2BToolStripButton";
            this.sECTION_2BToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.sECTION_2BToolStripButton.Text = "SECTION_2B";
            this.sECTION_2BToolStripButton.Click += new System.EventHandler(this.sECTION_2BToolStripButton_Click);
            // 
            // fIRSTNAME_ConsonantToolStrip
            // 
            this.fIRSTNAME_ConsonantToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fIRSTNAME_ConsonantToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIRSTNAME_ConsonantToolStripButton});
            this.fIRSTNAME_ConsonantToolStrip.Location = new System.Drawing.Point(714, 306);
            this.fIRSTNAME_ConsonantToolStrip.Name = "fIRSTNAME_ConsonantToolStrip";
            this.fIRSTNAME_ConsonantToolStrip.Size = new System.Drawing.Size(148, 25);
            this.fIRSTNAME_ConsonantToolStrip.TabIndex = 10;
            this.fIRSTNAME_ConsonantToolStrip.Text = "fIRSTNAME_ConsonantToolStrip";
            // 
            // fIRSTNAME_ConsonantToolStripButton
            // 
            this.fIRSTNAME_ConsonantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fIRSTNAME_ConsonantToolStripButton.Name = "fIRSTNAME_ConsonantToolStripButton";
            this.fIRSTNAME_ConsonantToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.fIRSTNAME_ConsonantToolStripButton.Text = "FIRSTNAME_Consonant";
            this.fIRSTNAME_ConsonantToolStripButton.Click += new System.EventHandler(this.fIRSTNAME_ConsonantToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(925, 340);
            this.Controls.Add(this.fIRSTNAME_ConsonantToolStrip);
            this.Controls.Add(this.sECTION_2BToolStrip);
            this.Controls.Add(this.lASTNAME_Start_with_A_and_CToolStrip);
            this.Controls.Add(this.sECONDYEAR_StudentsToolStrip);
            this.Controls.Add(this.address_BALANGAToolStrip);
            this.Controls.Add(this.bSIT_StudentsToolStrip);
            this.Controls.Add(this.bSCS_StudentsToolStrip);
            this.Controls.Add(this.rEFRESHToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DATA BINDING";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rEFRESHToolStrip.ResumeLayout(false);
            this.rEFRESHToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSCS_StudentsToolStrip.ResumeLayout(false);
            this.bSCS_StudentsToolStrip.PerformLayout();
            this.bSIT_StudentsToolStrip.ResumeLayout(false);
            this.bSIT_StudentsToolStrip.PerformLayout();
            this.address_BALANGAToolStrip.ResumeLayout(false);
            this.address_BALANGAToolStrip.PerformLayout();
            this.sECONDYEAR_StudentsToolStrip.ResumeLayout(false);
            this.sECONDYEAR_StudentsToolStrip.PerformLayout();
            this.lASTNAME_Start_with_A_and_CToolStrip.ResumeLayout(false);
            this.lASTNAME_Start_with_A_and_CToolStrip.PerformLayout();
            this.sECTION_2BToolStrip.ResumeLayout(false);
            this.sECTION_2BToolStrip.PerformLayout();
            this.fIRSTNAME_ConsonantToolStrip.ResumeLayout(false);
            this.fIRSTNAME_ConsonantToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentsDataSetTableAdapters.tblStudent_InfoTableAdapter tblStudent_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip rEFRESHToolStrip;
        private System.Windows.Forms.ToolStripButton rEFRESHToolStripButton;
        private System.Windows.Forms.ToolStrip bSCS_StudentsToolStrip;
        private System.Windows.Forms.ToolStripButton bSCS_StudentsToolStripButton;
        private System.Windows.Forms.ToolStrip bSIT_StudentsToolStrip;
        private System.Windows.Forms.ToolStripButton bSIT_StudentsToolStripButton;
        private System.Windows.Forms.ToolStrip address_BALANGAToolStrip;
        private System.Windows.Forms.ToolStripButton address_BALANGAToolStripButton;
        private System.Windows.Forms.ToolStrip sECONDYEAR_StudentsToolStrip;
        private System.Windows.Forms.ToolStripButton sECONDYEAR_StudentsToolStripButton;
        private System.Windows.Forms.ToolStrip lASTNAME_Start_with_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lASTNAME_Start_with_A_and_CToolStripButton;
        private System.Windows.Forms.ToolStrip sECTION_2BToolStrip;
        private System.Windows.Forms.ToolStripButton sECTION_2BToolStripButton;
        private System.Windows.Forms.ToolStrip fIRSTNAME_ConsonantToolStrip;
        private System.Windows.Forms.ToolStripButton fIRSTNAME_ConsonantToolStripButton;
    }
}

