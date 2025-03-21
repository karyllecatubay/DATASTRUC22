using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EnhancedCalculator
{
    public partial class CalculatorForm : Form
    {
        private string currentInput = "0";
        private string currentExpression = string.Empty;
        private bool operatorClicked = false;
        private bool equalsClicked = false;
        private bool decimalPointAdded = false;
        private string memoryValue = string.Empty;

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
                    if (currentInput == "0" || operatorClicked || equalsClicked)
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
                if (currentInput == "0" || operatorClicked || equalsClicked)
                {
                    // If the current input is 0 and the button pressed is not 0
                    // replace the 0 with the new digit
                    if (currentInput == "0" && button.Text == "0")
                    {
                        // Do nothing if trying to add more zeros at the beginning
                        currentInput = "0";
                    }
                    else
                    {
                        currentInput = button.Text;
                    }
                    operatorClicked = false;
                    equalsClicked = false;
                }
                else
                {
                    currentInput += button.Text;
                }
            }
            
            displayTextBox.Text = currentInput;
            expressionLabel.Text = currentExpression;
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
            if (!string.IsNullOrEmpty(currentInput) && currentInput != "Error")
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
                
                expressionLabel.Text = currentExpression;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !operatorClicked && currentInput != "Error")
            {
                // Add current input to expression
                currentExpression += currentInput;
                expressionLabel.Text = currentExpression + "=";
                
                // Calculate the result
                CalculateExpression();
                displayTextBox.Text = currentInput;
                
                // Reset for next calculation
                currentExpression = string.Empty;
                equalsClicked = true;
                decimalPointAdded = currentInput.Contains(".");
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
            expressionLabel.Text = currentExpression;
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (currentInput.Length > 0 && !operatorClicked && !equalsClicked && currentInput != "Error")
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
                string expressionToEvaluate = currentExpression;
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

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            switch (button.Text)
            {
                case "MC": // Memory Clear
                    memoryValue = string.Empty;
                    break;
                
                case "MR": // Memory Recall
                    if (!string.IsNullOrEmpty(memoryValue))
                    {
                        currentInput = memoryValue;
                        displayTextBox.Text = currentInput;
                        decimalPointAdded = memoryValue.Contains(".");
                    }
                    break;
                
                case "M+": // Memory Add
                    if (!string.IsNullOrEmpty(currentInput) && currentInput != "Error")
                    {
                        if (string.IsNullOrEmpty(memoryValue))
                        {
                            memoryValue = currentInput;
                        }
                        else
                        {
                            // Add current value to memory
                            DataTable dt = new DataTable();
                            var result = dt.Compute(memoryValue + "+" + currentInput, "");
                            memoryValue = result.ToString();
                            
                            // If result ends with .0, remove the decimal part
                            if (memoryValue.EndsWith(".0"))
                            {
                                memoryValue = memoryValue.Substring(0, memoryValue.Length - 2);
                            }
                        }
                    }
                    break;
                
                case "M-": // Memory Subtract
                    if (!string.IsNullOrEmpty(currentInput) && currentInput != "Error")
                    {
                        if (string.IsNullOrEmpty(memoryValue))
                        {
                            memoryValue = "-" + currentInput;
                        }
                        else
                        {
                            // Subtract current value from memory
                            DataTable dt = new DataTable();
                            var result = dt.Compute(memoryValue + "-" + currentInput, "");
                            memoryValue = result.ToString();
                            
                            // If result ends with .0, remove the decimal part
                            if (memoryValue.EndsWith(".0"))
                            {
                                memoryValue = memoryValue.Substring(0, memoryValue.Length - 2);
                            }
                        }
                    }
                    break;
            }
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            if (currentInput != "0" && currentInput != "Error")
            {
                if (currentInput.StartsWith("-"))
                {
                    currentInput = currentInput.Substring(1);
                }
                else
                {
                    currentInput = "-" + currentInput;
                }
                
                displayTextBox.Text = currentInput;
            }
        }
    }
}
