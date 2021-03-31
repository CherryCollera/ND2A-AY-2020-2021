
namespace WindowsFormsApp1_Malit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.fn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(63, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Message";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fn
            // 
            this.fn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fn.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fn.Location = new System.Drawing.Point(211, 158);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(147, 25);
            this.fn.TabIndex = 1;
            this.fn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ln.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ln.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ln.Location = new System.Drawing.Point(211, 209);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(147, 25);
            this.ln.TabIndex = 2;
            this.ln.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.BackColor = System.Drawing.Color.Transparent;
            this.fname.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.ForeColor = System.Drawing.Color.OldLace;
            this.fname.Location = new System.Drawing.Point(63, 151);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(131, 25);
            this.fname.TabIndex = 3;
            this.fname.Text = "First Name";
            this.fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(74, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(276, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 72);
            this.button3.TabIndex = 6;
            this.button3.Text = ".";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(423, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}