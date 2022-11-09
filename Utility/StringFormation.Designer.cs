namespace Utility
{
    partial class StringFormation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.Format = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(21, 16);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(1030, 184);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(23, 266);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(1030, 184);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.Text = "";
            // 
            // Format
            // 
            this.Format.Location = new System.Drawing.Point(21, 500);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(284, 50);
            this.Format.TabIndex = 6;
            this.Format.Text = "Format";
            this.Format.UseVisualStyleBackColor = true;
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(346, 500);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(284, 50);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // StringFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "StringFormation";
            this.Size = new System.Drawing.Size(1076, 644);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button Format;
        private System.Windows.Forms.Button clear;
    }
}
