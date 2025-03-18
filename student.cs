using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdNumber.Text) ||
               string.IsNullOrWhiteSpace(txtCourse.Text) ||
               string.IsNullOrWhiteSpace(txtYearLevel.Text) ||
               string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtHomeAddress.Text) ||
               string.IsNullOrWhiteSpace(txtFatherName.Text) ||
               string.IsNullOrWhiteSpace(txtMotherName.Text) ||
               string.IsNullOrWhiteSpace(txtDateOfBirth.Text) ||
               string.IsNullOrWhiteSpace(txtAge.Text) ||
               string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
               string.IsNullOrWhiteSpace(txtParentContact.Text) ||
               string.IsNullOrWhiteSpace(txtSkillsInterests.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display confirmation message
            MessageBox.Show("Student information submitted successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear all fields after submission
            ClearAllFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtIdNumber.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtHomeAddress.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            txtDateOfBirth.Clear();
            txtAge.Clear();
            txtPhoneNumber.Clear();
            txtParentContact.Clear();
            txtSkillsInterests.Clear();
        }
    }
}
