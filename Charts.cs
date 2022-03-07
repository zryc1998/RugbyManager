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

namespace Charts
{
    public partial class Charts : Form
    {
        private MainForm mainForm;

        //This LINQ list is setup for age chart
        private Dictionary<string, int> ageCount;

        public Charts(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
            ageCount = new Dictionary<string, int>
            {
                {"10-20", 0}, // Signed player to different Age group
                {"20-30", 0},
                {"30-40", 0},
                {"40-50", 0},
                {"50+", 0},
            };
            GetDataForAgeChart();
        }

        //Get data for age histogram
        public void GetDataForAgeChart()
        {
            for (int i = 0; i < mainForm.AllPlayers.Count; i++)
            {
                Player player = mainForm.AllPlayers[i];

                //Use player value to get data for H&W chart
                GetDataForHeightAndWeightChart(player);
                if (player.Age < 20) ageCount["10-20"]++;
                else if (player.Age < 30) ageCount["20-30"]++;
                else if (player.Age < 40) ageCount["30-40"]++;
                else if (player.Age < 50) ageCount["40-50"]++;
                else ageCount["50+"]++;
                GenerateAgeChart(ageCount);
            }
        }

        //Generate age histogram
        private void GenerateAgeChart(Dictionary<string, int> ageCount)
        {
            ageGroup.Series.Clear();
            ageGroup.Series.Add("Age");
            ageGroup.Series["Age"].Points.AddXY("10-20", ageCount["10-20"]);
            ageGroup.Series["Age"].Points.AddXY("20-30", ageCount["20-30"]);
            ageGroup.Series["Age"].Points.AddXY("30-40", ageCount["30-40"]);
            ageGroup.Series["Age"].Points.AddXY("40-50", ageCount["40-50"]);
            ageGroup.Series["Age"].Points.AddXY("50+", ageCount["50+"]);
        }

        //Generate H&W chart
        private void GetDataForHeightAndWeightChart(Player player)
        {
            heightAndWeight.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            heightAndWeight.Series["Height"].Points.AddXY(player.FirstName[0] + " " + player.LastName, player.Height);
            heightAndWeight.Series["Weight"].Points.AddXY(player.FirstName[0] + " " + player.LastName, player.Weight);
        }
    }
}
