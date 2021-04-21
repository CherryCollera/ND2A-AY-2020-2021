
namespace DataBinding_Nacino
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
            this.bSCS_STUDENTSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCS_STUDENTSToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.studentsDataSet = new DataBinding_Nacino.studentsDataSet();
            this.tblStudent_InfoTableAdapter = new DataBinding_Nacino.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSIT_STUDENTSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSIT_STUDENTSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rEFRESHToolStrip = new System.Windows.Forms.ToolStrip();
            this.rEFRESHToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bALANGA_ADDRESSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bALANGA_ADDRESSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECOND_YEAR_STUDENTSToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECOND_YEAR_STUDENTSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lASTNAME_START_WITH_A_AND_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lASTNAME_START_WITH_A_AND_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sECTION_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.sECTION_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fIRSTNAME_START_IN_CONSONANTToolStrip = new System.Windows.Forms.ToolStrip();
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bSCS_STUDENTSToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSIT_STUDENTSToolStrip.SuspendLayout();
            this.rEFRESHToolStrip.SuspendLayout();
            this.bALANGA_ADDRESSToolStrip.SuspendLayout();
            this.sECOND_YEAR_STUDENTSToolStrip.SuspendLayout();
            this.lASTNAME_START_WITH_A_AND_CToolStrip.SuspendLayout();
            this.sECTION_2BToolStrip.SuspendLayout();
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENTS RECORD MONITORING SYSTEM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 200);
            this.dataGridView1.TabIndex = 1;
            // 
            // bSCS_STUDENTSToolStrip
            // 
            this.bSCS_STUDENTSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCS_STUDENTSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCS_STUDENTSToolStripButton});
            this.bSCS_STUDENTSToolStrip.Location = new System.Drawing.Point(22, 284);
            this.bSCS_STUDENTSToolStrip.Name = "bSCS_STUDENTSToolStrip";
            this.bSCS_STUDENTSToolStrip.Size = new System.Drawing.Size(110, 25);
            this.bSCS_STUDENTSToolStrip.TabIndex = 2;
            this.bSCS_STUDENTSToolStrip.Text = "bSCS_STUDENTSToolStrip";
            // 
            // bSCS_STUDENTSToolStripButton
            // 
            this.bSCS_STUDENTSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCS_STUDENTSToolStripButton.Name = "bSCS_STUDENTSToolStripButton";
            this.bSCS_STUDENTSToolStripButton.Size = new System.Drawing.Size(98, 22);
            this.bSCS_STUDENTSToolStripButton.Text = "BSCS_STUDENTS";
            this.bSCS_STUDENTSToolStripButton.Click += new System.EventHandler(this.bSCS_STUDENTSToolStripButton_Click);
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
            // bSIT_STUDENTSToolStrip
            // 
            this.bSIT_STUDENTSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSIT_STUDENTSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSIT_STUDENTSToolStripButton});
            this.bSIT_STUDENTSToolStrip.Location = new System.Drawing.Point(22, 323);
            this.bSIT_STUDENTSToolStrip.Name = "bSIT_STUDENTSToolStrip";
            this.bSIT_STUDENTSToolStrip.Size = new System.Drawing.Size(105, 25);
            this.bSIT_STUDENTSToolStrip.TabIndex = 3;
            this.bSIT_STUDENTSToolStrip.Text = "bSIT_STUDENTSToolStrip";
            // 
            // bSIT_STUDENTSToolStripButton
            // 
            this.bSIT_STUDENTSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSIT_STUDENTSToolStripButton.Name = "bSIT_STUDENTSToolStripButton";
            this.bSIT_STUDENTSToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.bSIT_STUDENTSToolStripButton.Text = "BSIT_STUDENTS";
            this.bSIT_STUDENTSToolStripButton.Click += new System.EventHandler(this.bSIT_STUDENTSToolStripButton_Click);
            // 
            // rEFRESHToolStrip
            // 
            this.rEFRESHToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.rEFRESHToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEFRESHToolStripButton});
            this.rEFRESHToolStrip.Location = new System.Drawing.Point(631, 284);
            this.rEFRESHToolStrip.Name = "rEFRESHToolStrip";
            this.rEFRESHToolStrip.Size = new System.Drawing.Size(70, 25);
            this.rEFRESHToolStrip.TabIndex = 4;
            this.rEFRESHToolStrip.Text = "rEFRESHToolStrip";
            // 
            // rEFRESHToolStripButton
            // 
            this.rEFRESHToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rEFRESHToolStripButton.Name = "rEFRESHToolStripButton";
            this.rEFRESHToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.rEFRESHToolStripButton.Text = "REFRESH";
            this.rEFRESHToolStripButton.Click += new System.EventHandler(this.rEFRESHToolStripButton_Click);
            // 
            // bALANGA_ADDRESSToolStrip
            // 
            this.bALANGA_ADDRESSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bALANGA_ADDRESSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bALANGA_ADDRESSToolStripButton});
            this.bALANGA_ADDRESSToolStrip.Location = new System.Drawing.Point(189, 284);
            this.bALANGA_ADDRESSToolStrip.Name = "bALANGA_ADDRESSToolStrip";
            this.bALANGA_ADDRESSToolStrip.Size = new System.Drawing.Size(131, 25);
            this.bALANGA_ADDRESSToolStrip.TabIndex = 5;
            this.bALANGA_ADDRESSToolStrip.Text = "bALANGA_ADDRESSToolStrip";
            // 
            // bALANGA_ADDRESSToolStripButton
            // 
            this.bALANGA_ADDRESSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bALANGA_ADDRESSToolStripButton.Name = "bALANGA_ADDRESSToolStripButton";
            this.bALANGA_ADDRESSToolStripButton.Size = new System.Drawing.Size(119, 22);
            this.bALANGA_ADDRESSToolStripButton.Text = "BALANGA_ADDRESS";
            this.bALANGA_ADDRESSToolStripButton.Click += new System.EventHandler(this.bALANGA_ADDRESSToolStripButton_Click);
            // 
            // sECOND_YEAR_STUDENTSToolStrip
            // 
            this.sECOND_YEAR_STUDENTSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECOND_YEAR_STUDENTSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECOND_YEAR_STUDENTSToolStripButton});
            this.sECOND_YEAR_STUDENTSToolStrip.Location = new System.Drawing.Point(189, 323);
            this.sECOND_YEAR_STUDENTSToolStrip.Name = "sECOND_YEAR_STUDENTSToolStrip";
            this.sECOND_YEAR_STUDENTSToolStrip.Size = new System.Drawing.Size(162, 25);
            this.sECOND_YEAR_STUDENTSToolStrip.TabIndex = 6;
            this.sECOND_YEAR_STUDENTSToolStrip.Text = "sECOND_YEAR_STUDENTSToolStrip";
            // 
            // sECOND_YEAR_STUDENTSToolStripButton
            // 
            this.sECOND_YEAR_STUDENTSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sECOND_YEAR_STUDENTSToolStripButton.Name = "sECOND_YEAR_STUDENTSToolStripButton";
            this.sECOND_YEAR_STUDENTSToolStripButton.Size = new System.Drawing.Size(150, 22);
            this.sECOND_YEAR_STUDENTSToolStripButton.Text = "SECOND_YEAR_STUDENTS";
            this.sECOND_YEAR_STUDENTSToolStripButton.Click += new System.EventHandler(this.sECOND_YEAR_STUDENTSToolStripButton_Click);
            // 
            // lASTNAME_START_WITH_A_AND_CToolStrip
            // 
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lASTNAME_START_WITH_A_AND_CToolStripButton});
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Location = new System.Drawing.Point(398, 323);
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Name = "lASTNAME_START_WITH_A_AND_CToolStrip";
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Size = new System.Drawing.Size(209, 25);
            this.lASTNAME_START_WITH_A_AND_CToolStrip.TabIndex = 7;
            this.lASTNAME_START_WITH_A_AND_CToolStrip.Text = "lASTNAME_START_WITH_A_AND_CToolStrip";
            // 
            // lASTNAME_START_WITH_A_AND_CToolStripButton
            // 
            this.lASTNAME_START_WITH_A_AND_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lASTNAME_START_WITH_A_AND_CToolStripButton.Name = "lASTNAME_START_WITH_A_AND_CToolStripButton";
            this.lASTNAME_START_WITH_A_AND_CToolStripButton.Size = new System.Drawing.Size(197, 22);
            this.lASTNAME_START_WITH_A_AND_CToolStripButton.Text = "LASTNAME_START_WITH_A_AND_C";
            this.lASTNAME_START_WITH_A_AND_CToolStripButton.Click += new System.EventHandler(this.lASTNAME_START_WITH_A_AND_CToolStripButton_Click);
            // 
            // sECTION_2BToolStrip
            // 
            this.sECTION_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.sECTION_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sECTION_2BToolStripButton});
            this.sECTION_2BToolStrip.Location = new System.Drawing.Point(398, 284);
            this.sECTION_2BToolStrip.Name = "sECTION_2BToolStrip";
            this.sECTION_2BToolStrip.Size = new System.Drawing.Size(88, 25);
            this.sECTION_2BToolStrip.TabIndex = 8;
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
            // fIRSTNAME_START_IN_CONSONANTToolStrip
            // 
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton});
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Location = new System.Drawing.Point(628, 323);
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Name = "fIRSTNAME_START_IN_CONSONANTToolStrip";
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Size = new System.Drawing.Size(216, 25);
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.TabIndex = 9;
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.Text = "fIRSTNAME_START_IN_CONSONANTToolStrip";
            // 
            // fIRSTNAME_START_IN_CONSONANTToolStripButton
            // 
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton.Name = "fIRSTNAME_START_IN_CONSONANTToolStripButton";
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton.Size = new System.Drawing.Size(23, 23);
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton.Text = "FIRSTNAME_START_IN_CONSONANT";
            this.fIRSTNAME_START_IN_CONSONANTToolStripButton.Click += new System.EventHandler(this.fIRSTNAME_START_IN_CONSONANTToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(884, 377);
            this.Controls.Add(this.fIRSTNAME_START_IN_CONSONANTToolStrip);
            this.Controls.Add(this.sECTION_2BToolStrip);
            this.Controls.Add(this.lASTNAME_START_WITH_A_AND_CToolStrip);
            this.Controls.Add(this.sECOND_YEAR_STUDENTSToolStrip);
            this.Controls.Add(this.bALANGA_ADDRESSToolStrip);
            this.Controls.Add(this.rEFRESHToolStrip);
            this.Controls.Add(this.bSIT_STUDENTSToolStrip);
            this.Controls.Add(this.bSCS_STUDENTSToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DATA BINDING";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bSCS_STUDENTSToolStrip.ResumeLayout(false);
            this.bSCS_STUDENTSToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSIT_STUDENTSToolStrip.ResumeLayout(false);
            this.bSIT_STUDENTSToolStrip.PerformLayout();
            this.rEFRESHToolStrip.ResumeLayout(false);
            this.rEFRESHToolStrip.PerformLayout();
            this.bALANGA_ADDRESSToolStrip.ResumeLayout(false);
            this.bALANGA_ADDRESSToolStrip.PerformLayout();
            this.sECOND_YEAR_STUDENTSToolStrip.ResumeLayout(false);
            this.sECOND_YEAR_STUDENTSToolStrip.PerformLayout();
            this.lASTNAME_START_WITH_A_AND_CToolStrip.ResumeLayout(false);
            this.lASTNAME_START_WITH_A_AND_CToolStrip.PerformLayout();
            this.sECTION_2BToolStrip.ResumeLayout(false);
            this.sECTION_2BToolStrip.PerformLayout();
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.ResumeLayout(false);
            this.fIRSTNAME_START_IN_CONSONANTToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStrip bSCS_STUDENTSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCS_STUDENTSToolStripButton;
        private System.Windows.Forms.ToolStrip bSIT_STUDENTSToolStrip;
        private System.Windows.Forms.ToolStripButton bSIT_STUDENTSToolStripButton;
        private System.Windows.Forms.ToolStrip rEFRESHToolStrip;
        private System.Windows.Forms.ToolStripButton rEFRESHToolStripButton;
        private System.Windows.Forms.ToolStrip bALANGA_ADDRESSToolStrip;
        private System.Windows.Forms.ToolStripButton bALANGA_ADDRESSToolStripButton;
        private System.Windows.Forms.ToolStrip sECOND_YEAR_STUDENTSToolStrip;
        private System.Windows.Forms.ToolStripButton sECOND_YEAR_STUDENTSToolStripButton;
        private System.Windows.Forms.ToolStrip lASTNAME_START_WITH_A_AND_CToolStrip;
        private System.Windows.Forms.ToolStripButton lASTNAME_START_WITH_A_AND_CToolStripButton;
        private System.Windows.Forms.ToolStrip sECTION_2BToolStrip;
        private System.Windows.Forms.ToolStripButton sECTION_2BToolStripButton;
        private System.Windows.Forms.ToolStrip fIRSTNAME_START_IN_CONSONANTToolStrip;
        private System.Windows.Forms.ToolStripButton fIRSTNAME_START_IN_CONSONANTToolStripButton;
    }
}

