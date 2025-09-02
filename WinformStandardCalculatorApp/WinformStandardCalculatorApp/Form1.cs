namespace WinformStandardCalculatorApp
{
    public partial class FormCalculator : Form
    {
        private double currentValue = 0;         // The current value displayed
        private double storedValue = 0;          // The value stored for the next operation
        private string pendingOperator = "";      // The operator waiting to be performed
        private bool isNewInput = true;          // Flag to start new input after operation
        private string lastOperator = string.Empty;
        private double lastOperand = 0;
        private bool lastWasEquals = false;

        public FormCalculator()
        {
            InitializeComponent();
        }

        // Number button click handlers
        // Handles input for numbers 0-9 by appending to the input label
        private void btnZero_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        // Decimal point button click handler
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                lblInputOutput.Text = "0.";
                isNewInput = false;
            }
            else if (!lblInputOutput.Text.Contains("."))
            {
                lblInputOutput.Text += ".";
            }
        }

        // Clear button click handler
        // Resets the calculator state
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            storedValue = 0;
            pendingOperator = "";
            lblSolution.Text = "";
            lblInputOutput.Text = "0";
            isNewInput = true;
        }

        // Backspace button click handler
        // Deletes the last character of the current input
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!isNewInput && lblInputOutput.Text.Length > 0)
            {
                lblInputOutput.Text = lblInputOutput.Text[..^1];
                if (lblInputOutput.Text == "")
                {
                    lblInputOutput.Text = "0";
                    isNewInput = true;
                }
            }
        }

        // Clear Entry button click handler
        // Clears only the current input
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            lblInputOutput.Text = "0";
            isNewInput = true;
        }

        // Square button click handler
        // Squares the current input value
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblInputOutput.Text, out double value))
            {
                storedValue = Convert.ToDouble(lblInputOutput.Text);
                value = Math.Pow(value, 2);
                lblInputOutput.Text = value.ToString();
                isNewInput = true;
                lastOperator = "^";
            }
        }

        // Sign change button click handler
        // Changes the sign to positive or negative depending on the current input
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblInputOutput.Text == "0")
            {
                return; // Do nothing if input is zero
            }

            if (double.TryParse(lblInputOutput.Text, out double val))
            {
                val = val * -1;
                lblInputOutput.Text = val.ToString();
            }
        }

        // Square root button click handler
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblInputOutput.Text, out double value))
            {
                if (value < 0)
                {
                    lblInputOutput.Text = "0";
                }
                else
                {
                    value = Math.Sqrt(value);
                    lblInputOutput.Text = value.ToString();
                    lastOperator = "√";
                    isNewInput = true;
                }
            }
        }

        // Call this from number button clicks (0-9) to handle input
        private void InputNumber(string number)
        {
            if (isNewInput)
            {
                lblInputOutput.Text = number;
                isNewInput = false;
            }
            else if (lblInputOutput.Text == "0")
            {
                lblInputOutput.Text = number; // Replace leading zero
            }
            else
            {
                lblInputOutput.Text += number;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double leftOperand, rightOperand;

            if (!lastWasEquals)
            {
                // First equals: use lastOperand and current input
                if (!double.TryParse(lblInputOutput.Text, out rightOperand))
                {
                    lblInputOutput.Text = "Error";
                    return;
                }
                leftOperand = lastOperand;
                lastOperand = rightOperand; // Store for continuous operation
            }
            else
            {
                // Subsequent equals: use current result and lastOperand
                if (!double.TryParse(lblInputOutput.Text, out leftOperand))
                {
                    lblInputOutput.Text = "Error";
                    return;
                }
                rightOperand = lastOperand;
            }

            // Perform the operation
            double result = leftOperand;
            switch (lastOperator)
            {
                case "+":
                    result = leftOperand + rightOperand;
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                case "-":
                    result = leftOperand - rightOperand;
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                case "*":
                    result = leftOperand * rightOperand;
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                case "/":
                    if (rightOperand == 0)
                    {
                        lblInputOutput.Text = "Cannot divide by zero";
                        return;
                    }
                    result = leftOperand / rightOperand;
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                case "%":
                    result = leftOperand % rightOperand;
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                case "^":
                    result = Math.Pow(leftOperand, rightOperand);
                    StoreToHistory(result, leftOperand, rightOperand);
                    break;
                default:
                    lblInputOutput.Text = leftOperand.ToString();
                    StoreToHistory(result, leftOperand, rightOperand);
                    return;
            }

            // Update display and state
            lblInputOutput.Text = result.ToString();
            lblSolution.Text = leftOperand + " " + lastOperator + " " + rightOperand + " = " + result;
            lastWasEquals = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("/");
        }
        private void btnModulo_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("%");
        }

        // Store the operator and operand values and update solution label.
        private void StoreOperatorAndOperand(string op)
        {
            if (double.TryParse(lblInputOutput.Text, out double operand))
            {
                lastOperand = operand;
                lastOperator = op;
                lblSolution.Text = lblInputOutput.Text + " " + op;
                lblInputOutput.Text = "0";
                lastWasEquals = false;
            }
        }

        // Store calculation history, keeping only the last 16 entries
        private void StoreToHistory(double result, double leftOperand, double rightOperand)
        {
            String historyEntry = $"{leftOperand} {lastOperator} {rightOperand} = {result}";
            if (listBoxHistory.Items.Count >= 16)
            {
                listBoxHistory.Items.RemoveAt(0); // Remove oldest entry
            }

            if (listBoxHistory.Items.Contains(historyEntry))
            {
                return; // Do not store duplicate entries
            }

            if (result.ToString().Length > 15)
            {
                return; // Do not store overly long results
            }

            if (result.ToString().Contains("E"))
            {
                return; // Do not store results in scientific notation
            }

            if (result.ToString().Contains(".") && result.ToString().TrimEnd('0').EndsWith("."))
            {
                return; // Do not store results that end with a decimal point
            }

            if (result.ToString() == "NaN" || result.ToString() == "Infinity" || result.ToString() == "-Infinity" || result.ToString() == "Error")
            {
                return; // Do not store invalid results
            }

            if (listBoxHistory.Items.Contains("There's no history yet."))
            {
                listBoxHistory.Items.Clear();
            }

            if (listBoxHistory.Items.Contains(historyEntry))
            {
                return; // Do not store duplicate entries
            }

            if (lastOperator == string.Empty)
            {
                return; // Do not store if no operator was used
            }

            if (lastOperator == "^" || lastOperator == "√")
            {
                return; // Do not store single-operand operations
            }
            listBoxHistory.Items.Add(historyEntry);
        }


        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            StoreOperatorAndOperand("^");
        }
    }
}