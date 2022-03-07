using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using RugbyManager;

namespace AddTeam
{
    public partial class AddTeam : Form
    {
        private MainForm mainForm;
        public AddTeam(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;

            //Setup hints for certain texboxes
            addTeamYearFounded.ForeColor = SystemColors.ScrollBar;
            addTeamYearFounded.Text = "Numbers Only, Format: yyyy";
            this.addTeamYearFounded.Leave += new EventHandler(this.AddTeamYearFounded_Leave);
            this.addTeamYearFounded.Enter += new EventHandler(this.AddTeamYearFounded_Enter);
        }

        //Make sure all input's first letter is uppercase
        //ref:https://www.dotnetperls.com/uppercase-first-letter
        private string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        //Manually add new team
        private void AddTeamButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CorrectTeamName() && CorrectGround() &&
                  CorrectYearFounded() && CorrectCoach() && CorrectRegion())
                {
                    Team newTeam = new Team(UppercaseWords(addTeamName.Text),
                        UppercaseWords(addTeamGround.Text),
                        UppercaseWords(addTeamCoach.Text),
                        Convert.ToInt32(addTeamYearFounded.Text),
                        UppercaseWords(addTeamRegion.Text));
                    mainForm.AllTeams.Add(newTeam);
                    mainForm.UpdateLogo(mainForm.AllTeams.Count);
                    ActiveForm.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please follow the hint\n" +
                    "or read the manual",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Team's name input validation
        private bool CorrectTeamName()
        {
            for (int i = 0; i < mainForm.AllTeams.Count; i++)
            {
                if (mainForm.AllTeams[i].Name == UppercaseWords(addTeamName.Text))
                {
                    MessageBox.Show("Team Name: " + addTeamName.Text +
                        " Is Existed",
                        "Duplicated Team Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (IsEmpty(addTeamName.Text, "Team Name")) return false;
            if (TooManyCharacters(addTeamName.Text, "Team Name")) return false;
            if (NonAlphabetCharacter(addTeamName.Text, "Team Name")) return false;
            return true;
        }

        //Non-Numeric Input validation
        private bool NotNumeric(string text)
        {
            if (Regex.IsMatch(text, "^[0-9]*$")) return false;
            MessageBox.Show("Please Input Digit(0-9) Only!",
                "Non-Digit Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //Input validation for textbox not allewed to be empty
        private bool IsEmpty(string text, string v)
        {
            if (text == "")
            {
                MessageBox.Show(v + " can not be empty!",
                    "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //Non-Alphabetical input validation
        private bool NonAlphabetCharacter(string text, string v)
        {

            if (Regex.IsMatch(text, "^[a-zA-Z. ]*$")) return false;
            MessageBox.Show(v + " Must Be Alphabetical Charaters",
                "Non-Aphabetical Charater", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //Characters count validation (not more than 35)
        private bool TooManyCharacters(string name, string v)
        {
            if (name.Count() > 35) // world record longest name
            {
                MessageBox.Show(v + " Must Be Less Than 35 Characters",
                    "Too Many Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //Ground input validation
        private bool CorrectGround()
        {
            if (IsEmpty(addTeamGround.Text, "Ground")) return false;
            if (TooManyCharacters(addTeamGround.Text, "Ground")) return false;
            if (NonAlphabetCharacter(addTeamGround.Text, "Ground")) return false;
            return true;
        }

        //Year founded input validation
        private bool CorrectYearFounded()
        {
            if (IsEmpty(addTeamYearFounded.Text, "Year Founded")) return false;
            if (NotNumeric(addTeamYearFounded.Text)) return false;
            return true;
        }

        //Coach input validation
        private bool CorrectCoach()
        {
            if (IsEmpty(addTeamCoach.Text, "Coach")) return false;
            if (TooManyCharacters(addTeamCoach.Text, "Coach")) return false;
            if (NonAlphabetCharacter(addTeamCoach.Text, "Coach")) return false;
            return true;
        }

        //Team input validation
        private bool CorrectRegion()
        {
            if (IsEmpty(addTeamRegion.Text, "Region")) return false;
            if (WrongRegionFormat(addTeamRegion.Text)) return false;
            return true;
        }

        //Check region input format
        private bool WrongRegionFormat(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z -]*$")) return false;
            MessageBox.Show("Region Must be Alphabetical Charaters\n" +
                "With Only Space or dash",
                "Incorrect Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }


        //Mouse move events for text boxes' hints
        private void AddTeamYearFounded_Enter(object sender, EventArgs e)
        {
            if (addTeamYearFounded.Text == "Numbers Only, Format: yyyy")
            {
                addTeamYearFounded.Text = "";
                addTeamYearFounded.ForeColor = SystemColors.WindowText;
            }
        }
        private void AddTeamYearFounded_Leave(object sender, EventArgs e)
        {
            if (addTeamYearFounded.Text.Length == 0)
            {
                addTeamYearFounded.Text = "Numbers Only, Format: yyyy";
                addTeamYearFounded.ForeColor = SystemColors.ScrollBar;
            }
        }

    }
}