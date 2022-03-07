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
using AddPlayer;
using RugbyManager;

namespace Search
{
    public partial class Search : Form
    {
        private MainForm mainForm;

        public Search(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        //Set event of clicking search button
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            //Use validation methods from 'AddPlayer'
            AddPlayer.AddPlayer validation = new AddPlayer.AddPlayer(mainForm);

            if (ageBtn.Checked && !validation.NotNumeric (searchTextBox.Text, "Age"))
            {
                SearchByAge();
            }
            if (placeBtn.Checked && !validation.WrongBirthPlaceFormat(searchTextBox.Text, "Birth Place"))
            {
                SearchByBirthPlace();
            }
        }

        //Search player by birth place
        private void SearchByBirthPlace()
        {
            searchPlayerSpreadsheet.Items.Clear();
            AddPlayer.AddPlayer uperCase = new AddPlayer.AddPlayer(mainForm);

            bool foundResult = false;
            for (int i = 0; i < mainForm.AllPlayers.Count; i++)
            {
                if (mainForm.AllPlayers[i].BirthPlace.Contains(uperCase.UppercaseWords(searchTextBox.Text)))
                {
                    ListViewItem item = new ListViewItem(new[]
                    { mainForm.AllPlayers[i].ID,
                        mainForm.AllPlayers[i].FirstName + " " + mainForm.AllPlayers[i].LastName,
                        Convert.ToString(mainForm.AllPlayers[i].BirthDate.ToShortDateString()),
                        Convert.ToString(mainForm.AllPlayers[i].Height),
                        Convert.ToString(mainForm.AllPlayers[i].Weight),
                        mainForm.AllPlayers[i].BirthPlace
                    });
                    searchPlayerSpreadsheet.Items.Add(item);
                    foundResult = true;
                }
            }
            if (!foundResult) MessageBox.Show("No Result Matched!",
                "Message");
        }

        //Search player by age
        private void SearchByAge()
        {
            searchPlayerSpreadsheet.Items.Clear();

            bool foundResult = false;
            for (int i = 0; i < mainForm.AllPlayers.Count; i++)
            {
                if (mainForm.AllPlayers[i].Age == Convert.ToInt32(searchTextBox.Text))
                {
                    ListViewItem item = new ListViewItem(new[]
                    { mainForm.AllPlayers[i].ID,
                        mainForm.AllPlayers[i].FirstName + " " + mainForm.AllPlayers[i].LastName,
                        Convert.ToString(mainForm.AllPlayers[i].BirthDate.ToShortDateString()),
                        Convert.ToString(mainForm.AllPlayers[i].Height),
                        Convert.ToString(mainForm.AllPlayers[i].Weight),
                        mainForm.AllPlayers[i].BirthPlace
                    });
                    searchPlayerSpreadsheet.Items.Add(item);
                    foundResult = true;
                }
            }
            if (!foundResult) MessageBox.Show("No Result Matched!",
                "Message");
        }

        //Age search input validation
        private bool IsNumeric(string text)
        {
            if (Regex.IsMatch(text, "^[0-9]*$")) return true;
            MessageBox.Show("Please Input Digit(0-9) Only!",
                "Non-Digit Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
