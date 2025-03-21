namespace EnhancedCalculator
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
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Text = "Calculator";
            this.BackColor = System.Drawing.Color.Black;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            
            // Expression label (shows the current calculation)
            this.expressionLabel = new System.Windows.Forms.Label();
            this.expressionLabel.Location = new System.Drawing.Point(25, 15);
            this.expressionLabel.Size = new System.Drawing.Size(300, 20);
            this.expressionLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.expressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.ForeColor = System.Drawing.Color.LightGray;
            
            // Display textbox
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox.Location = new System.Drawing.Point(25, 40);
            this.displayTextBox.Size = new System.Drawing.Size(300, 50);
            this.displayTextBox.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Text = "0";
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.displayTextBox.ForeColor = System.Drawing.Color.White;
            
            // Create buttons
            string[,] buttonLabels = new string[6, 4] {
                { "MC", "MR", "M-", "M+" },
                { "7", "8", "9", "÷" },
                { "4", "5", "6", "×" },
                { "1", "2", "3", "-" },
                { "0", ".", "C", "+" },
                { "±", "DEL", "CE", "=" }
            };
            
            // Button layout
            int buttonWidth = 70;
            int buttonHeight = 60;
            int xPadding = 5;
            int yPadding = 5;
            int xStart = 25;
            int yStart = 110;
            
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.Location = new System.Drawing.Point(xStart + col * (buttonWidth + xPadding), 
                                                      yStart + row * (buttonHeight + yPadding));
                    button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    button.Text = buttonLabels[row, col];
                    button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
                    button.Name = buttonLabels[row, col] + "Button";
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.TabStop = false; // Prevent focus rectangle
                    
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
                    else if (buttonLabels[row, col] == "C" || buttonLabels[row, col] == "CE" || buttonLabels[row, col] == "DEL")
                    {
                        // Clear/Delete buttons - light gray
                        button.BackColor = System.Drawing.Color.FromArgb(192, 192, 192);
                        button.ForeColor = System.Drawing.Color.Black;
                    }
                    else if (buttonLabels[row, col].StartsWith("M") || buttonLabels[row, col] == "±")
                    {
                        // Memory buttons and negate - dark gray
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
                    else if (buttonLabels[row, col] == "C" || buttonLabels[row, col] == "CE")
                    {
                        button.Click += new System.EventHandler(this.ClearButton_Click);
                    }
                    else if (buttonLabels[row, col] == "DEL")
                    {
                        button.Click += new System.EventHandler(this.BackspaceButton_Click);
                    }
                    else if (buttonLabels[row, col] == "±")
                    {
                        button.Click += new System.EventHandler(this.NegateButton_Click);
                    }
                    else if (buttonLabels[row, col].StartsWith("M"))
                    {
                        button.Click += new System.EventHandler(this.MemoryButton_Click);
                    }
                    
                    this.Controls.Add(button);
                }
            }
            
            // Create version label
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionLabel.Text = "v1.0";
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(25, 520);
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 8F);
            
            // Add controls to form
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.versionLabel);
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}
