using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Number buttons
        private void number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            txtDisplay.Text += b.Text;
        }

        // Operator buttons
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            num1 = Convert.ToDouble(txtDisplay.Text);
            op = b.Text;
            txtDisplay.Text = "0";
        }

        // Equal button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            if (op == "+") result = num1 + num2;
            else if (op == "-") result = num1 - num2;
            else if (op == "*") result = num1 * num2;
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                    return;
                }
                result = num1 / num2;
            }

            txtDisplay.Text = result.ToString();
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}