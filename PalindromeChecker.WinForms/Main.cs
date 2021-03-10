using System;
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
            string returnText;
            if (isPalindrome)
            {
                returnText = $"\"{palindromeText}\" is a palindrome.";
            }
            else
            {
                returnText = $"\"{palindromeText}\" is not a palindrome.";
            }
            MessageBox.Show(returnText,
                "PalindromeChecker Result",
                MessageBoxButtons.OK
            );
            return;
        }
    }
}
