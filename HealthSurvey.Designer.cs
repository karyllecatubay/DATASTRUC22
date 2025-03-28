// HealthSurveyForm.Designer.cs
using System;
using System.Windows.Forms;
using System.Drawing;

namespace HealthSurveyApp
{
    partial class HealthSurveyForm
    {
        private void InitializeComponent()
        {
            // Set form properties
            this.Text = "Health Survey";
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(600, 800);

            // Personal Information Controls
            Label lblFirstName = new Label { Text = "First Name:", Location = new Point(20, 20) };
            txtFirstName = new TextBox { Location = new Point(200, 20), Width = 300 };

            Label lblLastName = new Label { Text = "Last Name:", Location = new Point(20, 60) };
            txtLastName = new TextBox { Location = new Point(200, 60), Width = 300 };

            Label lblEmail = new Label { Text = "Email:", Location = new Point(20, 100) };
            txtEmail = new TextBox { Location = new Point(200, 100), Width = 300 };

            Label lblPhone = new Label { Text = "Phone Number:", Location = new Point(20, 140) };
            txtPhone = new TextBox { Location = new Point(200, 140), Width = 300 };

            Label lblAddress = new Label { Text = "Address:", Location = new Point(20, 180) };
            txtAddress = new TextBox { Location = new Point(200, 180), Width = 300, Multiline = true, Height = 50 };

            Label lblBirthdate = new Label { Text = "Birthdate:", Location = new Point(20, 240) };
            dtpBirthdate = new DateTimePicker { Location = new Point(200, 240), Width = 300 };

            Label lblGender = new Label { Text = "Gender:", Location = new Point(20, 280) };
            cboGender = new ComboBox { 
                Location = new Point(200, 280), 
                Width = 300,
                Items = { "Male", "Female", "Non-Binary", "Prefer Not to Say" }
            };

            // Medical Conditions CheckedListBox
            Label lblMedicalConditions = new Label { 
                Text = "Medical Conditions:", 
                Location = new Point(20, 320) 
            };
            chkMedicalConditions = new CheckedListBox {
                Location = new Point(200, 320),
                Width = 300,
                Items = { 
                    "High Blood Pressure", 
                    "Diabetes - Type 1", 
                    "Diabetes - Type 2", 
                    "Gout" 
                }
            };

            // Medications CheckedListBox
            Label lblMedications = new Label { 
                Text = "Medications:", 
                Location = new Point(20, 420) 
            };
            chkMedications = new CheckedListBox {
                Location = new Point(200, 420),
                Width = 300,
                Items = { 
                    "Diabetes", 
                    "High Blood Pressure", 
                    "High Cholesterol", 
                    "Thyroid", 
                    "Lithium", 
                    "Coumadin (Warfarin)" 
                }
            };

            // Nursing RadioButtons
            Label lblNursing = new Label { Text = "Are you nursing?", Location = new Point(20, 520) };
            rbNursingYes = new RadioButton { 
                Text = "Yes", 
                Location = new Point(200, 520) 
            };
            rbNursingNo = new RadioButton { 
                Text = "No", 
                Location = new Point(300, 520) 
            };

            // Food Allergies RadioButtons
            Label lblFoodAllergies = new Label { 
                Text = "Do you have food allergies?", 
                Location = new Point(20, 560) 
            };
            rbFoodAllergiesYes = new RadioButton { 
                Text = "Yes", 
                Location = new Point(200, 560) 
            };
            rbFoodAllergiesNo = new RadioButton { 
                Text = "No", 
                Location = new Point(300, 560) 
            };

            // BMI Section
            Label lblHeight = new Label { Text = "Height:", Location = new Point(20, 600) };
            txtHeight = new TextBox { Location = new Point(200, 600), Width = 300 };

            Label lblWeight = new Label { Text = "Weight:", Location = new Point(20, 640) };
            txtWeight = new TextBox { Location = new Point(200, 640), Width = 300 };

            Label lblCurrentBMI = new Label { Text = "Current BMI:", Location = new Point(20, 680) };
            txtCurrentBMI = new TextBox { Location = new Point(200, 680), Width = 300 };

            Label lblTargetBMI = new Label { Text = "Target BMI:", Location = new Point(20, 720) };
            txtTargetBMI = new TextBox { Location = new Point(200, 720), Width = 300 };

            // Submit Button
            btnSubmit = new Button {
                Text = "Submit Survey", 
                Location = new Point(200, 760), 
                Width = 300
            };
            btnSubmit.Click += btnSubmit_Click;

            // Add controls to form
            this.Controls.AddRange(new Control[] {
                lblFirstName, txtFirstName,
                lblLastName, txtLastName,
                lblEmail, txtEmail,
                lblPhone, txtPhone,
                lblAddress, txtAddress,
                lblBirthdate, dtpBirthdate,
                lblGender, cboGender,
                lblMedicalConditions, chkMedicalConditions,
                lblMedications, chkMedications,
                lblNursing, rbNursingYes, rbNursingNo,
                lblFoodAllergies, rbFoodAllergiesYes, rbFoodAllergiesNo,
                lblHeight, txtHeight,
                lblWeight, txtWeight,
                lblCurrentBMI, txtCurrentBMI,
                lblTargetBMI, txtTargetBMI,
                btnSubmit
            });
        }

        // Declare controls as private fields
        private TextBox txtFirstName, txtLastName, txtEmail, txtPhone, txtAddress;
        private DateTimePicker dtpBirthdate;
        private ComboBox cboGender;
        private CheckedListBox chkMedicalConditions, chkMedications;
        private RadioButton rbNursingYes, rbNursingNo;
        private RadioButton rbFoodAllergiesYes, rbFoodAllergiesNo;
        private TextBox txtHeight, txtWeight, txtCurrentBMI, txtTargetBMI;
        private Button btnSubmit;
    }
}
