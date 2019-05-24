using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string SAVE_LOCATION = "saved-game.json";

        string fullSchedule;
        FetchSchedule fetchedSchedule;

        public Form1()
        {
            InitializeComponent();
            System.Net.WebClient client = new System.Net.WebClient();
            string read = client.DownloadString("http://simonnuijten.nl/bracket2.php");
            fetchedSchedule = JsonConvert.DeserializeObject<FetchSchedule>(read);
        }

        public void givedata() { }
        
        public void save()
        {
            Save save = new Save();
            save.name = Program.username;

            string saveJson = JsonConvert.SerializeObject(save);
            // Write the saved game to a text file
            File.WriteAllText(SAVE_LOCATION, saveJson);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            string team = "team";
            string response;

            var url = string.Format("http://simonnuijten.nl/teams.php?name=team", team);
            using (var webClient = new WebClient())
            {
                response = webClient.DownloadString(url);

                Teams teams = JsonConvert.DeserializeObject<Teams>(response);
                for (int i = 0; i < teams.names.Count; i++)
                {
                    favCombobox.Items.Add(teams.names[i].ToString());
                }
            }
            fullSchedule = "";
            for (int i = 0; i < fetchedSchedule.matches.Count; i++)
            {
                //fullSchedule += fetchedSchedule.matches[i] + "\n";
                comboBox2.Items.Add(fetchedSchedule.matches[i].ToString());
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usernameLabel.Text = "Welkom " + Program.username;
        }

        public void Betting()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 6);
            int random2 = rnd.Next(0, 6);

            FetchScores fetchedScores;

            System.Net.WebClient client = new System.Net.WebClient();
            string read3 = client.DownloadString("http://simonnuijten.nl/matchesApi.php");
            fetchedScores = JsonConvert.DeserializeObject<FetchScores>(read3);

            string both = leftteamCombobox.Text + " - " + rightteamCombobox.Text;
            foreach (var item in fetchedScores.scores)
            {
                if (item.Contains(both))
                {
                    var e = item.Split(leftteamCombobox.Text[0]);
                    MessageBox.Show(e[0]);
                }
            }
            if (leftteamCombobox.Text == favCombobox.Text && int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && random > random2 && leftteamGoalsTextBox.Text + " " + VSlbl.Text + " " + rightteamGoalsTextBox.Text == random.ToString() + " " + "-" + " " + random2.ToString() || rightteamCombobox.Text == favCombobox.Text && int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && random2 > random && leftteamGoalsTextBox.Text + VSlbl.Text + rightteamGoalsTextBox.Text == random.ToString() + " - " + random2.ToString())
            {
                MessageBox.Show("Well done, en je team heeft gewonnen, en de uitslag ook nog 's goed geraden!");

            }
            if (leftteamCombobox.Text == favCombobox.Text)
            {
                if (int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && random > random2)
                {
                    MessageBox.Show("je team heeft gewonnen");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
                if (int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && random == random2)
                {
                    MessageBox.Show("gelijk spel!");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
                if (int.Parse(leftteamGoalsTextBox.Text) < int.Parse(rightteamGoalsTextBox.Text) && random < random2)
                {
                    MessageBox.Show("je team heeft verloren");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
                if (int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && random < random2)
                {
                    MessageBox.Show("je team heeft verloren");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
            }
            if (rightteamCombobox.Text == favCombobox.Text)
            {
                if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && random2 > random)
                {
                    MessageBox.Show("je team heeft gewonnen");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
                if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && random2 == random)
                {
                    MessageBox.Show("gelijk spel!");
                    MessageBox.Show(random2.ToString() + " - " + random.ToString());
                }
                if (int.Parse(rightteamGoalsTextBox.Text) < int.Parse(leftteamGoalsTextBox.Text) && random > random2)
                {
                    MessageBox.Show("je team heeft verloren");
                    MessageBox.Show(random.ToString() + " - " + random2.ToString());
                }
            }  
        }
public void betButton_Click(object sender, EventArgs e)
        {
            
            Betting();
        }

        private void leftteamCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox2.Text.Split('-')[0];

            leftteamCombobox.Text = a.Trim().ToString();
            string b = comboBox2.Text.Split('-')[1];

            rightteamCombobox.Text = b.Trim().ToString();
        }
        private void rightteamCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}