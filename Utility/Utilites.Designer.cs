namespace Utility
{
    partial class Utilites
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.holding = new System.Windows.Forms.Button();
            this.alignment = new System.Windows.Forms.Button();
            this.utilitypanel = new System.Windows.Forms.Panel();
            this.Cryptography = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Cryptography);
            this.panel1.Controls.Add(this.holding);
            this.panel1.Controls.Add(this.alignment);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 731);
            this.panel1.TabIndex = 0;
            // 
            // holding
            // 
            this.holding.Location = new System.Drawing.Point(10, 78);
            this.holding.Name = "holding";
            this.holding.Size = new System.Drawing.Size(145, 46);
            this.holding.TabIndex = 2;
            this.holding.Text = "Holding";
            this.holding.UseVisualStyleBackColor = true;
            this.holding.Click += new System.EventHandler(this.holding_Click);
            // 
            // alignment
            // 
            this.alignment.Location = new System.Drawing.Point(10, 10);
            this.alignment.Name = "alignment";
            this.alignment.Size = new System.Drawing.Size(145, 46);
            this.alignment.TabIndex = 1;
            this.alignment.Text = "Alignment";
            this.alignment.UseVisualStyleBackColor = true;
            this.alignment.Click += new System.EventHandler(this.alignment_Click);
            // 
            // utilitypanel
            // 
            this.utilitypanel.BackColor = System.Drawing.Color.LightGray;
            this.utilitypanel.Location = new System.Drawing.Point(180, 2);
            this.utilitypanel.Name = "utilitypanel";
            this.utilitypanel.Size = new System.Drawing.Size(1248, 731);
            this.utilitypanel.TabIndex = 1;
            // 
            // Cryptography
            // 
            this.Cryptography.Location = new System.Drawing.Point(10, 148);
            this.Cryptography.Name = "Cryptography";
            this.Cryptography.Size = new System.Drawing.Size(145, 46);
            this.Cryptography.TabIndex = 3;
            this.Cryptography.Text = "Cryptography";
            this.Cryptography.UseVisualStyleBackColor = true;
            this.Cryptography.Click += new System.EventHandler(this.Cryptography_Click);
            // 
            // Utilites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 737);
            this.Controls.Add(this.utilitypanel);
            this.Controls.Add(this.panel1);
            this.Name = "Utilites";
            this.Text = "Utilites";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button alignment;
        private System.Windows.Forms.Panel utilitypanel;
        private System.Windows.Forms.Button holding;
        private System.Windows.Forms.Button Cryptography;
    }
}