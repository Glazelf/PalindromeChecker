using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PalindromeChecker.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string palindromeText = PalindromeTextBox.Text;
            bool isPalindrome = palindromeText.SequenceEqual(palindromeText.Reverse());

            if (isPalindrome)
            {
                CheckResultLabel.Text = $"\"{palindromeText}\" is a palindrome.";
                CheckResultLabel.ForeColor = Color.Green;
                CheckResultLabel.Visible = true;
            }
            else
            {
                CheckResultLabel.Text = $"\"{palindromeText}\" is not a palindrome.";
                CheckResultLabel.ForeColor = Color.Red;
                CheckResultLabel.Visible = true;
            }
            return;
        }
    }
}
