using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnhancedCalculator
{
    public partial class CalculatorForm : Form
    {
        private double currentValue = 0;
        private double memoryValue = 0;
        private string currentOperator = "";
        private bool isNewCalculation = true;
        private bool isOperatorClicked = false;

        public CalculatorForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += CalculatorForm_KeyDown;
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle keyboard input
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    NumberButton_Click(this.GetButtonByText("0"), EventArgs.Empty);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    NumberButton_Click(this.GetButtonByText("1"), EventArgs.Empty);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    NumberButton_Click(this.GetButtonByText("2"), EventArgs.Empty);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    NumberButton_Click(this.GetButtonByText("3"), EventArgs.Empty);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    NumberButton_Click(this.GetButtonByText("4"), EventArgs.Empty);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    NumberButton_Click(this.GetButtonByText("5"), EventArgs.Empty);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    NumberButton_Click(this.GetButtonByText("6"), EventArgs.Empty);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    NumberButton_Click(this.GetButtonByText("7"), EventArgs.Empty);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    NumberButton_Click(this.GetButtonByText("8"), EventArgs.Empty);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    NumberButton_Click(this.GetButtonByText("9"), EventArgs.Empty);
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                    NumberButton_Click(this.GetButtonByText("."), EventArgs.Empty);
                    break;
                case Keys.Add:
                    OperatorButton_Click(this.GetButtonByText("+"), EventArgs.Empty);
                    break;
                case Keys.Subtract:
                    OperatorButton_Click(this.GetButtonByText("-"), EventArgs.Empty);
                    break;
                case Keys.Multiply:
                    OperatorButton_Click(this.GetButtonByText("×"), EventArgs.Empty);
                    break;
                case Keys.Divide:
                    OperatorButton_Click(this.GetButtonByText("÷"), EventArgs.Empty);
                    break;
                case Keys.Enter:
                    EqualsButton_Click(this.GetButtonByText("="), EventArgs.Empty);
                    break;
                case Keys.Escape:
                    ClearButton_Click(this.GetButtonByText("C"), EventArgs.Empty);
                    break;
                case Keys.Back:
                    BackspaceButton_Click(this.GetButtonByText("DEL"), EventArgs.Empty);
                    break;
            }
        }

        private Button GetButtonByText(string text)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Text == text)
                {
                    return (Button)control;
                }
            }
            return null;
        }

        protected void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            // Clear display if a new calculation is starting or an operator was just clicked
            if (isNewCalculation || isOperatorClicked)
            {
                displayTextBox.Text = "";
                isNewCalculation = false;
                isOperatorClicked = false;
            }

            // Handle decimal point
            if (buttonText == ".")
            {
                if (!displayTextBox.Text.Contains("."))
                {
                    if (displayTextBox.Text == "" || displayTextBox.Text == "0")
                    {
                        displayTextBox.Text = "0.";
                    }
                    else
                    {
                        displayTextBox.Text += ".";
                    }
                }
            }
            else // Handle digits
            {
                if (displayTextBox.Text == "0")
                {
                    displayTextBox.Text = buttonText;
                }
                else
                {
                    displayTextBox.Text += buttonText;
                }
            }
        }

        protected void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (!isOperatorClicked)
            {
                if (currentOperator != "")
                {
                    EqualsButton_Click(this, EventArgs.Empty);
                }

                currentValue = Convert.ToDouble(displayTextBox.Text);
                currentOperator = button.Text;
                
                expressionLabel.Text = displayTextBox.Text + " " + currentOperator;
                isOperatorClicked = true;
            }
            else
            {
                // Change operator if another one is clicked
                currentOperator = button.Text;
                expressionLabel.Text = expressionLabel.Text.Substring(0, expressionLabel.Text.Length - 1) + currentOperator;
            }
        }

        protected void EqualsButton_Click(object sender, EventArgs e)
        {
            if (currentOperator == "")
                return;

            double secondValue = Convert.ToDouble(displayTextBox.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = currentValue + secondValue;
                    break;
                case "-":
                    result = currentValue - secondValue;
                    break;
                case "×":
                    result = currentValue * secondValue;
                    break;
                case "÷":
                    if (secondValue != 0)
                    {
                        result = currentValue / secondValue;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearButton_Click(this, EventArgs.Empty);
                        return;
                    }
                    break;
            }

            expressionLabel.Text += " " + secondValue.ToString() + " = ";
            displayTextBox.Text = result.ToString();
            currentValue = result;
            currentOperator = "";
            isNewCalculation = true;
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Text == "C") // Clear all
            {
                displayTextBox.Text = "0";
                expressionLabel.Text = "";
                currentValue = 0;
                currentOperator = "";
                isNewCalculation = true;
                isOperatorClicked = false;
            }
            else if (button.Text == "CE") // Clear entry
            {
                displayTextBox.Text = "0";
            }
        }

        protected void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text.Length > 1)
            {
                displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1);
            }
            else
            {
                displayTextBox.Text = "0";
            }
        }

        protected void NegateButton_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text != "0")
            {
                if (displayTextBox.Text.StartsWith("-"))
                {
                    displayTextBox.Text = displayTextBox.Text.Substring(1);
                }
                else
                {
                    displayTextBox.Text = "-" + displayTextBox.Text;
                }
            }
        }

        protected void MemoryButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            switch (button.Text)
            {
                case "MC": // Memory Clear
                    memoryValue = 0;
                    break;
                case "MR": // Memory Recall
                    displayTextBox.Text = memoryValue.ToString();
                    isNewCalculation = true;
                    break;
                case "M+": // Memory Add
                    memoryValue += Convert.ToDouble(displayTextBox.Text);
                    isNewCalculation = true;
                    break;
                case "M-": // Memory Subtract
                    memoryValue -= Convert.ToDouble(displayTextBox.Text);
                    isNewCalculation = true;
                    break;
            }
        }
    }
}
