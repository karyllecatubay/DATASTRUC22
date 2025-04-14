using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Catubay_SemifinalActivity2
{
    public partial class Catubay_SemifinalActivity2 : Form
    {
        private const string FilePath = "student_record.txt";
        private int currentStudentIndex = -1;
        private List<StudentRecord> studentRecords = new List<StudentRecord>();

        public Catubay_SemifinalActivity2()
        {
            InitializeComponent();
        }

        private void Catubay_SemifinalActivity2_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
            RefreshDataGridView();

            // Initialize buttons state
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadStudentRecords()
        {
            studentRecords.Clear();

            if (!File.Exists(FilePath))
                return;

            string[] lines = File.ReadAllLines(FilePath);

            StudentRecord currentStudent = null;
            int lineCount = 0;

            foreach (string line in lines)
            {
                // Skip separator line
                if (line.StartsWith("---"))
                {
                    if (currentStudent != null)
                    {
                        studentRecords.Add(currentStudent);
                        currentStudent = null;
                    }
                    continue;
                }

                if (line.StartsWith("ID No:"))
                {
                    currentStudent = new StudentRecord();
                    currentStudent.IdNo = line.Replace("ID No:", "").Trim();
                }
                else if (currentStudent != null)
                {
                    if (line.StartsWith("First Name:"))
                        currentStudent.FirstName = line.Replace("First Name:", "").Trim();
                    else if (line.StartsWith("Last Name:"))
                        currentStudent.LastName = line.Replace("Last Name:", "").Trim();
                    else if (line.StartsWith("Middle Name:"))
                        currentStudent.MiddleName = line.Replace("Middle Name:", "").Trim();
                    else if (line.StartsWith("Course:"))
                        currentStudent.Course = line.Replace("Course:", "").Trim();
                    else if (line.StartsWith("Year Level:"))
                        currentStudent.YearLevel = line.Replace("Year Level:", "").Trim();
                    else if (line.StartsWith("Birthday:"))
                        currentStudent.Birthday = line.Replace("Birthday:", "").Trim();
                }
            }

            // Add the last student if not added yet
            if (currentStudent != null)
                studentRecords.Add(currentStudent);
        }

        private void RefreshDataGridView()
        {
            dgvStudents.Rows.Clear();

            foreach (StudentRecord student in studentRecords)
            {
                dgvStudents.Rows.Add(
                    student.IdNo,
                    student.LastName,
                    student.FirstName,
                    student.MiddleName
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                SaveStudentRecord();
                MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadStudentRecords();
                RefreshDataGridView();
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
            string record = $"ID No: {txtIdNo.Text}\r\n" +
                           $"First Name: {txtFirstName.Text}\r\n" +
                           $"Last Name: {txtLastName.Text}\r\n" +
                           $"Middle Name: {txtMiddleName.Text}\r\n" +
                           $"Course: {txtCourse.Text}\r\n" +
                           $"Year Level: {txtYearLevel.Text}\r\n" +
                           $"Birthday: {dtpBirthday.Value.ToString("yyyy/MM/dd")}\r\n" +
                           $"-----------------------------------\r\n";

            // Append to file if it exists, create if it doesn't
            File.AppendAllText(FilePath, record);
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

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            currentStudentIndex = -1;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < studentRecords.Count)
            {
                StudentRecord student = studentRecords[e.RowIndex];
                currentStudentIndex = e.RowIndex;

                // Fill the form with selected student data
                txtIdNo.Text = student.IdNo;
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtMiddleName.Text = student.MiddleName;
                txtCourse.Text = student.Course;
                txtYearLevel.Text = student.YearLevel;

                try
                {
                    if (!string.IsNullOrEmpty(student.Birthday))
                    {
                        dtpBirthday.Value = DateTime.Parse(student.Birthday);
                    }
                }
                catch (Exception ex)
                {
                    // Handle date parsing issues
                    MessageBox.Show($"Error parsing birthday: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpBirthday.Value = DateTime.Now;
                }

                // Enable update and delete buttons, disable save
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentStudentIndex == -1)
            {
                MessageBox.Show("Please select a student record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInputs())
                return;

            // Update the selected student record
            studentRecords[currentStudentIndex].IdNo = txtIdNo.Text;
            studentRecords[currentStudentIndex].FirstName = txtFirstName.Text;
            studentRecords[currentStudentIndex].LastName = txtLastName.Text;
            studentRecords[currentStudentIndex].MiddleName = txtMiddleName.Text;
            studentRecords[currentStudentIndex].Course = txtCourse.Text;
            studentRecords[currentStudentIndex].YearLevel = txtYearLevel.Text;
            studentRecords[currentStudentIndex].Birthday = dtpBirthday.Value.ToString("yyyy/MM/dd");

            // Save all records back to file
            SaveAllRecords();

            MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
            RefreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentStudentIndex == -1)
            {
                MessageBox.Show("Please select a student record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the record for {studentRecords[currentStudentIndex].FirstName} {studentRecords[currentStudentIndex].LastName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Remove the selected student record
                studentRecords.RemoveAt(currentStudentIndex);

                // Save remaining records back to file
                SaveAllRecords();

                MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
                RefreshDataGridView();
            }
        }

        private void SaveAllRecords()
        {
            // Clear the file
            File.WriteAllText(FilePath, string.Empty);

            // Write all records to file
            foreach (StudentRecord student in studentRecords)
            {
                string record = $"ID No: {student.IdNo}\r\n" +
                               $"First Name: {student.FirstName}\r\n" +
                               $"Last Name: {student.LastName}\r\n" +
                               $"Middle Name: {student.MiddleName}\r\n" +
                               $"Course: {student.Course}\r\n" +
                               $"Year Level: {student.YearLevel}\r\n" +
                               $"Birthday: {student.Birthday}\r\n" +
                               $"-----------------------------------\r\n";

                File.AppendAllText(FilePath, record);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadStudentRecords();
                RefreshDataGridView();
                return;
            }

            string searchTerm = txtSearch.Text.ToLower();

            // Filter records based on search term
            List<StudentRecord> filteredRecords = studentRecords
                .Where(s =>
                    s.IdNo.ToLower().Contains(searchTerm) ||
                    s.FirstName.ToLower().Contains(searchTerm) ||
                    s.LastName.ToLower().Contains(searchTerm) ||
                    s.MiddleName.ToLower().Contains(searchTerm) ||
                    s.Course.ToLower().Contains(searchTerm)
                )
                .ToList();

            // Update DataGridView with filtered records
            dgvStudents.Rows.Clear();

            foreach (StudentRecord student in filteredRecords)
            {
                dgvStudents.Rows.Add(
                    student.IdNo,
                    student.LastName,
                    student.FirstName,
                    student.MiddleName
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudentRecords();
            RefreshDataGridView();
            txtSearch.Clear();
        }
    }

    public class StudentRecord
    {
        public string IdNo { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string Course { get; set; } = "";
        public string YearLevel { get; set; } = "";
        public string Birthday { get; set; } = "";
    }
}
