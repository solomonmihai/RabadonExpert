using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace RabadonHELPER
{
    public partial class Form1 : Form, IMessageFilter
    {
        private static HttpClient Client { get; set; }
        private static ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();

            Application.AddMessageFilter(this);

            controlsToMove.Add(titlePanel);
            controlsToMove.Add(title);

            toolTip = new ToolTip();
            toolTip.InitialDelay = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new HttpClient();

            var url = "http://ddragon.leagueoflegends.com/cdn/10.1.1/img/champion/Yasuo.png";
            var picture = new PictureBox();
            picture.Load(url);
            defaultImage = picture.Image;

            RunLoadChampionsThread();
        }

        static string CHAMPIONS_URL => "http://ddragon.leagueoflegends.com/cdn/" + Patch + "/data/en_US/champion.json";
        static string SQUARE_IMAGES_BASE_URL => "http://ddragon.leagueoflegends.com/cdn/" + Patch + "/img/champion/";
        static string CHAMPION_INFO_BASE_URL => "http://ddragon.leagueoflegends.com/cdn/" + Patch + "/data/en_US/champion/";
        const string CHAMPION_SKIN_BASE_URL = "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/";
        const string OPGG_BASE_URL = "http://na.op.gg/champion/";
        const string PATCH_URL = "https://ddragon.leagueoflegends.com/api/versions.json";

        static string Patch
        {
            get; set;
        }

        Image defaultImage;

        Thread loadThread;

        private void RunLoadChampionsThread()
        {
            Patch = (string)(JArray.Parse(Client.GetStringAsync(PATCH_URL).Result)[0]);
            patchLabel.Text = "Patch: " + Patch;

            loadThread = new Thread(new ThreadStart(LoadChampions))
            {
                IsBackground = true
            };
            loadThread.Start();
        }

        private void LoadChampions()
        {
            var response = Client.GetAsync(CHAMPIONS_URL).Result;
            var jsonString = response.Content.ReadAsStringAsync().Result;
            var json = Newtonsoft.Json.Linq.JObject.Parse(jsonString);

            foreach (var champ in (JObject)json["data"])
            {
                var name = (string)champ.Value["name"];
                MakeChampionButton(champ.Key, (string)champ.Value["name"]);
            }

            _ = Parallel.ForEach(championsPanel.Controls.Cast<Control>(), new ParallelOptions()
            {
                MaxDegreeOfParallelism = 200
            }, (button) =>
            {
                if (button is Button)
                {
                    var url = button.Tag.ToString().Split('-')[0];
                    var picture = new PictureBox();
                    picture.Load(url);
                    button.BackgroundImage = picture.Image;
                }
            }); ;
            Invoke(new Action(() =>
            {
                title.Text = "Rabadon Expert";
            }));
        }

        private void MakeChampionButton(string champId, string champName)
        {
            var url = SQUARE_IMAGES_BASE_URL + champId + ".png";

            int width = 69;
            var button = new Button();
            button.Tag = url + "-" + champId;
            button.Name = champName;
            button.BackgroundImage = defaultImage;
            button.Size = new Size(width, width);
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = titlePanel.BackColor;
            button.FlatStyle = FlatStyle.Flat;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.MouseHover += delegate
            {
                toolTip.SetToolTip(button, champName);
            };
            button.MouseEnter += delegate
            {
                button.FlatAppearance.BorderColor = title.ForeColor;
            };
            button.MouseLeave += delegate
            {
                button.FlatAppearance.BorderColor = titlePanel.BackColor;
            };
            button.Click += delegate
            {
                SetChampionInfo(button);
                championsPanel.Visible = false;
                championsPanel.Enabled = false;
                champPanel.Visible = true;
                champPanel.Enabled = true;
            };

            Invoke(new Action(() =>
            {
                championsPanel.Controls.Add(button);
            }));
        }

        private void SetChampionInfo(Button button)
        {
            var championId = button.Tag.ToString().Split('-')[1];
            var url = CHAMPION_INFO_BASE_URL + championId + ".json";
            var response = Client.GetStringAsync(url).Result;
            var json = Newtonsoft.Json.Linq.JObject.Parse(response);
            var champ = (JObject)json["data"][championId];

            var champName = (string)champ["name"];
            var champTitle = (string)champ["title"];
            var champLore = (string)champ["lore"];

            var skins = (JArray)champ["skins"];

            var stats = (JObject)champ["stats"];

            Invoke(new Action(() =>
            {
                championName.Text = champName;
                championTitle.Text = champTitle;
                lore.Text = champLore;

                baseAD.Text = "Attack Damage: " + (string)stats["attackdamage"];
                baseArmor.Text = "Armor: " + (string)stats["armor"];
                baseAS.Text = "Attack Speed: " + (string)stats["attackspeed"];
                baseHealth.Text = "Health: " + (string)stats["hp"];
                baseMana.Text = "Mana/Energy: " + (string)stats["mp"];
                baseMr.Text = "Magic Resist: " + (string)stats["spellblock"];
                baseMS.Text = "Movement Speed: " + (string)stats["movespeed"];

                champSquareImage.Image = button.BackgroundImage;
            }));
            //LoadBuilds(championId);
            LoadRunes(championId);
            LoadCounters(championId);
            LoadSkins(skins, championId);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            championsPanel.Visible = true;
            championsPanel.Enabled = true;
            champPanel.Visible = false;
            champPanel.Enabled = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ChampPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InfoTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
