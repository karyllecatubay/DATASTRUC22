namespace BasicCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            
            // Form properties
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Text = "Calculator";
            this.BackColor = System.Drawing.Color.Black;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            // Display textbox
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox.Location = new System.Drawing.Point(25, 25);
            this.displayTextBox.Size = new System.Drawing.Size(300, 50);
            this.displayTextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Text = "0";
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.displayTextBox.ForeColor = System.Drawing.Color.White;
            
            // Create buttons
            string[,] buttonLabels = new string[5, 4] {
                { "7", "8", "9", "÷" },
                { "4", "5", "6", "×" },
                { "1", "2", "3", "-" },
                { "0", ".", "C", "+" },
                { "MC", "MR", "M-", "=" }
            };
            
            // Button layout
            int buttonWidth = 70;
            int buttonHeight = 70;
            int xPadding = 5;
            int yPadding = 5;
            int xStart = 25;
            int yStart = 100;
            
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.Location = new System.Drawing.Point(xStart + col * (buttonWidth + xPadding), 
                                                      yStart + row * (buttonHeight + yPadding));
                    button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    button.Text = buttonLabels[row, col];
                    button.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
                    button.Name = buttonLabels[row, col] + "Button";
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    
                    // Set button colors based on type
                    if (buttonLabels[row, col] == "÷" || buttonLabels[row, col] == "×" || 
                        buttonLabels[row, col] == "-" || buttonLabels[row, col] == "+")
                    {
                        // Operator buttons - orange/yellow like iPhone
                        button.BackColor = System.Drawing.Color.FromArgb(255, 160, 10); // Orange/yellow
                        button.ForeColor = System.Drawing.Color.White;
                    }
                    else if (buttonLabels[row, col] == "=")
                    {
                        // Equals button - orange/yellow like iPhone
                        button.BackColor = System.Drawing.Color.FromArgb(255, 160, 10); // Orange/yellow
                        button.ForeColor = System.Drawing.Color.White;
                    }
                    else if (buttonLabels[row, col] == "C")
                    {
                        // Clear button - light gray
                        button.BackColor = System.Drawing.Color.FromArgb(192, 192, 192);
                        button.ForeColor = System.Drawing.Color.Black;
                    }
                    else if (buttonLabels[row, col].StartsWith("M"))
                    {
                        // Memory buttons - dark gray
                        button.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
                        button.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        // Number buttons - dark gray
                        button.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
                        button.ForeColor = System.Drawing.Color.White;
                    }
                    
                    // Add click event handler based on button type
                    if (char.IsDigit(buttonLabels[row, col][0]) || buttonLabels[row, col] == ".")
                    {
                        button.Click += new System.EventHandler(this.NumberButton_Click);
                    }
                    else if (buttonLabels[row, col] == "+" || buttonLabels[row, col] == "-" || 
                             buttonLabels[row, col] == "×" || buttonLabels[row, col] == "÷")
                    {
                        button.Click += new System.EventHandler(this.OperatorButton_Click);
                    }
                    else if (buttonLabels[row, col] == "=")
                    {
                        button.Click += new System.EventHandler(this.EqualsButton_Click);
                    }
                    else if (buttonLabels[row, col] == "C")
                    {
                        button.Click += new System.EventHandler(this.ClearButton_Click);
                    }
                    
                    this.Controls.Add(button);
                }
            }
            
            // Add backspace button
            this.backspaceButton = new System.Windows.Forms.Button();
            this.backspaceButton.Location = new System.Drawing.Point(25, 445);
            this.backspaceButton.Size = new System.Drawing.Size(300, 40);
            this.backspaceButton.Text = "Backspace";
            this.backspaceButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.backspaceButton.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.backspaceButton.ForeColor = System.Drawing.Color.White;
            this.backspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceButton.FlatAppearance.BorderSize = 0;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.backspaceButton);
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button backspaceButton;
    }
}
