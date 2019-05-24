using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace testApi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            try
            {
                teamJson = downloader.DownloadString("http://localhost/7/project-fifa-php/teamsAPI.php");
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("oeps... er is iets mis gegaan");
                return;
            }

            Team[] team = JsonConvert.DeserializeObject<Team[]>(teamJson);

            for (int i = 0; i < team.Length; i++)
            {
                listBox1.Items.Add(team[i].Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            try
            {
                teamJson = downloader.DownloadString("http://localhost/7/project-fifa-php//matchesApi.php");
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("oeps... er is iets mis gegaan");
                return;
            }

            Match[] match = JsonConvert.DeserializeObject<Match[]>(teamJson);

            for (int i = 0; i < match.Length; i++)
            {
                Team1ListBox.Items.Add(match[i].team1);
                Team2ListBox.Items.Add(match[i].team2);
                ScoreListBox.Items.Add(match[i].score1);
                ScoreListBox2.Items.Add(match[i].score2);
            }

        }

        private void GokkerButton_Click_1(object sender, EventArgs e)
        {
            GokkerListBox.Items.Add(GamblerTextbox.Text);
            Gambler[] testGamler = new Gambler[]
            {
                new Gambler(GokkerListBox.Text, 1000)
            };

            GokkerListBox.Text = JsonConvert.SerializeObject(testGamler);
        }

        private void BetButton_Click(object sender, EventArgs e)
        {

            if (CheatTextBox.Text == "GeenG31d")
            {
                MessageBox.Show("de cheat code is actief");

            }
            else 
            {
                Match match;
            }
        }
    }
}