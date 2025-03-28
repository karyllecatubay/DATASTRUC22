using System;
using System.Windows.Forms;

namespace HealthSurveyApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HealthSurveyForm());
        }
    }

    public partial class HealthSurveyForm : Form
    {
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || 
                string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create summary
            string summary = "Health Survey Summary:\n\n" +
                $"Name: {txtFirstName.Text} {txtLastName.Text}\n" +
                $"Email: {txtEmail.Text}\n" +
                $"Phone: {txtPhoneNumber.Text}\n" +
                $"Age: {lblAge.Text.Replace("Age: ", "")}\n" +
                $"Gender: {cmbGender.SelectedItem}\n\n" +
                $"Pregnancy Status: {(rdoPregnancyYes.Checked ? "Yes" : rdoPregnancyNo.Checked ? "No" : "N/A")}\n" +
                $"Food Allergies: {(rdoAllergiesYes.Checked ? "Yes" : "No")}\n" +
                $"Sleep Hours: {cmbSleepHours.SelectedItem}\n" +
                $"Water Intake: {cmbWaterIntake.SelectedItem}\n" +
                $"Exercise Frequency: {cmbExerciseFrequency.SelectedItem}\n" +
                $"Smoking Status: {(rdoSmokingYes.Checked ? "Yes" : "No")}";

            rtbSummary.Text = summary;
        }

        private void DtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dtpBirthdate.Value.Year;
            if (DateTime.Today < dtpBirthdate.Value.AddYears(age)) age--;
            lblAge.Text = $"Age: {age}";
        }

        // Constructor
        public HealthSurveyForm()
        {
            InitializeComponent();
        }
    }
}
