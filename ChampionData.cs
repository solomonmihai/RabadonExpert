using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;
using AngleSharp.Html.Parser;
using System.Text.RegularExpressions;

namespace RabadonHELPER
{
    public partial class Form1
    {
        private void LoadBuilds(string championId)
        {

        }

        private void LoadRunes(string champId)
        {
            runesPanel.Controls.Clear();

            var url = OPGG_BASE_URL + champId.ToLower();

            var thread = new Thread(() =>
            {
                var htmlString = Client.GetStringAsync(url).Result;

                var parser = new HtmlParser();
                var html = parser.ParseDocument(htmlString);

                var divs = html.All.Where(div => div.LocalName == "div" && div.HasAttribute("class") && div.GetAttribute("class").Contains("perk-page-wrap"));

                foreach (var div in divs)
                {
                    var actives = div.QuerySelectorAll("div").Where(active => active.GetAttribute("class").Contains("--active"));

                    int width = (int)(runesPanel.Size.Width / 9.3f);

                    foreach (var active in actives)
                    {
                        var img = active.QuerySelector("img");
                        var runeName = img.GetAttribute("alt");
                        var hardUrl = img.GetAttribute("src");
                        var runeImgURL = "https://" + hardUrl.Substring(2, hardUrl.Length - 2);

                        var request = System.Net.WebRequest.Create(runeImgURL);

                        var pictureBox = new PictureBox();
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox.Image = Bitmap.FromStream(stream);
                        }
                        pictureBox.Size = new Size(width, width);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Paint += (object sender, PaintEventArgs e) =>
                        {
                            ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, title.ForeColor, ButtonBorderStyle.Solid);
                        };

                        toolTip.SetToolTip(pictureBox, runeName);

                        Invoke(new Action(() =>
                        {
                            runesPanel.Controls.Add(pictureBox);
                        }));
                    }

                    var importButton = new Button();
                    importButton.FlatAppearance.BorderSize = 4;
                    importButton.FlatStyle = FlatStyle.Flat;
                    importButton.ForeColor = title.ForeColor;
                    importButton.FlatAppearance.BorderColor = title.ForeColor;
                    importButton.MouseEnter += delegate
                    {
                        importButton.FlatAppearance.BorderColor = titlePanel.ForeColor;
                    };
                    importButton.MouseLeave += delegate
                    {
                        importButton.FlatAppearance.BorderColor = title.ForeColor;
                    };
                    importButton.Text = "ADD TO CLIENT";
                    importButton.Font = championName.Font;
                    importButton.Size = new Size(200, width);

                    Invoke(new Action(() =>
                    {
                        runesPanel.Controls.Add(importButton);
                    }));

                    runesPanel.SetFlowBreak(importButton, true);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void LoadCounters(string championId)
        {
            countersPanel.Controls.Clear();

            var url = OPGG_BASE_URL + championId.ToLower();

            var thread = new Thread(() =>
            {
                var htmlString = Client.GetStringAsync(url).Result;
                var parser = new HtmlParser();
                var html = parser.ParseDocument(htmlString);

                var els = html.All.Where(el => el.HasAttribute("class") && el.GetAttribute("class").Contains("champion-stats-header-matchup__table__champion"));

                int width = 80;

                var countersLabel = new Label();
                countersLabel.Font = championName.Font;
                countersLabel.ForeColor = championName.ForeColor;
                countersLabel.Text = "Counters:";
                countersLabel.AutoSize = false;
                countersLabel.Size = new Size(200, width);
                countersLabel.TextAlign = ContentAlignment.MiddleCenter;

                var strongLabel = new Label();
                strongLabel.Font = championName.Font;
                strongLabel.ForeColor = championName.ForeColor;
                strongLabel.Text = "Strong against:";
                strongLabel.AutoSize = false;
                strongLabel.Size = new Size(200, width);
                strongLabel.TextAlign = ContentAlignment.MiddleCenter;

                Invoke(new Action(() =>
                {
                    countersPanel.Controls.Add(countersLabel);
                }));

                int i = 0;
                foreach (var el in els)
                {
                    var champName = el.TextContent.Trim();
                    var hardUrl = el.QuerySelector("img").GetAttribute("src");

                    var pictureBox = new PictureBox();
                    foreach (Button button in championsPanel.Controls)
                    {
                        if (button.Name == champName)
                        {
                            pictureBox.Image = button.BackgroundImage;
                        }
                    }
                    
                    pictureBox.Size = new Size(width, width);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Paint += (object sender, PaintEventArgs e) =>
                    {
                        ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, title.ForeColor, ButtonBorderStyle.Solid);
                    };

                    toolTip.SetToolTip(pictureBox, champName);

                    Invoke(new Action(() =>
                    {
                        countersPanel.Controls.Add(pictureBox);
                    }));

                    if (i == 2)
                    {
                        Invoke(new Action(() =>
                        {
                            countersPanel.SetFlowBreak(pictureBox, true);
                            countersPanel.Controls.Add(strongLabel);
                        }));
                    }
                    i++;
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void LoadSkins(JArray skinsObject, string champId)
        {
            skinsPanel.Controls.Clear();
            foreach (var skin in skinsObject)
            {
                var url = CHAMPION_SKIN_BASE_URL + champId + "_" + (string)skin["num"] + ".jpg";
                var pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size((int)(308 * 0.57f), (int)(560 * 0.57f));
                pictureBox.LoadAsync(url);
                pictureBox.MouseHover += delegate
                {
                    toolTip.SetToolTip(pictureBox, (string)skin["name"]);
                };
                pictureBox.Paint += (object sender, PaintEventArgs e) =>
                {
                    ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, title.ForeColor, ButtonBorderStyle.Solid);
                };
                skinsPanel.Controls.Add(pictureBox);
            }
        }
    }
}
