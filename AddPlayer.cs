using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RugbyManager;
using ClassLibrary;
using System.Text.RegularExpressions;


//Pop up From to add new player
namespace AddPlayer
{
    public partial class AddPlayer : Form
    {
        private MainForm mainFrom;
        public AddPlayer(MainForm form)
        {
            InitializeComponent();
            this.mainFrom = form;

            //Setup hints for certain texboxes
            addPlayerTeam.ForeColor = SystemColors.ScrollBar;
            addPlayerTeam.Text = "If Enrolled";
            this.addPlayerTeam.Leave += new EventHandler(this.AddPlayerTeam_Leave);
            this.addPlayerTeam.Enter += new EventHandler(this.AddPlayerTeam_Enter);

            addPlayerBirthDateD.ForeColor = SystemColors.ScrollBar;
            addPlayerBirthDateD.Text = "DD";
            this.addPlayerBirthDateD.Leave += new EventHandler(this.AddPlayerBirthDateD_Leave);
            this.addPlayerBirthDateD.Enter += new EventHandler(this.AddPlayerBirthDateD_Enter);

            addPlayerBirthDateM.ForeColor = SystemColors.ScrollBar;
            addPlayerBirthDateM.Text = "MM";
            this.addPlayerBirthDateM.Leave += new EventHandler(this.AddPlayerBirthDateM_Leave);
            this.addPlayerBirthDateM.Enter += new EventHandler(this.AddPlayerBirthDateM_Enter);

            addPlayerBirthDateY.ForeColor = SystemColors.ScrollBar;
            addPlayerBirthDateY.Text = "YYYY";
            this.addPlayerBirthDateY.Leave += new EventHandler(this.AddPlayerBirthDateY_Leave);
            this.addPlayerBirthDateY.Enter += new EventHandler(this.AddPlayerBirthDateY_Enter);

            addPlayerID.ForeColor = SystemColors.ScrollBar;
            addPlayerID.Text = "Numbers Only";
            this.addPlayerID.Leave += new EventHandler(this.AddPlayerID_Leave);
            this.addPlayerID.Enter += new EventHandler(this.AddPlayerID_Enter);

            addPlayerHeight.ForeColor = SystemColors.ScrollBar;
            addPlayerHeight.Text = "Numbers Only";
            this.addPlayerHeight.Leave += new EventHandler(this.AddPlayerHeight_Leave);
            this.addPlayerHeight.Enter += new EventHandler(this.AddPlayerHeight_Enter);

            addPlayerWeight.ForeColor = SystemColors.ScrollBar;
            addPlayerWeight.Text = "Numbers Only";
            this.addPlayerWeight.Leave += new EventHandler(this.AddPlayerWeight_Leave);
            this.addPlayerWeight.Enter += new EventHandler(this.AddPlayerWeight_Enter);

        }

        //Make sure all input's first letter is uppercase
        //ref:https://www.dotnetperls.com/uppercase-first-letter
        public string UppercaseWords(string value)
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

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CorrectID() && CorrectName() && CorrectBirthDate() && CorrectHeight() &&
                  CorrectWeight() && CorrectBirthPlace() && CorrectTeam())
                {
                    DateTime birthDate = Convert.ToDateTime(
                        addPlayerBirthDateD.Text + "/" +
                        addPlayerBirthDateM.Text + "/" +
                        addPlayerBirthDateY.Text);

                    if (addPlayerTeam.Text == "If Enrolled")
                        addPlayerTeam.Text = "Not Enrolled";

                        Player newPlayer = new Player(addPlayerID.Text,
                        UppercaseWords(addPlayerFirstName.Text),
                        UppercaseWords(addPlayerLastName.Text),
                        birthDate,
                        Convert.ToInt32(addPlayerHeight.Text),
                        Convert.ToInt32(addPlayerWeight.Text),
                        UppercaseWords(addPlayerBirthPlace.Text),
                        UppercaseWords(addPlayerTeam.Text));
                        newPlayer.TeamName = UppercaseWords(addPlayerTeam.Text);
                    mainFrom.AllPlayers.Add(newPlayer);

                    for (int i = 0; i < mainFrom.AllTeams.Count; i++)
                    {
                        if (mainFrom.AllTeams[i].Name == addPlayerTeam.Text)
                        {
                            mainFrom.AllTeams[i].Players.Add(addPlayerFirstName.Text + " " + addPlayerLastName.Text);
                            break;
                        }
                    }
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

        //ID input validation
        private bool CorrectID()
        {
            if (IsEmpty(addPlayerID.Text, "ID")) return false;
            if (NotNumeric(addPlayerID.Text, "ID")) return false;
            for (int i = 0; i < mainFrom.AllPlayers.Count; i++)
            {
                if (mainFrom.AllPlayers[i].ID == addPlayerID.Text)
                {
                    MessageBox.Show("ID " + mainFrom.AllPlayers[i].ID + 
                        " Is Existed", 
                        "Duplicated ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        //Non-Numeric Input validation
        public bool NotNumeric(string text, string v)
        {
            if (Regex.IsMatch(text, "^[0-9]*$")) return false;
            MessageBox.Show("Please Input Digit(0-9) Only!",
                "Non-Digit Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //Input validation for textbox not allewed to be empty
        public bool IsEmpty(string text, string v)
        {
            if (text == "")
            {
                MessageBox.Show(v + " can not be empty!", 
                    "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //Player's name input validation
        private bool CorrectName()
        {
            if (IsEmpty(addPlayerFirstName.Text, "Last Name") || IsEmpty(addPlayerLastName.Text, "First Name")) return false;
            string name = addPlayerFirstName.Text + " " + addPlayerLastName.Text;
            if (TooManyCharacters(name, "Name")) return false;
            if (NonAlphabetCharacter(addPlayerFirstName.Text, "Name")) return false;
            return true;
        }

        //Non-Alphabetical input validation
        private bool NonAlphabetCharacter(string text, string v)
        {

            if (Regex.IsMatch(text, "^[a-zA-Z]*$")) return false;
            MessageBox.Show(v + " Must Be Alphabetical Charaters",
                "Non-Aphabetical Charater", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //Characters count validation (not more than 35)
        public bool TooManyCharacters(string name, string v)
        {
            if (name.Count() > 35) // world record longest name
            {
                MessageBox.Show(v + " Must Be Less Than 35 Characters", 
                    "Too Many Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //Height input validation
        private bool CorrectHeight()
        {
            if (IsEmpty(addPlayerHeight.Text, "Height")) return false;
            if (NotNumeric(addPlayerHeight.Text, "Height")) return false;
            return true;
        }

        //Weight input validation
        private bool CorrectWeight()
        {
            if (IsEmpty(addPlayerWeight.Text, "Weight")) return false;
            if (NotNumeric(addPlayerWeight.Text, "Weight")) return false;
            return true;
        }

        //Birth place input validation
        private bool CorrectBirthPlace()
        {
            if (IsEmpty(addPlayerBirthPlace.Text, "Birth Place")) return false;
            if (TooManyCharacters(addPlayerBirthPlace.Text, "Birth Place")) return false;
            if (WrongBirthPlaceFormat(addPlayerBirthPlace.Text, "Birth place")) return false;
            return true;
        }
        
        //Check birth place input format
        public bool WrongBirthPlaceFormat(string text, string v)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z, ]*$")) return false;
            MessageBox.Show(v + " Must be Alphabetical Charaters\n" +
                "With Only Space And Comma!",
                "Incorrect Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        //Team input validation
        private bool CorrectTeam()
        {
            if (mainFrom.AllTeams.Count == 0 && addPlayerTeam.Text != "" && addPlayerTeam.Text != "If Enrolled")
            {
                MessageBox.Show("Team Database Is Currently Empty\n" +
                "Please Make Sure\n" +
                "All Current Teams Entered!",
                "Team Database Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (addPlayerTeam.Text == "If Enrolled" || addPlayerTeam.Text == "") return true;
            for (int i = 0; i < mainFrom.AllTeams.Count; i++)
            {
                if (mainFrom.AllTeams[i].Name == UppercaseWords(addPlayerTeam.Text))
                {
                    return true;
                }
            }
            MessageBox.Show("Team entered does not exist\n" +
                "Enter existed Team or leave it empty", 
                "Non-Existed Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        //Birth date input vlidation
        private bool CorrectBirthDate()
        {
            if (IsEmpty(addPlayerBirthDateD.Text, "Birth Date") || 
                IsEmpty(addPlayerBirthDateM.Text, "Birth Date") || 
                IsEmpty(addPlayerBirthDateY.Text, "Birth Date"))
                return false;

            if (NotNumeric(addPlayerBirthDateD.Text, "Birth Date") ||
                NotNumeric(addPlayerBirthDateM.Text, "Birth Date") ||
                NotNumeric(addPlayerBirthDateY.Text, "Birth Date"))
                return false;

            if (ValidCalender()) return false;
            return true;
        }

        //The following 3 methods for date validation
        private bool ValidCalender()
        {
            int day = Convert.ToInt32(addPlayerBirthDateD.Text);
            int month = Convert.ToInt32(addPlayerBirthDateM.Text);
            int year = Convert.ToInt32(addPlayerBirthDateY.Text);
            switch (month)
            {
                case 2:
                    if (IsLeapyear(year))
                    {
                        if (day > 29)
                        {
                            InvalidCalenderDate("day");
                            return true;
                        }
                    }
                    else
                    {
                        if (day > 28)
                        {
                            InvalidCalenderDate("day");
                            return true;
                        }
                    }
                    break;
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (day > 31)
                    {
                        InvalidCalenderDate("day");
                        return true;
                    }
                    break;
                case 4: case 6: case 9: case 11:
                    if (day > 30)
                    {
                        InvalidCalenderDate("day");
                        return true;
                    }
                    break;
                default:
                    InvalidCalenderDate("month");
                    return true;
            }
            if (year > DateTime.Now.Year)
            {
                MessageBox.Show("Input is Larger than " + DateTime.Now.Year +"!", 
                    "Invalid Year Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private bool IsLeapyear(int year)
        {
            if (year % 400 == 0) return true;
            else if (year % 100 == 0) return true;
            else if (year % 4 == 0) return true;
            return false;
        }
        private void InvalidCalenderDate(string v)
        {
            MessageBox.Show( v + " Is Invalid\n" +
                "Please Check Calender!", 
                "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Mous move events for text boxes' hints
        private void AddPlayerWeight_Enter(object sender, EventArgs e)
        {
            if (addPlayerWeight.Text == "Numbers Only")
            {
                addPlayerWeight.Text = "";
                addPlayerWeight.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerWeight_Leave(object sender, EventArgs e)
        {
            if (addPlayerWeight.Text.Length == 0)
            {
                addPlayerWeight.Text = "Numbers Only";
                addPlayerWeight.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerHeight_Enter(object sender, EventArgs e)
        {
            if (addPlayerHeight.Text == "Numbers Only")
            {
                addPlayerHeight.Text = "";
                addPlayerHeight.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerHeight_Leave(object sender, EventArgs e)
        {
            if (addPlayerHeight.Text.Length == 0)
            {
                addPlayerHeight.Text = "Numbers Only";
                addPlayerHeight.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerID_Enter(object sender, EventArgs e)
        {
            if (addPlayerID.Text == "Numbers Only")
            {
                addPlayerID.Text = "";
                addPlayerID.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerID_Leave(object sender, EventArgs e)
        {
            if (addPlayerID.Text.Length == 0)
            {
                addPlayerID.Text = "Numbers Only";
                addPlayerID.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerTeam_Leave(object sender, EventArgs e)
        {
            if (addPlayerTeam.Text.Length == 0)
            {
                addPlayerTeam.Text = "If Enrolled";
                addPlayerTeam.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerTeam_Enter(object sender, EventArgs e)
        {
            if (addPlayerTeam.Text == "If Enrolled")
            {
                addPlayerTeam.Text = "";
                addPlayerTeam.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerBirthDateD_Leave(object sender, EventArgs e)
        {
            if (addPlayerBirthDateD.Text.Length == 0)
            {
                addPlayerBirthDateD.Text = "DD";
                addPlayerBirthDateD.ForeColor = SystemColors.ScrollBar;
            }
        }
 
        private void AddPlayerBirthDateD_Enter(object sender, EventArgs e)
        {
            if (addPlayerBirthDateD.Text == "DD")
            {
                addPlayerBirthDateD.Text = "";
                addPlayerBirthDateD.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerBirthDateM_Leave(object sender, EventArgs e)
        {
            if (addPlayerBirthDateM.Text.Length == 0)
            {
                addPlayerBirthDateM.Text = "MM";
                addPlayerBirthDateM.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerBirthDateM_Enter(object sender, EventArgs e)
        {
            if (addPlayerBirthDateM.Text == "MM")
            {
                addPlayerBirthDateM.Text = "";
                addPlayerBirthDateM.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlayerBirthDateY_Leave(object sender, EventArgs e)
        {
            if (addPlayerBirthDateY.Text.Length == 0)
            {
                addPlayerBirthDateY.Text = "YYYY";
                addPlayerBirthDateY.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void AddPlayerBirthDateY_Enter(object sender, EventArgs e)
        {
            if (addPlayerBirthDateY.Text == "YYYY")
            {
                addPlayerBirthDateY.Text = "";
                addPlayerBirthDateY.ForeColor = SystemColors.WindowText;
            }
        }

    }
}
