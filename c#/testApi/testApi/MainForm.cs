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
                MessageBox.Show("oeps... er is iets mis gegaan ");
                return;
            }

            Team[] team = JsonConvert.DeserializeObject<Team[]>(teamJson);


            for (int i = 0; i < team.Length; i++)
            {
                listBox1.Items.Add(team[i].Name);
            }
            
        }

        private void GokkerButton_Click(object sender, EventArgs e)
        {
            Form newGamblerForm = new Form();
            newGamblerForm.Show();
            
        }
    }
}
