using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MidtermActivity2
{
    public partial class Form1 : Form
    {
        // Dictionary to store the rules
        private Dictionary<int, string> labRules = new Dictionary<int, string>
        {
            {1, "Maintain silence, proper decorum, and discipline inside the laboratory. Mobile phones, walkmans, and other personal pieces of equipment must be switched off."},
            {2, "Games are not allowed inside the lab. This includes computer-related games, card games, and other games that may disturb the operation of the lab."},
            {3, "Surfing the Internet is allowed only with the permission of the instructor. Downloading and installing of software are strictly prohibited."},
            {4, "Getting access to other websites not related to the course (especially pornographic and illicit sites) is strictly prohibited."},
            {5, "Deleting computer files and changing the set-up of the computer is a major offense."},
            {6, "Observe computer time usage carefully. A fifteen-minute allowance is given for each use. Otherwise, the unit will be given to those who wish to 'sit-in'."},
            {7, "Observe proper decorum while inside the laboratory.\n\ta. Do not get inside the lab unless the instructor is present.\n\tb. All bags, knapsacks, and the likes must be deposited at the counter.\n\tc. Follow the seating arrangement of your instructor.\n\td. At the end of class, all software programs must be closed.\n\te. Return all chairs to their proper places after using."},
            {8, "Chewing gum, eating, drinking, smoking, and other forms of vandalism are prohibited inside the lab."},
            {9, "Anyone causing a continual disturbance will be asked to leave the lab. Acts or gestures offensive to the members of the community, including public display of physical intimacy, are not tolerated."},
            {10, "Persons exhibiting hostile or threatening behavior such as yelling, swearing, or disregarding requests made by lab personnel will be asked to leave the lab."},
            {11, "For serious offense, the lab personnel may call the Civil Security Office (CSU) for assistance."},
            {12, "Any technical problem or difficulty must be addressed to the laboratory supervisor, student assistant, or instructor immediately."}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form load should not contain logic for rule search
            this.Text = "Laboratory Rules and Regulations";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRuleNumber.Text, out int ruleNumber) && labRules.ContainsKey(ruleNumber))
            {
                txtRuleDisplay.Text = $"Rule {ruleNumber}:\r\n\r\n{labRules[ruleNumber]}";
            }
            else
            {
                txtRuleDisplay.Text = "Please enter a valid rule number between 1 and 12.";
                txtRuleNumber.SelectAll();
                txtRuleNumber.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRuleNumber.Clear();
            txtRuleDisplay.Clear();
            txtRuleNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
