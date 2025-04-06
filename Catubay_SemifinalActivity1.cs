using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentRecordApp
{
    public partial class Catubay_SemifinalActivity1 : Form
    {
        public Catubay_SemifinalActivity1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveStudentRecord();
                MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            // Validate ID Number (numbers only)
            if (!Regex.IsMatch(txtIdNo.Text, @"^\d+$"))
            {
                MessageBox.Show("ID Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdNo.Focus();
                return false;
            }

            // Validate First Name (no special characters)
            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z\s]+$") || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            // Validate Last Name (no special characters)
            if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z\s]+$") || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            // Validate Middle Name (no special characters)
            if (!string.IsNullOrWhiteSpace(txtMiddleName.Text) && !Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Middle Name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMiddleName.Focus();
                return false;
            }

            // Validate Course (no special characters)
            if (!Regex.IsMatch(txtCourse.Text, @"^[a-zA-Z\s]+$") || string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Course must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourse.Focus();
                return false;
            }

            // Validate Year Level (numbers only)
            if (!Regex.IsMatch(txtYearLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Year Level must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearLevel.Focus();
                return false;
            }

            // Validate Birthday (year/month/day)
            DateTime birthDate;
            if (!DateTime.TryParse(dtpBirthday.Text, out birthDate))
            {
                MessageBox.Show("Please enter a valid birth date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpBirthday.Focus();
                return false;
            }

            return true;
        }

        private void SaveStudentRecord()
        {
            string filePath = "student_record.txt";
            string record = $"ID No: {txtIdNo.Text}\r\n" +
                           $"First Name: {txtFirstName.Text}\r\n" +
                           $"Last Name: {txtLastName.Text}\r\n" +
                           $"Middle Name: {txtMiddleName.Text}\r\n" +
                           $"Course: {txtCourse.Text}\r\n" +
                           $"Year Level: {txtYearLevel.Text}\r\n" +
                           $"Birthday: {dtpBirthday.Value.ToString("yyyy/MM/dd")}\r\n" +
                           $"-----------------------------------\r\n";

            // Append to file if it exists, create if it doesn't
            File.AppendAllText(filePath, record);
        }

        private void ClearInputs()
        {
            txtIdNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            dtpBirthday.Value = DateTime.Now;
            txtIdNo.Focus();
        }
    }
}

