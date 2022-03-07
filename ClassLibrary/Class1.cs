using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class Player
    {
        //Fields of txt file's players' personal info
        private string playerID;
        private string playerFirstName;
        private string playerLastName;
        private DateTime playerBirthDate; //Read in birth date as in dd/MM/yyyy format
        private int playerHeight;
        private int playerWeight;
        private string playerBirthPlace;

        //Additional fields required by methods
        private int playerAge;
        private string teamSigned;

        //Constructor
        public Player(string id, string firstName, string lastName, DateTime birthDate, int height, int weight, string birthplace, string team)
        {
            playerID = id;
            playerFirstName = firstName;
            playerLastName = lastName;
            playerBirthDate = birthDate;
            playerHeight = height;
            playerWeight = weight;
            playerBirthPlace = birthplace;
            playerAge = CalculateAge();
        }

        //A method to calculate player's Age
        private int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - playerBirthDate.Year;
            if (playerBirthDate > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        //Getters and setters for player class
        public string ID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string FirstName
        {
            get { return playerFirstName; }
            set { playerFirstName = value; }
        }

        public string LastName
        {
            get { return playerLastName; }
            set { playerLastName = value; }
        }

        public DateTime BirthDate
        {
            get { return playerBirthDate; }
            set { playerBirthDate = value; }
        }

        public int Age
        {
            get { return playerAge; }
        }

        public int Height
        {
            get { return playerHeight; }
            set { playerHeight = value; }
        }

        public int Weight
        {
            get { return playerWeight; }
            set { playerWeight = value; }
        }

        public string BirthPlace
        {
            get { return playerBirthPlace; }
            set { playerBirthPlace = value; }
        }

        public string TeamName
        {
            get { return teamSigned; }
            set { teamSigned = value; }
        }

        //A method to prepare player information when export
        public string SavePlayer()
        {
            string playerInfo;
            playerInfo = playerID + "; " 
                + playerFirstName + "; " 
                + playerLastName + "; "
                + playerBirthDate.ToString("dd/MM/yyyy") + "; " 
                + playerHeight + "; " 
                + playerWeight + "; " 
                + playerBirthPlace;
            if (teamSigned != null && teamSigned != "Not Enrolled")
            {
                playerInfo = playerInfo + "; " + teamSigned;
            }
            return playerInfo;
        }

    }
    public class Team
    {
        //Fields of txt file's players' personal info
        private string teamName;           
        private string teamGround;         
        private string teamCoach;          
        private int teamYearFounded;       
        private string teamRegion;
        private List<string> teamPlayers;  // Store signed players to a List


        //Constructor
        public Team(string name, string ground, string coach, int yearFounded, string region)
        {
            teamName = name;
            teamGround = ground;
            teamCoach = coach;
            teamYearFounded = yearFounded;
            teamRegion = region;
            teamPlayers = new List<string>();
        }



        //Getters and Setters for team class
        public string Name
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public string Ground
        {
            get { return teamGround; }
            set { teamGround = value; }
        }

        public string Coach
        {
            get { return teamCoach; }
            set { teamCoach = value; }
        }

        public int YearFounded
        {
            get { return teamYearFounded; }
            set { teamYearFounded = value; }
        }

        public string Region
        {
            get { return teamRegion; }
            set { teamRegion = value; }
        }

        public List<string> Players
        {
            get { return teamPlayers; }
            set { teamPlayers = value; }
        }

        //A method to prepare team information when export
        public string SaveTeam()
        {
            string teamInfo;
            teamInfo = teamName + "; "
                + teamGround + "; "
                + teamCoach + "; "
                + teamYearFounded + "; "
                + teamRegion
                + FindAllSignedPlayer() + "\n"
                + "--------------------------------------\n";
            return teamInfo;
        }

        //Sort signed players
        private string FindAllSignedPlayer()
        {
            string playerList = "";
            if (Players.Count == 0) return playerList;
            for (int i = 0; i < Players.Count; i++)
            {
                playerList = String.Join("\n", Players.ToArray());
            }
            return "\nSigned Players: \n" + playerList;
        }
    }
}
