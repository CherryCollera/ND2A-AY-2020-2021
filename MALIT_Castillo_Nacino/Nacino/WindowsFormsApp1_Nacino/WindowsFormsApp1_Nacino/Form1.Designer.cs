
namespace WindowsFormsApp1_Malit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gtmsg = new System.Windows.Forms.Button();
            this.bthide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gtmsg
            // 
            this.gtmsg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gtmsg.BackColor = System.Drawing.Color.Teal;
            this.gtmsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gtmsg.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gtmsg.ForeColor = System.Drawing.Color.White;
            this.gtmsg.Location = new System.Drawing.Point(128, 83);
            this.gtmsg.Name = "gtmsg";
            this.gtmsg.Size = new System.Drawing.Size(223, 116);
            this.gtmsg.TabIndex = 0;
            this.gtmsg.Text = "Get Message";
            this.gtmsg.UseVisualStyleBackColor = false;
            this.gtmsg.Click += new System.EventHandler(this.button1_Click);
            // 
            // bthide
            // 
            this.bthide.BackColor = System.Drawing.Color.Teal;
            this.bthide.ForeColor = System.Drawing.Color.White;
            this.bthide.Location = new System.Drawing.Point(345, 227);
            this.bthide.Name = "bthide";
            this.bthide.Size = new System.Drawing.Size(121, 58);
            this.bthide.TabIndex = 1;
            this.bthide.Text = "Hide";
            this.bthide.UseVisualStyleBackColor = false;
            this.bthide.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1_Nacino.Properties.Resources.istockphoto_1148899759_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.bthide);
            this.Controls.Add(this.gtmsg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gtmsg;
        private System.Windows.Forms.Button bthide;
    }
}

