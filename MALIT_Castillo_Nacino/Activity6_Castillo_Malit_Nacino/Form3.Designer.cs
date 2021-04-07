
namespace Activity6_Castillo_Malit_Nacino
{
    partial class Form3
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
            this.btnInteger = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComputeSum = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInteger
            // 
            this.btnInteger.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInteger.Location = new System.Drawing.Point(28, 26);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(142, 33);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Integer";
            this.btnInteger.UseVisualStyleBackColor = false;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(138, 105);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 37);
            this.txtNum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // btnComputeSum
            // 
            this.btnComputeSum.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComputeSum.Location = new System.Drawing.Point(207, 165);
            this.btnComputeSum.Name = "btnComputeSum";
            this.btnComputeSum.Size = new System.Drawing.Size(160, 38);
            this.btnComputeSum.TabIndex = 3;
            this.btnComputeSum.Text = "Compute Sum";
            this.btnComputeSum.UseVisualStyleBackColor = false;
            this.btnComputeSum.Click += new System.EventHandler(this.btnComputeSum_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDouble.Location = new System.Drawing.Point(400, 26);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(141, 33);
            this.btnDouble.TabIndex = 4;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFloat.Location = new System.Drawing.Point(220, 26);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(147, 33);
            this.btnFloat.TabIndex = 5;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = false;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(129, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(320, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Second Number";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(333, 105);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 37);
            this.txtNum2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(138, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(565, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnComputeSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnInteger);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComputeSum;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button button1;
    }
}