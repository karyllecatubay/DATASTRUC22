using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class CalculatorForm : Form
    {
        private string currentInput = string.Empty;
        private string currentExpression = string.Empty;
        private bool operatorClicked = false;
        private bool equalsClicked = false;
        private bool decimalPointAdded = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            // Handle decimal point logic
            if (button.Text == ".")
            {
                if (!decimalPointAdded)
                {
                    if (currentInput == string.Empty || operatorClicked || equalsClicked)
                    {
                        currentInput = "0.";
                    }
                    else
                    {
                        currentInput += ".";
                    }
                    decimalPointAdded = true;
                }
            }
            else // Handle number input
            {
                if (operatorClicked || equalsClicked)
                {
                    currentInput = button.Text;
                    operatorClicked = false;
                    equalsClicked = false;
                }
                else
                {
                    // Handle leading zeros
                    if (currentInput == "0" && button.Text != "0")
                    {
                        currentInput = button.Text;
                    }
                    else if (currentInput == "0" && button.Text == "0")
                    {
                        // Do nothing if trying to add more zeros at the beginning
                    }
                    else
                    {
                        currentInput += button.Text;
                    }
                }
            }
            
            displayTextBox.Text = currentInput;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            // If we already have an expression, calculate it first
            if (!string.IsNullOrEmpty(currentExpression) && !operatorClicked)
            {
                CalculateExpression();
                displayTextBox.Text = currentInput;
            }
            
            // Append current input and operator to the expression
            if (!string.IsNullOrEmpty(currentInput))
            {
                currentExpression += currentInput;
                
                // Convert × and ÷ to * and / for calculation
                string operatorSymbol = button.Text;
                if (operatorSymbol == "×") operatorSymbol = "*";
                if (operatorSymbol == "÷") operatorSymbol = "/";
                
                currentExpression += operatorSymbol;
                operatorClicked = true;
                decimalPointAdded = false;
                equalsClicked = false;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !operatorClicked)
            {
                currentExpression += currentInput;
                CalculateExpression();
                displayTextBox.Text = currentInput;
                
                // Reset for next calculation
                currentExpression = string.Empty;
                equalsClicked = true;
                decimalPointAdded = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentInput = "0";
            currentExpression = string.Empty;
            operatorClicked = false;
            equalsClicked = false;
            decimalPointAdded = false;
            
            displayTextBox.Text = currentInput;
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0 && !operatorClicked && !equalsClicked)
            {
                // Check if we're deleting a decimal point
                if (currentInput.EndsWith("."))
                {
                    decimalPointAdded = false;
                }
                
                currentInput = currentInput.Substring(0, currentInput.Length - 1);
                
                // If all digits are deleted, display 0
                if (string.IsNullOrEmpty(currentInput))
                {
                    currentInput = "0";
                }
                
                displayTextBox.Text = currentInput;
            }
        }

        private void CalculateExpression()
        {
            try
            {
                // Convert the expression to a proper format for DataTable.Compute
                string expressionToEvaluate = currentExpression + currentInput;
                expressionToEvaluate = expressionToEvaluate.Replace("×", "*").Replace("÷", "/");
                
                // Evaluate using DataTable.Compute which handles MDAS precedence
                DataTable dt = new DataTable();
                var result = dt.Compute(expressionToEvaluate, "");
                
                // Convert result to string and handle formatting
                currentInput = result.ToString();
                
                // If result ends with .0, remove the decimal part
                if (currentInput.EndsWith(".0"))
                {
                    currentInput = currentInput.Substring(0, currentInput.Length - 2);
                }
                
                // Check if the result has a decimal point
                decimalPointAdded = currentInput.Contains(".");
            }
            catch (Exception)
            {
                currentInput = "Error";
            }
        }
    }
}
