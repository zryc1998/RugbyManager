using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using AddTeam;
using AddPlayer;
using PlayersList;
using System.Text.RegularExpressions;
using Charts;
using System.Reflection;

namespace RugbyManager
{
    public partial class MainForm : Form
    {
        //Store teams and players info to lists
        private List<Team> allTeams;
        private List<Player> allPlayers;

        //Geters and setters for List<Team> and List<Player>
        public List<Team> AllTeams
        {
            get { return allTeams; }
            set { allTeams = value; }
        }
        public List<Player> AllPlayers
        {
            get { return allPlayers; }
            set { allPlayers = value; }
        }

        //MainForm starts here
        public MainForm()
        {
            allTeams = new List<Team>();
            allPlayers = new List<Player>();
            InitializeComponent();
            UpdateLogo(allTeams.Count);
        }

        //Updatelogo display after manually input team
        public void UpdateLogo(int count)
        {
            if (count == 0)
                logoBox.Image = Properties.Resources.caution;
            else logoBox.Image = ChangeLogo(allTeams[count - 1].Name);
        }

        //Open and import player info from file
        private void ImportPlayerFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open Player Text File";
                openFile.Filter = "TXT files|*.txt";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = File.Open(openFile.FileName, FileMode.Open);
                    StreamReader reader = new StreamReader(file);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine();
                        if (!CheckDuplicatedName(line)) allPlayers.Add(AddToPlayer(line));
                    }
                    reader.Close();
                }

            }
            catch
            {
                MessageBox.Show("Error: Could not load file.\n" +
                    "Please check manual\n" +
                    "to see correct format.", "Wrong Content Format",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Add player to player class
        private Player AddToPlayer(string line)
        {
            string[] token = (line.Split(';'));
            Player player;
            if (token.Length == 8)
            {
                player = new Player(token[0], token[1].TrimStart(), token[2].TrimStart(),
                    Convert.ToDateTime(token[3]), Convert.ToInt32(token[4]),
                    Convert.ToInt32(token[5]), token[6].TrimStart(), token[7].TrimStart());
                player.TeamName = token[7].TrimStart();
            }

            else if (token.Length == 7)
            {
                player = new Player(token[0], token[1].TrimStart(), token[2].TrimStart(),
                    Convert.ToDateTime(token[3]), Convert.ToInt32(token[4]),
                    Convert.ToInt32(token[5]), token[6].TrimStart(), "");
                player.TeamName = "Not Enrolled";
            }

            else throw new FileLoadException();

            for (int i = 0; i < allPlayers.Count; i++)
            {
                if (token[0] == allPlayers[i].ID) throw new FormatException(token[0]);
            }
            UpdatePlayerList(player);

            return player;
        }

        //Add player to player viewlist
        public void UpdatePlayerList(Player player)
        {
            ListViewItem item = new ListViewItem(new[] { player.ID, player.FirstName + " " + player.LastName,
                Convert.ToString(player.BirthDate.ToShortDateString()), Convert.ToString(player.Height),
                Convert.ToString(player.Weight), player.BirthPlace, player.TeamName });
            playerSpreadsheet.Items.Add(item);
        }

        //Import team info from file
        private void ImportTeamFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open Team Text File";
                openFile.Filter = "TXT files|*.txt";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = File.Open(openFile.FileName, FileMode.Open);
                    StreamReader reader = new StreamReader(file);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine();
                        if (!CheckDuplicatedName(line) && !PlayerTeamDetailsLabel(line)) allTeams.Add(AddToTeam(line));
                        if (allTeams.Count > 0)
                            logoBox.Image = Properties.Resources.nrlteams;

                    }
                    reader.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error: Could not load file.\n" +
                    "Please check the manual\n" +
                    "to see correct format.", "Wrong Content Format",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool PlayerTeamDetailsLabel(string line)
        {
            if (line.ToCharArray().Length >= 3)
            {
                char[] characters = { line.ToCharArray()[0], line.ToCharArray()[1], line.ToCharArray()[2] };
                string firstTreeChar = new string(characters);
                if (firstTreeChar == "Sig"
                    || firstTreeChar == "ID:"
                    || firstTreeChar == "---"
                    || firstTreeChar == "   ") return true;
            }
            if (line.ToCharArray().Length == 0) return true;
            return false;
        }
    

        //Check Duplication of ID and Team name;
        private bool CheckDuplicatedName(string line)
        {
            string[] token = (line.Split(';'));
            if (Regex.IsMatch(token[0], @"^\d+$"))
            {
                for (int i = 0; i < allPlayers.Count; i++)
                {
                    if (allPlayers[i].ID == token[0]) return true;
                }
            }
            else
            {
                for (int i = 0; i < allTeams.Count; i++)
                {
                    if (allTeams[i].Name == token[0]) return true;
                }
            }
            return false;
        }

        //Add team to team class
        private Team AddToTeam(string line)
        {
            string[] token = (line.Split(';'));
            int year = 0;
            if (token.Length != 5  ) 
                throw new FileLoadException();
            string yearText = string.Empty;
            for (int i = 0; i < token[3].Length; i++)
            {
                if (Char.IsDigit(token[3][i]))
                    yearText += token[3][i];
            }
            if (yearText.Length > 0)
               year = int.Parse(yearText);
            Team team = new Team(token[0], token[1].TrimStart(), token[2].TrimStart(), year, token[4].TrimStart());
            UpdateTeamList(team);
            return team;
        }

        //Add team to team viewlist
        private void UpdateTeamList(Team team)
        {
            ListViewItem item = new ListViewItem(new[] 
            { team.Name, team.Ground, team.Coach, Convert.ToString(team.YearFounded), team.Region });
            teamSpreadsheet.Items.Add(item);
        }

        //Save player info to file
        private void ExportPlayerToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportPlayerToFile();
           
        }
        private void ExportPlayerToFile()
        {
            SaveFileDialog save = new SaveFileDialog
            {
                FileName = "PlayersSaved.txt",
                Filter = "Text File | *.txt"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Create(save.FileName);
                StreamWriter writer = new StreamWriter(file);

                for (int i = 0; i < allPlayers.Count; i++)
                {
                    writer.WriteLine(allPlayers[i].SavePlayer());
                }
                writer.Close();
            }
        }

        //Save team into to file
        private void ExportTeamToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTeamToFile();
        }
        private void ExportTeamToFile()
        {
            SaveFileDialog save = new SaveFileDialog
            {
                FileName = "TeamsSaved.txt",
                Filter = "Text File | *.txt"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Create(save.FileName);
                StreamWriter writer = new StreamWriter(file);
                for (int i = 0; i < allTeams.Count; i++)
                {
                    writer.WriteLine(allTeams[i].SaveTeam());
                }
                writer.Close();
            }
        }

        //Set event for clicking add player pop up form
        private void TrigerAddPlayerButton_Click(object sender, EventArgs e)
        {
            int count = allPlayers.Count;
            AddPlayer.AddPlayer addPlayer = new AddPlayer.AddPlayer(this);
            addPlayer.ShowDialog();
            if (allPlayers.Count != count) UpdatePlayerList(allPlayers[count]);
        }


        //Delete unenrolled player form team
        private void UnenrolledPlayer(Player player)
        {
            for (int i = 0; i < allTeams.Count; i++)
            {
                if (allTeams[i].Name == player.TeamName)
                {
                    allTeams[i].Players.Remove("ID: "+ 
                        player.ID + 
                        "    Name: " +
                        player.FirstName + 
                        " " + 
                        player.LastName);
                    teamSpreadsheet.Items[i] = new ListViewItem(new[] 
                    { allTeams[i].Name, allTeams[i].Ground, allTeams[i].Coach, 
                        Convert.ToString(allTeams[i].YearFounded), allTeams[i].Region 
                    });
                }
            }
        }

        //Add enrolled player to team
        private void EnrolledPlayer(int playerIndex, int teamIndex)
        {
            allTeams[teamIndex].Players.Add("ID: " + 
                allPlayers[playerIndex].ID + 
                "    Name: " + 
                allPlayers[playerIndex].FirstName + 
                " " + 
                allPlayers[playerIndex].LastName);
            allPlayers[playerIndex].TeamName = allTeams[teamIndex].Name;

            playerSpreadsheet.Items[playerIndex] = new ListViewItem(new[] 
            { 
                allPlayers[playerIndex].FirstName + " " + allPlayers[playerIndex].LastName, 
                allPlayers[playerIndex].TeamName 
            });

            playerSpreadsheet.Items[playerIndex] = new ListViewItem(new[] 
            { 
                allPlayers[playerIndex].ID, 
                allPlayers[playerIndex].FirstName + " " + allPlayers[playerIndex].LastName, 
                Convert.ToString(allPlayers[playerIndex].BirthDate.ToShortDateString()), 
                Convert.ToString(allPlayers[playerIndex].Height), 
                Convert.ToString(allPlayers[playerIndex].Weight), 
                allPlayers[playerIndex].BirthPlace, 
                allPlayers[playerIndex].TeamName 
            });

            teamSpreadsheet.Items[teamIndex] = new ListViewItem(new[] 
            { 
                allTeams[teamIndex].Name, 
                allTeams[teamIndex].Ground, 
                allTeams[teamIndex].Coach, 
                Convert.ToString(allTeams[teamIndex].YearFounded), 
                allTeams[teamIndex].Region 
            });
        }

        //
        private int enrollmentPlayerIndex;
        private void PlayerSpreadsheet_SelectedIndexChanged(object sender, EventArgs e)
        {

            EmptyTeamDetails();
            bool logoIsFound = false;
            for (int i = 0; i < allPlayers.Count; i++)
            {
                if (playerSpreadsheet.Items[i].Selected)
                {

                    for (int j = 0; j < allTeams.Count; j++)
                    {
                        if (allTeams[j].Name == allPlayers[i].TeamName)
                        {
                            FillTeamDetails(allTeams[j], allPlayers[i].TeamName);
                            logoIsFound = true;
                            break;
                        }
                    }
                    if (allPlayers[i].TeamName == "Not Enrolled")
                    {
                        logoBox.Image = ChangeLogo("Not Enrolled");
                        logoIsFound = true;
                        break;
                    }
                    if (ChangeLogo(allPlayers[i].TeamName) != Properties.Resources.warning)
                    {
                        logoBox.Image = ChangeLogo(allPlayers[i].TeamName);
                        logoIsFound = true;
                    }
                    if (!logoIsFound)
                    {
                        logoBox.Image = ChangeLogo("warning");
                        break;
                    }
                }
            }
            EnrollmentPlayerAction();
        }

        //Enrollment interaction on player side
        private void EnrollmentPlayerAction()
        {
            for (int i = 0; i < allPlayers.Count; i++)
            {
                if (playerSpreadsheet.Items[i].Selected)
                {
                    playerSelectedEnrollmentTextBox.Text = allPlayers[i].FirstName + " " + allPlayers[i].LastName;
                    playerSelectedEnrollmentTextBox1.Text = playerSelectedEnrollmentTextBox.Text + "'s";
                    previousTeamLogo.Image = ChangeLogo(allPlayers[i].TeamName);
                    enrollmentPlayerIndex = i;
                    break;
                }
            }
        }


        //Click 'Enroll' button to enroll selected player to selected team
        private int enrollmentTeamIndex;
        private void EnrollmentButton_Click_1(object sender, EventArgs e)
        {
            if (playerSelectedEnrollmentTextBox.Text != "" && teamSelectedEnrollmentTextBox.Text != "")
            {
                if (allPlayers[enrollmentPlayerIndex].TeamName != "")
                {
                    UnenrolledPlayer(allPlayers[enrollmentPlayerIndex]);
                }
                EnrolledPlayer(enrollmentPlayerIndex, enrollmentTeamIndex);
            }
        }

        //Enrollment interaction on team side
        private int playersListTeamIndex;
        private void TeamSpreadsheet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < allTeams.Count; i++)
            {
                if (teamSpreadsheet.Items[i].Selected)
                {
                    playersListTeamIndex = i;
                    teamSelectedEnrollmentTextBox.Text = allTeams[i].Name;
                    newlyEnrolledTeamLogo.Image = ChangeLogo(allTeams[i].Name); ;
                    enrollmentTeamIndex = i;
                    break;
                }
            }
        }

        //Set event for clicking button to pop up player list form
        private void TrigerPlayersListBtn_Click(object sender, EventArgs e)
        {
            if (allTeams.Count > 0)
            {
                PlayerList playersList = new PlayerList(this, allTeams[playersListTeamIndex]);
                playersList.ShowDialog();
            }
            else MessageBox.Show("Please Add Team(s) First",
                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Set event for clicking button to pop up charts form

        private void Charts_Click(object sender, EventArgs e)
        {
            if (AllPlayers.Count > 0)
            {
                Charts.Charts charts = new Charts.Charts(this);
                charts.ShowDialog();
            }
            else MessageBox.Show("Please Add Player(s) First",
                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Display team details of selected player
        private void FillTeamDetails(Team selected, string v)
        {
            playerTeamNameTextBox.Text = selected.Name;
            playerTeamCoachTextBox.Text = selected.Coach;
            playerTeamGroundTextBox.Text = selected.Ground;
            playerTeamYearFoundedTextBox.Text = Convert.ToString(selected.YearFounded);
            playerTeamRegionTextBox.Text = selected.Region;
            logoBox.Image = ChangeLogo(v);
        }

        //Clear team details display
        private void EmptyTeamDetails()
        {
            playerTeamNameTextBox.Text = "";
            playerTeamCoachTextBox.Text = "";
            playerTeamGroundTextBox.Text = "";
            playerTeamYearFoundedTextBox.Text = "";
            playerTeamRegionTextBox.Text = "";
            logoBox.Image = Properties.Resources.nrlteams;
        }

        //Match logos to team names
        public Image ChangeLogo(string name)
        {
            Image image;
            if (name == "Broncos")
                image = Properties.Resources.broncos;
            else if (name == "Raiders")
                image = Properties.Resources.raiders;
            else if (name == "Bulldogs")
                image = Properties.Resources.bulldogs;
            else if (name == "Sharks")
                image = Properties.Resources.sharks;
            else if (name == "Titans")
                image = Properties.Resources.titans;
            else if (name == "Sea Eagles")
                image = Properties.Resources.seaeagles;
            else if (name == "Storm")
                image = Properties.Resources.storm;
            else if (name == "Warriors")
                image = Properties.Resources.warriors;
            else if (name == "Knights")
                image = Properties.Resources.knights;
            else if (name == "Cowboys")
                image = Properties.Resources.cowboys;
            else if (name == "Eels")
                image = Properties.Resources.eels;
            else if (name == "Panthers")
                image = Properties.Resources.panthers;
            else if (name == "Rabbitohs")
                image = Properties.Resources.rabbitohs;
            else if (name == "St. George Illawarra Dragons")
                image = Properties.Resources.dragons;
            else if (name == "Roosters")
                image = Properties.Resources.roosters;
            else if (name == "Wests Tigers")
                image = Properties.Resources.tigers;
            else if (name == "Not Enrolled")
                image = Properties.Resources.notenrolled;
            else image = Properties.Resources.warning;
            return image;
        }


        //Set event for clicking button to pop up add team form
        private void TrigerAddTeamButton_Click_1(object sender, EventArgs e)
        {
            int count = allTeams.Count;
            AddTeam.AddTeam addTeam = new AddTeam.AddTeam(this);
            addTeam.ShowDialog();
            if (allTeams.Count != count) UpdateTeamList(allTeams[count]);
        }

        //Set event for clicking button to pop up add team form

        private void TrigerSearchbtn_Click(object sender, EventArgs e)
        {
            Search.Search search = new Search.Search(this);
            search.ShowDialog();
        }

        //Clear players
        private void ClearPlayerBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please Save Before\n" +
                "Clearing All Infromation", 
                "Save File",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //save before clear
                ExportPlayerToFile();
                allPlayers.Clear();
                playerSpreadsheet.Items.Clear();
                EmptyTeamDetails();
                previousTeamLogo.Image = null;

            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("You Will Loose All Unsaved Changes\n" +
                    "Contiue?",
                    "Save File",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    allPlayers.Clear();
                    playerSpreadsheet.Items.Clear();
                    EmptyTeamDetails();
                    previousTeamLogo.Image = null;
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    //save before clear
                    ExportPlayerToFile();
                    allPlayers.Clear();
                    playerSpreadsheet.Items.Clear();
                    EmptyTeamDetails();
                    previousTeamLogo.Image = null;
                }
            }
        }

        //Clear teams
        private void ClearTeamBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Please Save Before\n" +
                "Clearing All Infromation",
                "Save File",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //save before clear
                ExportPlayerToFile();
                AllTeams.Clear();
                teamSpreadsheet.Items.Clear();
                newlyEnrolledTeamLogo.Image = null;
                logoBox.Image = Properties.Resources.caution;
            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("You Will Loose All Unsaved Changes\n" +
                    "Contiue?",
                    "Save File",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    allTeams.Clear();
                    teamSpreadsheet.Items.Clear();
                    newlyEnrolledTeamLogo.Image = null;
                    logoBox.Image = Properties.Resources.caution;
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    //save before clear
                    ExportPlayerToFile();
                    allTeams.Clear();
                    teamSpreadsheet.Items.Clear();
                    newlyEnrolledTeamLogo.Image = null;
                    logoBox.Image = Properties.Resources.caution;
                }
            }
        }

        //Click 'User Manual' Menu item to open 'User Manual' pdf
        private void UserManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetFullPath("User_Manual_20008378.pdf");
                Console.WriteLine(path);
                PdfViewer pdfViewer = new PdfViewer(path);
                pdfViewer.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please make sure the PDF file stored in\n" +
                    ".../Ass3_20008378/RugbyManager/bin/Debug/User_Manual_20008378.pdf",
                    "File not found",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
