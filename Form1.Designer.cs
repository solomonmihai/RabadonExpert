namespace RabadonHELPER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.patchLabel = new System.Windows.Forms.Label();
            this.championsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.champPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.championTitle = new System.Windows.Forms.Label();
            this.championName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lore = new System.Windows.Forms.Label();
            this.champSquareImage = new System.Windows.Forms.PictureBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.baseMS = new System.Windows.Forms.Label();
            this.baseAS = new System.Windows.Forms.Label();
            this.baseAD = new System.Windows.Forms.Label();
            this.baseMr = new System.Windows.Forms.Label();
            this.baseArmor = new System.Windows.Forms.Label();
            this.baseMana = new System.Windows.Forms.Label();
            this.baseHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.infoTabs = new VisualStudioTabControl.VisualStudioTabControl();
            this.buildsPage = new System.Windows.Forms.TabPage();
            this.runesPage = new System.Windows.Forms.TabPage();
            this.runesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.countersPage = new System.Windows.Forms.TabPage();
            this.countersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.skinsPage = new System.Windows.Forms.TabPage();
            this.skinsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel.SuspendLayout();
            this.champPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.champSquareImage)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.infoTabs.SuspendLayout();
            this.runesPage.SuspendLayout();
            this.countersPage.SuspendLayout();
            this.skinsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titlePanel.Controls.Add(this.button1);
            this.titlePanel.Controls.Add(this.minimize);
            this.titlePanel.Controls.Add(this.exitButton);
            this.titlePanel.Controls.Add(this.title);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1000, 50);
            this.titlePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(889, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize.Location = new System.Drawing.Point(925, 10);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(961, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.TabStop = false;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.title.Location = new System.Drawing.Point(3, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(404, 36);
            this.title.TabIndex = 0;
            this.title.Text = "Rabadon Expert - Loading...";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // patchLabel
            // 
            this.patchLabel.AutoSize = true;
            this.patchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.patchLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchLabel.ForeColor = System.Drawing.Color.Coral;
            this.patchLabel.Location = new System.Drawing.Point(12, 42);
            this.patchLabel.Name = "patchLabel";
            this.patchLabel.Size = new System.Drawing.Size(77, 16);
            this.patchLabel.TabIndex = 1;
            this.patchLabel.Text = "Patch: 10.1";
            this.patchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // championsPanel
            // 
            this.championsPanel.AutoScroll = true;
            this.championsPanel.Location = new System.Drawing.Point(12, 61);
            this.championsPanel.Name = "championsPanel";
            this.championsPanel.Size = new System.Drawing.Size(1021, 527);
            this.championsPanel.TabIndex = 2;
            // 
            // champPanel
            // 
            this.champPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.champPanel.Controls.Add(this.panel2);
            this.champPanel.Controls.Add(this.panel1);
            this.champPanel.Controls.Add(this.statsPanel);
            this.champPanel.Controls.Add(this.backButton);
            this.champPanel.Controls.Add(this.infoTabs);
            this.champPanel.Enabled = false;
            this.champPanel.Location = new System.Drawing.Point(9, 61);
            this.champPanel.Name = "champPanel";
            this.champPanel.Size = new System.Drawing.Size(979, 527);
            this.champPanel.TabIndex = 0;
            this.champPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.championTitle);
            this.panel2.Controls.Add(this.championName);
            this.panel2.Location = new System.Drawing.Point(3, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 80);
            this.panel2.TabIndex = 8;
            // 
            // championTitle
            // 
            this.championTitle.AutoSize = true;
            this.championTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championTitle.ForeColor = System.Drawing.Color.Coral;
            this.championTitle.Location = new System.Drawing.Point(3, 47);
            this.championTitle.Name = "championTitle";
            this.championTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.championTitle.Size = new System.Drawing.Size(130, 19);
            this.championTitle.TabIndex = 3;
            this.championTitle.Text = "Champion Title";
            // 
            // championName
            // 
            this.championName.AutoSize = true;
            this.championName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championName.ForeColor = System.Drawing.Color.Coral;
            this.championName.Location = new System.Drawing.Point(3, 8);
            this.championName.Name = "championName";
            this.championName.Size = new System.Drawing.Size(170, 23);
            this.championName.TabIndex = 0;
            this.championName.Text = "Champion Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.lore);
            this.panel1.Controls.Add(this.champSquareImage);
            this.panel1.Location = new System.Drawing.Point(3, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 150);
            this.panel1.TabIndex = 8;
            // 
            // lore
            // 
            this.lore.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lore.ForeColor = System.Drawing.Color.Coral;
            this.lore.Location = new System.Drawing.Point(155, 7);
            this.lore.Name = "lore";
            this.lore.Size = new System.Drawing.Size(815, 138);
            this.lore.TabIndex = 5;
            this.lore.Text = "Lore";
            // 
            // champSquareImage
            // 
            this.champSquareImage.Location = new System.Drawing.Point(-1, 3);
            this.champSquareImage.Name = "champSquareImage";
            this.champSquareImage.Size = new System.Drawing.Size(150, 150);
            this.champSquareImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.champSquareImage.TabIndex = 4;
            this.champSquareImage.TabStop = false;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.statsPanel.Controls.Add(this.baseMS);
            this.statsPanel.Controls.Add(this.baseAS);
            this.statsPanel.Controls.Add(this.baseAD);
            this.statsPanel.Controls.Add(this.baseMr);
            this.statsPanel.Controls.Add(this.baseArmor);
            this.statsPanel.Controls.Add(this.baseMana);
            this.statsPanel.Controls.Add(this.baseHealth);
            this.statsPanel.Controls.Add(this.label1);
            this.statsPanel.Location = new System.Drawing.Point(3, 93);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(230, 275);
            this.statsPanel.TabIndex = 7;
            // 
            // baseMS
            // 
            this.baseMS.AutoSize = true;
            this.baseMS.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseMS.ForeColor = System.Drawing.Color.Coral;
            this.baseMS.Location = new System.Drawing.Point(3, 225);
            this.baseMS.Name = "baseMS";
            this.baseMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseMS.Size = new System.Drawing.Size(99, 21);
            this.baseMS.TabIndex = 10;
            this.baseMS.Text = "Move Speed:";
            // 
            // baseAS
            // 
            this.baseAS.AutoSize = true;
            this.baseAS.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseAS.ForeColor = System.Drawing.Color.Coral;
            this.baseAS.Location = new System.Drawing.Point(3, 195);
            this.baseAS.Name = "baseAS";
            this.baseAS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseAS.Size = new System.Drawing.Size(103, 21);
            this.baseAS.TabIndex = 9;
            this.baseAS.Text = "Attack Speed:";
            // 
            // baseAD
            // 
            this.baseAD.AutoSize = true;
            this.baseAD.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseAD.ForeColor = System.Drawing.Color.Coral;
            this.baseAD.Location = new System.Drawing.Point(3, 165);
            this.baseAD.Name = "baseAD";
            this.baseAD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseAD.Size = new System.Drawing.Size(118, 21);
            this.baseAD.TabIndex = 8;
            this.baseAD.Text = "Attack Damage:";
            // 
            // baseMr
            // 
            this.baseMr.AutoSize = true;
            this.baseMr.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseMr.ForeColor = System.Drawing.Color.Coral;
            this.baseMr.Location = new System.Drawing.Point(3, 135);
            this.baseMr.Name = "baseMr";
            this.baseMr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseMr.Size = new System.Drawing.Size(100, 21);
            this.baseMr.TabIndex = 7;
            this.baseMr.Text = "Magic Resist:";
            // 
            // baseArmor
            // 
            this.baseArmor.AutoSize = true;
            this.baseArmor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseArmor.ForeColor = System.Drawing.Color.Coral;
            this.baseArmor.Location = new System.Drawing.Point(3, 105);
            this.baseArmor.Name = "baseArmor";
            this.baseArmor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseArmor.Size = new System.Drawing.Size(58, 21);
            this.baseArmor.TabIndex = 6;
            this.baseArmor.Text = "Armor:";
            // 
            // baseMana
            // 
            this.baseMana.AutoSize = true;
            this.baseMana.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseMana.ForeColor = System.Drawing.Color.Coral;
            this.baseMana.Location = new System.Drawing.Point(3, 75);
            this.baseMana.Name = "baseMana";
            this.baseMana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseMana.Size = new System.Drawing.Size(52, 21);
            this.baseMana.TabIndex = 5;
            this.baseMana.Text = "Mana:";
            // 
            // baseHealth
            // 
            this.baseHealth.AutoSize = true;
            this.baseHealth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseHealth.ForeColor = System.Drawing.Color.Coral;
            this.baseHealth.Location = new System.Drawing.Point(3, 45);
            this.baseHealth.Name = "baseHealth";
            this.baseHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.baseHealth.Size = new System.Drawing.Size(58, 21);
            this.baseHealth.TabIndex = 4;
            this.baseHealth.Text = "Health:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base Stats";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(946, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // infoTabs
            // 
            this.infoTabs.ActiveColor = System.Drawing.Color.Coral;
            this.infoTabs.AllowDrop = true;
            this.infoTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.infoTabs.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.infoTabs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.infoTabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.infoTabs.ClosingMessage = null;
            this.infoTabs.Controls.Add(this.buildsPage);
            this.infoTabs.Controls.Add(this.runesPage);
            this.infoTabs.Controls.Add(this.countersPage);
            this.infoTabs.Controls.Add(this.skinsPage);
            this.infoTabs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTabs.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.infoTabs.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.infoTabs.ItemSize = new System.Drawing.Size(150, 20);
            this.infoTabs.Location = new System.Drawing.Point(239, 7);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoTabs.ShowClosingButton = false;
            this.infoTabs.ShowClosingMessage = false;
            this.infoTabs.Size = new System.Drawing.Size(701, 361);
            this.infoTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.infoTabs.TabIndex = 9;
            this.infoTabs.TextColor = System.Drawing.Color.Coral;
            this.infoTabs.SelectedIndexChanged += new System.EventHandler(this.InfoTabs_SelectedIndexChanged);
            // 
            // buildsPage
            // 
            this.buildsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buildsPage.Location = new System.Drawing.Point(4, 24);
            this.buildsPage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buildsPage.Name = "buildsPage";
            this.buildsPage.Padding = new System.Windows.Forms.Padding(3);
            this.buildsPage.Size = new System.Drawing.Size(693, 333);
            this.buildsPage.TabIndex = 0;
            this.buildsPage.Text = "Builds ";
            // 
            // runesPage
            // 
            this.runesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.runesPage.Controls.Add(this.runesPanel);
            this.runesPage.Location = new System.Drawing.Point(4, 24);
            this.runesPage.Name = "runesPage";
            this.runesPage.Padding = new System.Windows.Forms.Padding(3);
            this.runesPage.Size = new System.Drawing.Size(693, 333);
            this.runesPage.TabIndex = 1;
            this.runesPage.Text = "Runes   ";
            // 
            // runesPanel
            // 
            this.runesPanel.Location = new System.Drawing.Point(3, 6);
            this.runesPanel.Name = "runesPanel";
            this.runesPanel.Size = new System.Drawing.Size(681, 321);
            this.runesPanel.TabIndex = 0;
            // 
            // countersPage
            // 
            this.countersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.countersPage.Controls.Add(this.countersPanel);
            this.countersPage.Location = new System.Drawing.Point(4, 24);
            this.countersPage.Name = "countersPage";
            this.countersPage.Padding = new System.Windows.Forms.Padding(3);
            this.countersPage.Size = new System.Drawing.Size(693, 333);
            this.countersPage.TabIndex = 2;
            this.countersPage.Text = "Counters";
            // 
            // countersPanel
            // 
            this.countersPanel.Location = new System.Drawing.Point(3, 62);
            this.countersPanel.Name = "countersPanel";
            this.countersPanel.Size = new System.Drawing.Size(687, 268);
            this.countersPanel.TabIndex = 0;
            // 
            // skinsPage
            // 
            this.skinsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.skinsPage.Controls.Add(this.skinsPanel);
            this.skinsPage.Location = new System.Drawing.Point(4, 24);
            this.skinsPage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.skinsPage.Name = "skinsPage";
            this.skinsPage.Padding = new System.Windows.Forms.Padding(3);
            this.skinsPage.Size = new System.Drawing.Size(693, 333);
            this.skinsPage.TabIndex = 3;
            this.skinsPage.Text = "Skins";
            // 
            // skinsPanel
            // 
            this.skinsPanel.AutoScroll = true;
            this.skinsPanel.Location = new System.Drawing.Point(6, 6);
            this.skinsPanel.Name = "skinsPanel";
            this.skinsPanel.Size = new System.Drawing.Size(681, 367);
            this.skinsPanel.TabIndex = 0;
            this.skinsPanel.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.champPanel);
            this.Controls.Add(this.championsPanel);
            this.Controls.Add(this.patchLabel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Rabadon Expert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.champPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.champSquareImage)).EndInit();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.infoTabs.ResumeLayout(false);
            this.runesPage.ResumeLayout(false);
            this.countersPage.ResumeLayout(false);
            this.skinsPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label patchLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel championsPanel;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel champPanel;
        private VisualStudioTabControl.VisualStudioTabControl infoTabs;
        private System.Windows.Forms.TabPage buildsPage;
        private System.Windows.Forms.TabPage runesPage;
        private System.Windows.Forms.TabPage countersPage;
        private System.Windows.Forms.TabPage skinsPage;
        private System.Windows.Forms.FlowLayoutPanel skinsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label championTitle;
        private System.Windows.Forms.Label championName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lore;
        private System.Windows.Forms.PictureBox champSquareImage;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label baseMS;
        private System.Windows.Forms.Label baseAS;
        private System.Windows.Forms.Label baseAD;
        private System.Windows.Forms.Label baseMr;
        private System.Windows.Forms.Label baseArmor;
        private System.Windows.Forms.Label baseMana;
        private System.Windows.Forms.Label baseHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel runesPanel;
        private System.Windows.Forms.FlowLayoutPanel countersPanel;
    }
}

