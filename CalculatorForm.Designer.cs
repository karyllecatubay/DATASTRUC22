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
            
            // Button definitions
            this.MCButton = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.MMinusButton = new System.Windows.Forms.Button();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.NegateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearEntryButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            
            // Create version label
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionLabel.Text = "v1.0";
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(25, 520);
            this.versionLabel.ForeColor = System.Drawing.Color.Gray;
            this.versionLabel.Font = new System.Drawing.Font("Arial", 8F);
            
            // Button layout
            int buttonWidth = 70;
            int buttonHeight = 60;
            int xPadding = 5;
            int yPadding = 5;
            int xStart = 25;
            int yStart = 110;
            
            // Row 1 - Memory buttons
            // MC Button
            this.MCButton.Location = new System.Drawing.Point(xStart, yStart);
            this.MCButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MCButton.Text = "MC";
            this.MCButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MCButton.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.MCButton.ForeColor = System.Drawing.Color.White;
            this.MCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCButton.FlatAppearance.BorderSize = 0;
            this.MCButton.TabStop = false;
            this.MCButton.Click += new System.EventHandler(this.MemoryButton_Click);
            
            // MR Button
            this.MRButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart);
            this.MRButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MRButton.Text = "MR";
            this.MRButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MRButton.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.MRButton.ForeColor = System.Drawing.Color.White;
            this.MRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MRButton.FlatAppearance.BorderSize = 0;
            this.MRButton.TabStop = false;
            this.MRButton.Click += new System.EventHandler(this.MemoryButton_Click);
            
            // M- Button
            this.MMinusButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart);
            this.MMinusButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MMinusButton.Text = "M-";
            this.MMinusButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MMinusButton.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.MMinusButton.ForeColor = System.Drawing.Color.White;
            this.MMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MMinusButton.FlatAppearance.BorderSize = 0;
            this.MMinusButton.TabStop = false;
            this.MMinusButton.Click += new System.EventHandler(this.MemoryButton_Click);
            
            // M+ Button
            this.MPlusButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart);
            this.MPlusButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MPlusButton.Text = "M+";
            this.MPlusButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MPlusButton.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.MPlusButton.ForeColor = System.Drawing.Color.White;
            this.MPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPlusButton.FlatAppearance.BorderSize = 0;
            this.MPlusButton.TabStop = false;
            this.MPlusButton.Click += new System.EventHandler(this.MemoryButton_Click);
            
            // Row 2 - 7, 8, 9, ÷
            // 7 Button
            this.SevenButton.Location = new System.Drawing.Point(xStart, yStart + (buttonHeight + yPadding));
            this.SevenButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.SevenButton.Text = "7";
            this.SevenButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.TabStop = false;
            this.SevenButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 8 Button
            this.EightButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart + (buttonHeight + yPadding));
            this.EightButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.EightButton.Text = "8";
            this.EightButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.TabStop = false;
            this.EightButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 9 Button
            this.NineButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart + (buttonHeight + yPadding));
            this.NineButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.NineButton.Text = "9";
            this.NineButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.TabStop = false;
            this.NineButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // ÷ Button
            this.DivideButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart + (buttonHeight + yPadding));
            this.DivideButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.DivideButton.Text = "÷";
            this.DivideButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.DivideButton.BackColor = System.Drawing.Color.FromArgb(255, 160, 10);
            this.DivideButton.ForeColor = System.Drawing.Color.White;
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.FlatAppearance.BorderSize = 0;
            this.DivideButton.TabStop = false;
            this.DivideButton.Click += new System.EventHandler(this.OperatorButton_Click);
            
            // Row 3 - 4, 5, 6, ×
            // 4 Button
            this.FourButton.Location = new System.Drawing.Point(xStart, yStart + 2 * (buttonHeight + yPadding));
            this.FourButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.FourButton.Text = "4";
            this.FourButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.TabStop = false;
            this.FourButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 5 Button
            this.FiveButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart + 2 * (buttonHeight + yPadding));
            this.FiveButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.FiveButton.Text = "5";
            this.FiveButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.TabStop = false;
            this.FiveButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 6 Button
            this.SixButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart + 2 * (buttonHeight + yPadding));
            this.SixButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.SixButton.Text = "6";
            this.SixButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.TabStop = false;
            this.SixButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // × Button
            this.MultiplyButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart + 2 * (buttonHeight + yPadding));
            this.MultiplyButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MultiplyButton.BackColor = System.Drawing.Color.FromArgb(255, 160, 10);
            this.MultiplyButton.ForeColor = System.Drawing.Color.White;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.TabStop = false;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorButton_Click);
            
            // Row 4 - 1, 2, 3, -
            // 1 Button
            this.OneButton.Location = new System.Drawing.Point(xStart, yStart + 3 * (buttonHeight + yPadding));
            this.OneButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.OneButton.Text = "1";
            this.OneButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.TabStop = false;
            this.OneButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 2 Button
            this.TwoButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart + 3 * (buttonHeight + yPadding));
            this.TwoButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.TwoButton.Text = "2";
            this.TwoButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.TabStop = false;
            this.TwoButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // 3 Button
            this.ThreeButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart + 3 * (buttonHeight + yPadding));
            this.ThreeButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.ThreeButton.Text = "3";
            this.ThreeButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.TabStop = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // - Button
            this.MinusButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart + 3 * (buttonHeight + yPadding));
            this.MinusButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.MinusButton.Text = "-";
            this.MinusButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MinusButton.BackColor = System.Drawing.Color.FromArgb(255, 160, 10);
            this.MinusButton.ForeColor = System.Drawing.Color.White;
            this.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusButton.FlatAppearance.BorderSize = 0;
            this.MinusButton.TabStop = false;
            this.MinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            
            // Row 5 - +/-, 0, ., +
            // +/- Button
            this.NegateButton.Location = new System.Drawing.Point(xStart, yStart + 4 * (buttonHeight + yPadding));
            this.NegateButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.NegateButton.Text = "+/-";
            this.NegateButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.NegateButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.NegateButton.ForeColor = System.Drawing.Color.White;
            this.NegateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NegateButton.FlatAppearance.BorderSize = 0;
            this.NegateButton.TabStop = false;
            this.NegateButton.Click += new System.EventHandler(this.NegateButton_Click);
            
            // 0 Button
            this.ZeroButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart + 4 * (buttonHeight + yPadding));
            this.ZeroButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.ZeroButton.Text = "0";
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.TabStop = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // . Button
            this.DecimalButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart + 4 * (buttonHeight + yPadding));
            this.DecimalButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.DecimalButton.Text = ".";
            this.DecimalButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.DecimalButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecimalButton.FlatAppearance.BorderSize = 0;
            this.DecimalButton.TabStop = false;
            this.DecimalButton.Click += new System.EventHandler(this.NumberButton_Click);
            
            // + Button
            this.PlusButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart + 4 * (buttonHeight + yPadding));
            this.PlusButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.PlusButton.Text = "+";
            this.PlusButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(255, 160, 10);
            this.PlusButton.ForeColor = System.Drawing.Color.White;
            this.PlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusButton.FlatAppearance.BorderSize = 0;
            this.PlusButton.TabStop = false;
            this.PlusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            
            // Row 6 - CE, C, DEL, =
            // CE Button
            this.ClearEntryButton.Location = new System.Drawing.Point(xStart, yStart + 5 * (buttonHeight + yPadding));
            this.ClearEntryButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.ClearEntryButton.Text = "CE";
            this.ClearEntryButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ClearEntryButton.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.ClearEntryButton.ForeColor = System.Drawing.Color.White;
            this.ClearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEntryButton.FlatAppearance.BorderSize = 0;
            this.ClearEntryButton.TabStop = false;
            this.ClearEntryButton.Click += new System.EventHandler(this.ClearButton_Click);
            
            // C Button
            this.ClearButton.Location = new System.Drawing.Point(xStart + (buttonWidth + xPadding), yStart + 5 * (buttonHeight + yPadding));
            this.ClearButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.ClearButton.Text = "C";
            this.ClearButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.TabStop = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            
            // DEL Button
            this.DeleteButton.Location = new System.Drawing.Point(xStart + 2 * (buttonWidth + xPadding), yStart + 5 * (buttonHeight + yPadding));
            this.DeleteButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.DeleteButton.Text = "DEL";
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            
            // = Button
            this.EqualsButton.Location = new System.Drawing.Point(xStart + 3 * (buttonWidth + xPadding), yStart + 5 * (buttonHeight + yPadding));
            this.EqualsButton.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.EqualsButton.Text = "=";
            this.EqualsButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(255, 160, 10);
            this.EqualsButton.ForeColor = System.Drawing.Color.White;
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.FlatAppearance.BorderSize = 0;
            this.EqualsButton.TabStop = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            
            // Add all controls to the form
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.MCButton);
            this.Controls.Add(this.MRButton);
            this.Controls.Add(this.MMinusButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.NegateButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.ClearEntryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.versionLabel);
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label versionLabel;
        
        private System.Windows.Forms.Button MCButton;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button MMinusButton;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button NegateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearEntryButton;
        private System.Windows.Forms.Button EqualsButton;
    }
}
