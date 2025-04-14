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

            // Validate First Name (not empty)
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            // Validate Last Name (not empty)
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            // Middle Name can be empty or contain any characters

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
                                                         
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Catubay_SemifinalActivity1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

