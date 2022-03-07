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

namespace PlayersList
{
    public partial class PlayerList : Form
    {

        private MainForm mainForm;
        public PlayerList(MainForm form, Team selected)
        {
            InitializeComponent();
            this.mainForm = form;
            DisplayTeamInfo(selected);
            GeneratePlayerList(selected);
        }

        //Search for enrolled players
        private void GeneratePlayerList(Team selected)
        {
            int num = 0;
            for (int j = 0; j < mainForm.AllPlayers.Count; j++)
            {
                if (mainForm.AllPlayers[j].TeamName == selected.Name)
                {
                    num++;
                    ListViewItem item = new ListViewItem(new[]
                    { mainForm.AllPlayers[j].ID,
                        mainForm.AllPlayers[j].FirstName + " " + mainForm.AllPlayers[j].LastName,
                        Convert.ToString(mainForm.AllPlayers[j].BirthDate.ToShortDateString()),
                        Convert.ToString(mainForm.AllPlayers[j].Height),
                        Convert.ToString(mainForm.AllPlayers[j].Weight),
                        mainForm.AllPlayers[j].BirthPlace
                    });
                    teamPlayersSpreadsheet.Items.Add(item);
                }
            }
            numberOfPlayers.Text = Convert.ToString(num);
        }

        //Display enrolled team's details
        private void DisplayTeamInfo(Team selected)
        {
            this.Text = selected.Name + "' Players List";
            playersListLogo.Image = mainForm.ChangeLogo(selected.Name);
            playersListTeamName.Text = selected.Name;
            playersListGroundTextBox.Text = selected.Ground;
            playersListCoachTextBox.Text = selected.Coach;
            playersListRegionTextBox.Text = selected.Region;
            playersListYearFoundedTextBox.Text = Convert.ToString(selected.YearFounded);
        }
    }
}
