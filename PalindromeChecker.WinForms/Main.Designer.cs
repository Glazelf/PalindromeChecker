
namespace PalindromeChecker.WinForms
{
    partial class MainForm
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
            this.CheckButton = new System.Windows.Forms.Button();
            this.PalindromeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.AccessibleName = "CheckButton";
            this.CheckButton.Location = new System.Drawing.Point(123, 41);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PalindromeTextBox
            // 
            this.PalindromeTextBox.AccessibleName = "PalindromeTextBox";
            this.PalindromeTextBox.Location = new System.Drawing.Point(12, 12);
            this.PalindromeTextBox.Name = "PalindromeTextBox";
            this.PalindromeTextBox.Size = new System.Drawing.Size(305, 23);
            this.PalindromeTextBox.TabIndex = 1;
            this.PalindromeTextBox.Text = "Put text here...";
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 75);
            this.Controls.Add(this.PalindromeTextBox);
            this.Controls.Add(this.CheckButton);
            this.Name = "MainForm";
            this.Text = "PalindromeChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox PalindromeTextBox;
    }
}

