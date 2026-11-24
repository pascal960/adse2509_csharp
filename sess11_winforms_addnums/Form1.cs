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
            double first, second;

            if (!double.TryParse(txtFirstNumber.Text, out first))
            {
                MessageBox.Show("Please enter a valid first number.", "Add Numbers",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstNumber.Focus();
                txtFirstNumber.SelectAll();
                return;
            }

            if (!double.TryParse(txtSecondNumber.Text, out second))
            {
                MessageBox.Show("Please enter a valid second number.", "Add Numbers",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSecondNumber.Focus();
                txtSecondNumber.SelectAll();
                return;
            }

            txtAnswer.Text = (first + second).ToString();
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
