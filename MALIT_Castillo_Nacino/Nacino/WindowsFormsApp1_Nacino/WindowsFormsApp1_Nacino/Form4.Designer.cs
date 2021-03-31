
namespace WindowsFormsApp1_Malit
{
    partial class Form4
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
            this.SUM = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.TOT = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.MUL = new System.Windows.Forms.Button();
            this.NUM1 = new System.Windows.Forms.Label();
            this.NUM2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.rem = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.bthide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SUM
            // 
            this.SUM.BackColor = System.Drawing.SystemColors.Desktop;
            this.SUM.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SUM.ForeColor = System.Drawing.SystemColors.Control;
            this.SUM.Location = new System.Drawing.Point(126, 225);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(82, 35);
            this.SUM.TabIndex = 0;
            this.SUM.Text = "+";
            this.SUM.UseVisualStyleBackColor = false;
            this.SUM.Click += new System.EventHandler(this.SUM_Click);
            // 
            // SUB
            // 
            this.SUB.BackColor = System.Drawing.SystemColors.Desktop;
            this.SUB.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SUB.ForeColor = System.Drawing.SystemColors.Control;
            this.SUB.Location = new System.Drawing.Point(38, 265);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(82, 35);
            this.SUB.TabIndex = 3;
            this.SUB.Text = "-";
            this.SUB.UseVisualStyleBackColor = false;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // TOT
            // 
            this.TOT.BackColor = System.Drawing.SystemColors.Desktop;
            this.TOT.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TOT.ForeColor = System.Drawing.SystemColors.Control;
            this.TOT.Location = new System.Drawing.Point(126, 266);
            this.TOT.Name = "TOT";
            this.TOT.Size = new System.Drawing.Size(81, 34);
            this.TOT.TabIndex = 11;
            this.TOT.Text = "=";
            this.TOT.UseVisualStyleBackColor = false;
            this.TOT.Click += new System.EventHandler(this.TOT_Click);
            // 
            // DIV
            // 
            this.DIV.BackColor = System.Drawing.SystemColors.Desktop;
            this.DIV.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DIV.ForeColor = System.Drawing.SystemColors.Control;
            this.DIV.Location = new System.Drawing.Point(125, 306);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(81, 34);
            this.DIV.TabIndex = 13;
            this.DIV.Text = "/";
            this.DIV.UseVisualStyleBackColor = false;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // MUL
            // 
            this.MUL.BackColor = System.Drawing.SystemColors.Desktop;
            this.MUL.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MUL.ForeColor = System.Drawing.SystemColors.Control;
            this.MUL.Location = new System.Drawing.Point(213, 266);
            this.MUL.Name = "MUL";
            this.MUL.Size = new System.Drawing.Size(82, 35);
            this.MUL.TabIndex = 14;
            this.MUL.Text = "*";
            this.MUL.UseVisualStyleBackColor = false;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // NUM1
            // 
            this.NUM1.AutoSize = true;
            this.NUM1.BackColor = System.Drawing.SystemColors.Desktop;
            this.NUM1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NUM1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUM1.ForeColor = System.Drawing.SystemColors.Control;
            this.NUM1.Location = new System.Drawing.Point(53, 73);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(93, 17);
            this.NUM1.TabIndex = 15;
            this.NUM1.Text = "1st Number";
            // 
            // NUM2
            // 
            this.NUM2.AutoSize = true;
            this.NUM2.BackColor = System.Drawing.SystemColors.Desktop;
            this.NUM2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NUM2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUM2.ForeColor = System.Drawing.SystemColors.Control;
            this.NUM2.Location = new System.Drawing.Point(48, 108);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(97, 17);
            this.NUM2.TabIndex = 16;
            this.NUM2.Text = "2nd Number";
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.Desktop;
            this.n1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.n1.Location = new System.Drawing.Point(151, 73);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(66, 23);
            this.n1.TabIndex = 18;
            this.n1.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.MenuText;
            this.n2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.n2.Location = new System.Drawing.Point(151, 105);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(66, 23);
            this.n2.TabIndex = 19;
            this.n2.TextChanged += new System.EventHandler(this.n2_TextChanged);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.Desktop;
            this.ans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans.ForeColor = System.Drawing.SystemColors.Window;
            this.ans.Location = new System.Drawing.Point(134, 171);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(74, 25);
            this.ans.TabIndex = 20;
            this.ans.TextChanged += new System.EventHandler(this.ans_TextChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.SystemColors.Desktop;
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.SystemColors.Control;
            this.total.Location = new System.Drawing.Point(141, 141);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(67, 17);
            this.total.TabIndex = 17;
            this.total.Text = "Answer";
            // 
            // rem
            // 
            this.rem.BackColor = System.Drawing.SystemColors.Desktop;
            this.rem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rem.Location = new System.Drawing.Point(40, 225);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(80, 34);
            this.rem.TabIndex = 21;
            this.rem.Text = "%";
            this.rem.UseVisualStyleBackColor = false;
            this.rem.Click += new System.EventHandler(this.rem_Click);
            // 
            // CLR
            // 
            this.CLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CLR.Location = new System.Drawing.Point(214, 223);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(82, 36);
            this.CLR.TabIndex = 22;
            this.CLR.Text = "CLR";
            this.CLR.UseVisualStyleBackColor = false;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(38, 305);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(82, 35);
            this.back.TabIndex = 23;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // bthide
            // 
            this.bthide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bthide.ForeColor = System.Drawing.SystemColors.Control;
            this.bthide.Location = new System.Drawing.Point(214, 306);
            this.bthide.Name = "bthide";
            this.bthide.Size = new System.Drawing.Size(81, 34);
            this.bthide.TabIndex = 24;
            this.bthide.Text = "Hide";
            this.bthide.UseVisualStyleBackColor = false;
            this.bthide.Click += new System.EventHandler(this.bthide_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1_Nacino.Properties.Resources.istockphoto_541307258_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.bthide);
            this.Controls.Add(this.back);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.rem);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.MUL);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.TOT);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.SUM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.Button TOT;
        private System.Windows.Forms.Button DIV;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Label NUM1;
        private System.Windows.Forms.Label NUM2;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button rem;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button bthide;
    }
}