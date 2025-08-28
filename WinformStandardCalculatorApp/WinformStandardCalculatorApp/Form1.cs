namespace WinformStandardCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This method is intentionally left empty.
            // It can be used to handle click events for lblResult if needed in the future.
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            double btnNumber = 0;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            double btnNumber = 1;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            double btnNumber = 2;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            double btnNumber = 3;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            double btnNumber = 4;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            double btnNumber = 5;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            double btnNumber = 6;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the label if it is accessible
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            double btnNumber = 7;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            double btnNumber = 8;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the initial label before inputting a new number
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            double btnNumber = 9;
            if (lblResult.Text == "0")
            {
                lblResult.Text = string.Empty; // Clear the label if it is accessible
            }
            lblResult.Text += btnNumber.ToString(); // Append the number to the label
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResult.Text) && lblResult.Text.Length > 0)
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = null;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double numOne = Convert.ToDouble(lblResult.Text);
            if (!string.IsNullOrEmpty(lblResult.Text))
            {
                lblResult.Text = string.Empty;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public double performAddition(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public double performSubtraction(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }
        public double performMultiplication(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }
        public double performDivision(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
        }
    }
}
