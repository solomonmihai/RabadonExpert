using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
using System.Net;

namespace RabadonHELPER
{
    public partial class Form1 : Form, IMessageFilter
    {
        public static HttpClient Client { get; private set; }

        public Form1()
        {
            InitializeComponent();

            Application.AddMessageFilter(this);

            controlsToMove.Add(titlePanel);
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

        const string CHAMPIONS_URL = "http://ddragon.leagueoflegends.com/cdn/10.1.1/data/en_US/champion.json";
        const string SQUARE_IMAGES_BASE_URL = "http://ddragon.leagueoflegends.com/cdn/10.1.1/img/champion/";
        const string CHAMPION_INFO_BASE_URL = "http://ddragon.leagueoflegends.com/cdn/10.1.1/data/en_US/champion/";

        Image defaultImage;

        Thread loadThread;

        private void RunLoadChampionsThread()
        {
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

            Invoke(new Action(() => patchLabel.Text = "Patch: " + (string)json["version"]));

            char prevCh = ' ';

            foreach (var champ in (JObject)json["data"])
            {
                var name = (string)champ.Value["name"];
                MakeChampionButton(champ.Key, (string)champ.Value["name"]);
            }

            _ = Parallel.ForEach(championsPanel.Controls.Cast<Button>(), new ParallelOptions()
            {
                MaxDegreeOfParallelism = 200
            }, (button) =>
            {
                var url = button.Tag.ToString().Split('-')[0];
                var picture = new PictureBox();
                picture.Load(url);
                button.BackgroundImage = picture.Image;
            }); ;
            Invoke(new Action(() =>
            {
                title.Text = "Rabadon Expert";
            }));
        }

        private void MakeChampionButton(string champId, string champName)
        {
            var url = SQUARE_IMAGES_BASE_URL + champId + ".png";

            int width = 80;
            var button = new Button();
            button.TextImageRelation = TextImageRelation.ImageAboveText;
            button.Tag = url + "-" + champId;
            button.Name = champName;
            button.BackgroundImage = defaultImage;
            button.Size = new Size(width, width);
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = titlePanel.BackColor;
            button.FlatStyle = FlatStyle.Flat;
            button.BackgroundImageLayout = ImageLayout.Stretch;
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
                infoPanel.Visible = true;
                infoPanel.Enabled = true;
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
            infoPanel.Visible = false;
            infoPanel.Enabled = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
