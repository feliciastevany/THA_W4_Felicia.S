using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static THA_Winform_W4.Form1;

namespace THA_Winform_W4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Team> team = new List<Team>();
        public class Team
        {
            public List<Player> Players = new List<Player>();
            private string teamName;
            public string Teamname
            {
                get { return teamName; }
                set { teamName = value; }
            }
            private string teamCountry;
            public string Teamcountry
            {
                get { return teamCountry; }
                set { teamCountry = value; }
            }
            private string teamCity;
            public string Teamcity
            {
                get { return teamCity; }
                set { teamCity = value; }
            }
            public Team(string name, string country, string city)
            {
                this.teamName = name;
                this.teamCountry = country;
                this.teamCity = city;
            }
        }
        public class Player
        {
            private string playerName;
            public string Playername
            {
                get { return playerName; }
                set { playerName = value; }
            }
            private string playerNum;
            public string Playernum
            {
                get { return playerNum; }
                set { playerNum = value; }
            }
            private string playerPos;
            public string Playerpos
            {
                get { return playerPos; }
                set { playerPos = value; }
            }
            public Player(string name, string num, string pos)
            {
                this.playerName = name;
                this.playerNum = num;
                this.playerPos = pos;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                Team club1 = new Team("Manchester United", "England", "Manchester");
                team.Add(club1);
                Team club2 = new Team("Napoli", "Italia", "Naples");
                team.Add(club2);
                Team club3 = new Team("AS Roma", "Italia", "Roma");
                team.Add(club3);
                foreach (Team tim in team)
                {
                    if (!comboBoxCountry.Items.Contains(tim.Teamcountry))
                    {
                        comboBoxCountry.Items.Add(tim.Teamcountry);
                    }
                }
                Player pemain1 = new Player("David De Gea", "01", "GK");
                club1.Players.Add(pemain1);
                Player pemain2 = new Player("Tom Heaton", "22", "GK");
                club1.Players.Add(pemain2);
                Player pemain3 = new Player("Phil Jones", "04", "DF");
                club1.Players.Add(pemain3);
                Player pemain4 = new Player("Harry Maguire", "05", "DF");
                club1.Players.Add(pemain4);
                Player pemain5 = new Player("Lisandro Martinez", "06", "DF");
                club1.Players.Add(pemain5);
                Player pemain6 = new Player("Tyrell Malacia", "12", "DF");
                club1.Players.Add(pemain6);
                Player pemain7 = new Player("Bruno Fernandes", "08", "MF");
                club1.Players.Add(pemain7);
                Player pemain8 = new Player("Christian Eriksen", "14", "MF");
                club1.Players.Add(pemain8);
                Player pemain9 = new Player("Marcel Sabitzer", "15", "MF");
                club1.Players.Add(pemain9);
                Player pemain10 = new Player("Anthony Martial", "09", "FW");
                club1.Players.Add(pemain10);
                Player pemain11 = new Player("Marcus Rashford", "10", "FW");
                club1.Players.Add(pemain11);

                Player pemainn1 = new Player("Alex Meret", "01", "GK");
                club2.Players.Add(pemainn1);
                Player pemainn2 = new Player("David Marfella", "12", "GK");
                club2.Players.Add(pemainn2);
                Player pemainn3 = new Player("Salvatore Sirigu", "30", "GK");
                club2.Players.Add(pemainn3);
                Player pemainn4 = new Player("Kim Min-jae", "03", "DF");
                club2.Players.Add(pemainn4);
                Player pemainn5 = new Player("Juan Jesus", "05", "DF");
                club2.Players.Add(pemainn5);
                Player pemainn6 = new Player("Mathias Olivera", "17", "DF");
                club2.Players.Add(pemainn6);
                Player pemainn7 = new Player("Alessandro Zanoli", "59", "DF");
                club2.Players.Add(pemainn7);
                Player pemainn8 = new Player("Diego Demme", "04", "MF");
                club2.Players.Add(pemainn8);
                Player pemainn9 = new Player("Piotr Zielinski", "20", "MF");
                club2.Players.Add(pemainn9);
                Player pemainn10 = new Player("Victor Osimhen", "09", "FW");
                club2.Players.Add(pemainn10);
                Player pemainn11 = new Player("Giovanni Simeone", "18", "FW");
                club2.Players.Add(pemainn11);

                Player pemainnn1 = new Player("Rui Patricio", "01", "GK");
                club3.Players.Add(pemainnn1);
                Player pemainnn2 = new Player("Rick Karsdorp", "02", "DF");
                club3.Players.Add(pemainnn2);
                Player pemainnn3 = new Player("Roger Ibanez", "03", "DF");
                club3.Players.Add(pemainnn3);
                Player pemainnn4 = new Player("Chris Smalling", "06", "DF");
                club3.Players.Add(pemainnn4);
                Player pemainnn5 = new Player("Bryan Cristante", "04", "MF");
                club3.Players.Add(pemainnn5);
                Player pemainnn6 = new Player("Lorenzo Pellegrini", "07", "MF");
                club3.Players.Add(pemainnn6);
                Player pemainnn7 = new Player("Nemanja Matic", "08", "MF");
                club3.Players.Add(pemainnn7);
                Player pemainnn8 = new Player("Tammy Abraham", "09", "FW");
                club3.Players.Add(pemainnn8);
                Player pemainnn9 = new Player("Andrea Belotti", "11", "FW");
                club3.Players.Add(pemainnn9);
                Player pemainnn10 = new Player("Paulo Dybala", "21", "FW");
                club3.Players.Add(pemainnn10);
                Player pemainnn11 = new Player("Pietro Boer", "63", "GK");
                club3.Players.Add(pemainnn11);
        }

        private void textBoxTeamName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTeamCity_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeam.Items.Clear();
            foreach (Team tim in team)
            {
                if (comboBoxCountry.Text == tim.Teamcountry)
                {
                    comboBoxTeam.Items.Add(tim.Teamname);
                }
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team tim in team)
            {
                if (comboBoxTeam.Text == tim.Teamname)
                {
                    foreach (Player pemain in tim.Players)
                    {
                        listBox1.Items.Add("(" + pemain.Playernum + ") " + pemain.Playername + ", " + pemain.Playerpos);
                        listBox1.Sorted = true;
                    }
                }
            }
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            bool cek = false;
            if (textBoxTeamName.Text != "" || textBoxTeamCountry.Text != "" || textBoxTeamCity.Text != "")
            {
                Team tim = new Team(textBoxTeamName.Text, textBoxTeamCountry.Text, textBoxTeamCity.Text);
                foreach (Team team1 in team)
                {
                    if (team1.Teamname == tim.Teamname)
                    {
                        MessageBox.Show("Team allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cek = true;
                    }      
                }
                if (cek == true)
                {
                    team.Add(tim);
                    foreach (Team tem in team)
                    {
                        if (!comboBoxCountry.Items.Contains(tem.Teamcountry))
                        {
                            comboBoxCountry.Items.Add(tem.Teamcountry);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("All fields need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxTeamName.Text = "";
            textBoxTeamCountry.Text = "";
            textBoxTeamCity.Text = "";
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text != "" || textBoxPlayerNumber.Text != "" || comboBoxPosition.Text != "")
            {
                bool ada = false;
                Player pemain = new Player(textBoxPlayerName.Text, textBoxPlayerNumber.Text, comboBoxPosition.Text);
                foreach (Team tim in team)
                {
                    foreach (Player players in tim.Players)
                    {
                        if (pemain.Playername == players.Playername)
                        {
                            MessageBox.Show("Player allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ada = true;
                        }
                    }
                }
                if (ada == false)
                {
                    foreach (Team team in team)
                    {
                        if (team.Teamname == comboBoxTeam.Text)
                        {
                            team.Players.Add(pemain);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxPlayerName.Text = "";
            textBoxPlayerNumber.Text = "";
            comboBoxPosition.Text = "";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 11)
            {
                MessageBox.Show("The player is less than 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team t in team)
                {
                    if (t.Teamname == comboBoxTeam.Text)
                    {
                        foreach (Player pemain in t.Players)
                        {
                            if (listBox1.SelectedItem.ToString() == pemain.Playername)
                            {
                                t.Players.Remove(pemain);
                                break;
                            }
                        }
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
