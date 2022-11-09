namespace Utility
{
    partial class Holding
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
            this.calculatendcopy = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(21, 16);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(1030, 184);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(21, 266);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(1030, 184);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // calculatendcopy
            // 
            this.calculatendcopy.Location = new System.Drawing.Point(21, 500);
            this.calculatendcopy.Name = "calculatendcopy";
            this.calculatendcopy.Size = new System.Drawing.Size(284, 50);
            this.calculatendcopy.TabIndex = 4;
            this.calculatendcopy.Text = "Calculate && Copy";
            this.calculatendcopy.UseVisualStyleBackColor = true;
            this.calculatendcopy.Click += new System.EventHandler(this.calculatendcopy_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(346, 500);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(284, 50);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Holding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculatendcopy);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Holding";
            this.Size = new System.Drawing.Size(1076, 644);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button calculatendcopy;
        private System.Windows.Forms.Button clear;
    }
}
