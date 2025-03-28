namespace HealthSurveyApp
{
    partial class HealthSurveyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Personal Information Controls
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cmbGender;

        // Health Information Controls
        private System.Windows.Forms.GroupBox grpPregnancy;
        private System.Windows.Forms.RadioButton rdoPregnancyYes;
        private System.Windows.Forms.RadioButton rdoPregnancyNo;
        private System.Windows.Forms.RadioButton rdoPregnancyNA;

        private System.Windows.Forms.GroupBox grpFoodAllergies;
        private System.Windows.Forms.RadioButton rdoAllergiesYes;
        private System.Windows.Forms.RadioButton rdoAllergiesNo;

        private System.Windows.Forms.ComboBox cmbSleepHours;
        private System.Windows.Forms.ComboBox cmbWaterIntake;
        private System.Windows.Forms.ComboBox cmbExerciseFrequency;

        private System.Windows.Forms.GroupBox grpSmoking;
        private System.Windows.Forms.RadioButton rdoSmokingYes;
        private System.Windows.Forms.RadioButton rdoSmokingNo;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbSummary;

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
            // Set form properties
            this.Text = "Health Survey";
            this.Size = new System.Drawing.Size(600, 800);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 10);

            // Personal Information Section
            CreatePersonalInfoControls();

            // Health Information Section
            CreateHealthInfoControls();

            // Submit Button
            btnSubmit = new System.Windows.Forms.Button
            {
                Text = "Submit Survey",
                Location = new System.Drawing.Point(250, 650),
                Size = new System.Drawing.Size(100, 30)
            };
            btnSubmit.Click += BtnSubmit_Click;
            this.Controls.Add(btnSubmit);

            // Summary Output
            rtbSummary = new System.Windows.Forms.RichTextBox
            {
                Location = new System.Drawing.Point(50, 700),
                Size = new System.Drawing.Size(500, 100),
                ReadOnly = true
            };
            this.Controls.Add(rtbSummary);
        }

        private void CreatePersonalInfoControls()
        {
            // First Name
            System.Windows.Forms.Label lblFirstName = new System.Windows.Forms.Label { Text = "First Name:", Location = new System.Drawing.Point(50, 50) };
            txtFirstName = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(200, 50), Size = new System.Drawing.Size(200, 25) };
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirstName);

            // Last Name
            System.Windows.Forms.Label lblLastName = new System.Windows.Forms.Label { Text = "Last Name:", Location = new System.Drawing.Point(50, 100) };
            txtLastName = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(200, 100), Size = new System.Drawing.Size(200, 25) };
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtLastName);

            // Email
            System.Windows.Forms.Label lblEmail = new System.Windows.Forms.Label { Text = "Email:", Location = new System.Drawing.Point(50, 150) };
            txtEmail = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(200, 150), Size = new System.Drawing.Size(200, 25) };
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            // Phone Number
            System.Windows.Forms.Label lblPhoneNumber = new System.Windows.Forms.Label { Text = "Phone Number:", Location = new System.Drawing.Point(50, 200) };
            txtPhoneNumber = new System.Windows.Forms.MaskedTextBox
            {
                Mask = "(999) 000-0000",
                Location = new System.Drawing.Point(200, 200),
                Size = new System.Drawing.Size(200, 25)
            };
            this.Controls.Add(lblPhoneNumber);
            this.Controls.Add(txtPhoneNumber);

            // Address
            System.Windows.Forms.Label lblAddress = new System.Windows.Forms.Label { Text = "Address:", Location = new System.Drawing.Point(50, 250) };
            txtAddress = new System.Windows.Forms.TextBox
            {
                Multiline = true,
                Location = new System.Drawing.Point(200, 250),
                Size = new System.Drawing.Size(300, 50)
            };
            this.Controls.Add(lblAddress);
            this.Controls.Add(txtAddress);

            // Birthdate
            System.Windows.Forms.Label lblBirthdate = new System.Windows.Forms.Label { Text = "Birthdate:", Location = new System.Drawing.Point(50, 320) };
            dtpBirthdate = new System.Windows.Forms.DateTimePicker
            {
                Location = new System.Drawing.Point(200, 320),
                Format = System.Windows.Forms.DateTimePickerFormat.Short
            };
            dtpBirthdate.ValueChanged += DtpBirthdate_ValueChanged;
            this.Controls.Add(lblBirthdate);
            this.Controls.Add(dtpBirthdate);

            // Age (Calculated)
            lblAge = new System.Windows.Forms.Label
            {
                Text = "Age: ",
                Location = new System.Drawing.Point(400, 320),
                AutoSize = true
            };
            this.Controls.Add(lblAge);

            // Gender
            System.Windows.Forms.Label lblGender = new System.Windows.Forms.Label { Text = "Gender:", Location = new System.Drawing.Point(50, 370) };
            cmbGender = new System.Windows.Forms.ComboBox
            {
                Location = new System.Drawing.Point(200, 370),
                Size = new System.Drawing.Size(200, 25),
            };
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer Not to Say" });
            this.Controls.Add(lblGender);
            this.Controls.Add(cmbGender);
        }

        private void CreateHealthInfoControls()
        {
            // Pregnancy Status
            grpPregnancy = new System.Windows.Forms.GroupBox
            {
                Text = "Pregnancy Status",
                Location = new System.Drawing.Point(50, 420),
                Size = new System.Drawing.Size(500, 50)
            };
            rdoPregnancyYes = new System.Windows.Forms.RadioButton { Text = "Yes", Location = new System.Drawing.Point(10, 20) };
            rdoPregnancyNo = new System.Windows.Forms.RadioButton { Text = "No", Location = new System.Drawing.Point(100, 20) };
            rdoPregnancyNA = new System.Windows.Forms.RadioButton { Text = "N/A", Location = new System.Drawing.Point(190, 20), Checked = true };
            grpPregnancy.Controls.Add(rdoPregnancyYes);
            grpPregnancy.Controls.Add(rdoPregnancyNo);
            grpPregnancy.Controls.Add(rdoPregnancyNA);
            this.Controls.Add(grpPregnancy);

            // Food Allergies
            grpFoodAllergies = new System.Windows.Forms.GroupBox
            {
                Text = "Food Allergies",
                Location = new System.Drawing.Point(50, 480),
                Size = new System.Drawing.Size(500, 50)
            };
            rdoAllergiesYes = new System.Windows.Forms.RadioButton { Text = "Yes", Location = new System.Drawing.Point(10, 20) };
            rdoAllergiesNo = new System.Windows.Forms.RadioButton { Text = "No", Location = new System.Drawing.Point(100, 20), Checked = true };
            grpFoodAllergies.Controls.Add(rdoAllergiesYes);
            grpFoodAllergies.Controls.Add(rdoAllergiesNo);
            this.Controls.Add(grpFoodAllergies);

            // Sleep Hours
            System.Windows.Forms.Label lblSleepHours = new System.Windows.Forms.Label { Text = "Hours of Sleep:", Location = new System.Drawing.Point(50, 540) };
            cmbSleepHours = new System.Windows.Forms.ComboBox
            {
                Location = new System.Drawing.Point(200, 540),
            };
            cmbSleepHours.Items.AddRange(new object[] { "Less than 4", "4-6", "6-8", "8-10", "More than 10" });
            this.Controls.Add(lblSleepHours);
            this.Controls.Add(cmbSleepHours);

            // Water Intake
            System.Windows.Forms.Label lblWaterIntake = new System.Windows.Forms.Label { Text = "Daily Water Intake:", Location = new System.Drawing.Point(50, 580) };
            cmbWaterIntake = new System.Windows.Forms.ComboBox
            {
                Location = new System.Drawing.Point(200, 580),
            };
            cmbWaterIntake.Items.AddRange(new object[] { "Less than 1 liter", "1-2 liters", "2-3 liters", "More than 3 liters" });
            this.Controls.Add(lblWaterIntake);
            this.Controls.Add(cmbWaterIntake);

            // Exercise Frequency
            System.Windows.Forms.Label lblExerciseFrequency = new System.Windows.Forms.Label { Text = "Exercise per Week:", Location = new System.Drawing.Point(50, 620) };
            cmbExerciseFrequency = new System.Windows.Forms.ComboBox
            {
                Location = new System.Drawing.Point(200, 620),
            };
            cmbExerciseFrequency.Items.AddRange(new object[] { "None", "1-2 times", "3-4 times", "5-6 times", "Daily" });
            this.Controls.Add(lblExerciseFrequency);
            this.Controls.Add(cmbExerciseFrequency);

            // Smoking Status
            grpSmoking = new System.Windows.Forms.GroupBox
            {
                Text = "Smoking Status",
                Location = new System.Drawing.Point(350, 540),
                Size = new System.Drawing.Size(200, 50)
            };
            rdoSmokingYes = new System.Windows.Forms.RadioButton { Text = "Yes", Location = new System.Drawing.Point(10, 20) };
            rdoSmokingNo = new System.Windows.Forms.RadioButton { Text = "No", Location = new System.Drawing.Point(100, 20), Checked = true };
            grpSmoking.Controls.Add(rdoSmokingYes);
            grpSmoking.Controls.Add(rdoSmokingNo);
            this.Controls.Add(grpSmoking);
        }
        #endregion
    }
}
