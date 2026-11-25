using System;
using System.Windows.Forms;

namespace sess11_winforms_addnums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Put the cursor in the first box when the form opens
            this.ActiveControl = txtFirstNumber;
        }

        // Add button (also Alt+A, or Enter)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check that the first number has been entered
            if (string.IsNullOrWhiteSpace(txtFirstNumber.Text))
            {
                MessageBox.Show("Please enter the first number.",
                    "Missing First Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstNumber.Focus();
                return; // Stop further method execution
            }

            // Check that the second number has been entered
            if (string.IsNullOrWhiteSpace(txtSecondNumber.Text))
            {
                MessageBox.Show("Please enter the second number.",
                    "Missing Second Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecondNumber.Focus();
                return; // Stop further method execution
            }

            try
            {
                int num1 = int.Parse(txtFirstNumber.Text);
                int num2 = int.Parse(txtSecondNumber.Text);
                txtAnswer.Text = (num1 + num2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value e.g., '5'",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The error:\n'{ex.Message}' occurred!",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear button (also Alt+L, or Edit > Clear / Ctrl+L)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtAnswer.Clear();
            txtFirstNumber.Focus();
        }

        // File > Exit (also Alt+F4)
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
