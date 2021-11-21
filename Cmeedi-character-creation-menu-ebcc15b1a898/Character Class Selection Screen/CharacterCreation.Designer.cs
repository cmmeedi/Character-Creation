namespace Character_Class_Selection_Screen
{
    partial class CharacterSelectionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelectionForm));
            this.CharacterClassSelectionLabel = new System.Windows.Forms.Label();
            this.TimedCheckBox = new System.Windows.Forms.CheckBox();
            this.HardCheckBox = new System.Windows.Forms.CheckBox();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.OrcRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.RaceSelectionBox = new System.Windows.Forms.GroupBox();
            this.CharacterClassSelectionList = new System.Windows.Forms.ListBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.MagicLabel = new System.Windows.Forms.Label();
            this.DefenseLabel = new System.Windows.Forms.Label();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.ManaPointsLabel = new System.Windows.Forms.Label();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.StrengthPointsLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.DefensePointsLabel = new System.Windows.Forms.Label();
            this.MagicPointsLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.AgilityPointsLabel = new System.Windows.Forms.Label();
            this.CharacterDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.LevelSearchTextBox = new System.Windows.Forms.TextBox();
            this.LevelSearchLabel = new System.Windows.Forms.Label();
            this.ToonsListBox = new System.Windows.Forms.ListBox();
            this.LevelCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.NameSearchLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RaceSelectionBox.SuspendLayout();
            this.CharacterDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterClassSelectionLabel
            // 
            this.CharacterClassSelectionLabel.AutoSize = true;
            this.CharacterClassSelectionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CharacterClassSelectionLabel.Image = ((System.Drawing.Image)(resources.GetObject("CharacterClassSelectionLabel.Image")));
            this.CharacterClassSelectionLabel.Location = new System.Drawing.Point(9, 100);
            this.CharacterClassSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CharacterClassSelectionLabel.Name = "CharacterClassSelectionLabel";
            this.CharacterClassSelectionLabel.Size = new System.Drawing.Size(104, 17);
            this.CharacterClassSelectionLabel.TabIndex = 1;
            this.CharacterClassSelectionLabel.Text = "Class Selection";
            // 
            // TimedCheckBox
            // 
            this.TimedCheckBox.AutoSize = true;
            this.TimedCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TimedCheckBox.BackgroundImage")));
            this.TimedCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimedCheckBox.Location = new System.Drawing.Point(7, 223);
            this.TimedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimedCheckBox.Name = "TimedCheckBox";
            this.TimedCheckBox.Size = new System.Drawing.Size(69, 21);
            this.TimedCheckBox.TabIndex = 5;
            this.TimedCheckBox.Text = "Timed";
            this.TimedCheckBox.UseVisualStyleBackColor = true;
            // 
            // HardCheckBox
            // 
            this.HardCheckBox.AutoSize = true;
            this.HardCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HardCheckBox.BackgroundImage")));
            this.HardCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HardCheckBox.Location = new System.Drawing.Point(84, 223);
            this.HardCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HardCheckBox.Name = "HardCheckBox";
            this.HardCheckBox.Size = new System.Drawing.Size(61, 21);
            this.HardCheckBox.TabIndex = 6;
            this.HardCheckBox.Text = "Hard";
            this.HardCheckBox.UseVisualStyleBackColor = true;
            // 
            // PictureLabel
            // 
            this.PictureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureLabel.ImageIndex = 7;
            this.PictureLabel.ImageList = this.imageList1;
            this.PictureLabel.Location = new System.Drawing.Point(330, 15);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(187, 171);
            this.PictureLabel.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Warrior.jpg");
            this.imageList1.Images.SetKeyName(1, "Ranger.png");
            this.imageList1.Images.SetKeyName(2, "Wizard.jpg");
            this.imageList1.Images.SetKeyName(3, "Orc Ranger.png");
            this.imageList1.Images.SetKeyName(4, "Orc Warrior.png");
            this.imageList1.Images.SetKeyName(5, "Orc Wizard.jpg");
            this.imageList1.Images.SetKeyName(6, "Molten Lava.jpg");
            this.imageList1.Images.SetKeyName(7, "Molten Lava Button.jpg");
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.Location = new System.Drawing.Point(425, 202);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 60);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OKButton.BackgroundImage")));
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OKButton.Location = new System.Drawing.Point(317, 202);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 60);
            this.OKButton.TabIndex = 9;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // OrcRadioButton
            // 
            this.OrcRadioButton.AutoSize = true;
            this.OrcRadioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrcRadioButton.BackgroundImage")));
            this.OrcRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrcRadioButton.Location = new System.Drawing.Point(8, 52);
            this.OrcRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrcRadioButton.Name = "OrcRadioButton";
            this.OrcRadioButton.Size = new System.Drawing.Size(52, 21);
            this.OrcRadioButton.TabIndex = 3;
            this.OrcRadioButton.TabStop = true;
            this.OrcRadioButton.Text = "Orc";
            this.OrcRadioButton.UseVisualStyleBackColor = true;
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HumanRadioButton.BackgroundImage")));
            this.HumanRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HumanRadioButton.Location = new System.Drawing.Point(8, 23);
            this.HumanRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(74, 21);
            this.HumanRadioButton.TabIndex = 2;
            this.HumanRadioButton.TabStop = true;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            // 
            // RaceSelectionBox
            // 
            this.RaceSelectionBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RaceSelectionBox.BackgroundImage")));
            this.RaceSelectionBox.Controls.Add(this.HumanRadioButton);
            this.RaceSelectionBox.Controls.Add(this.OrcRadioButton);
            this.RaceSelectionBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RaceSelectionBox.Location = new System.Drawing.Point(13, 5);
            this.RaceSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.RaceSelectionBox.Name = "RaceSelectionBox";
            this.RaceSelectionBox.Padding = new System.Windows.Forms.Padding(4);
            this.RaceSelectionBox.Size = new System.Drawing.Size(132, 87);
            this.RaceSelectionBox.TabIndex = 4;
            this.RaceSelectionBox.TabStop = false;
            this.RaceSelectionBox.Text = "Race Selection";
            // 
            // CharacterClassSelectionList
            // 
            this.CharacterClassSelectionList.FormattingEnabled = true;
            this.CharacterClassSelectionList.ItemHeight = 16;
            this.CharacterClassSelectionList.Items.AddRange(new object[] {
            "Ranger",
            "Warrior",
            "Wizard"});
            this.CharacterClassSelectionList.Location = new System.Drawing.Point(13, 120);
            this.CharacterClassSelectionList.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterClassSelectionList.Name = "CharacterClassSelectionList";
            this.CharacterClassSelectionList.Size = new System.Drawing.Size(131, 84);
            this.CharacterClassSelectionList.TabIndex = 0;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MagicLabel.Location = new System.Drawing.Point(25, 187);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(45, 17);
            this.MagicLabel.TabIndex = 15;
            this.MagicLabel.Text = "Magic";
            // 
            // DefenseLabel
            // 
            this.DefenseLabel.AutoSize = true;
            this.DefenseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DefenseLabel.Location = new System.Drawing.Point(8, 161);
            this.DefenseLabel.Name = "DefenseLabel";
            this.DefenseLabel.Size = new System.Drawing.Size(61, 17);
            this.DefenseLabel.TabIndex = 14;
            this.DefenseLabel.Text = "Defense";
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HealthPointsLabel.Location = new System.Drawing.Point(85, 56);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.HealthPointsLabel.TabIndex = 17;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StrengthLabel.Location = new System.Drawing.Point(12, 108);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(62, 17);
            this.StrengthLabel.TabIndex = 13;
            this.StrengthLabel.Text = "Strength";
            // 
            // ManaPointsLabel
            // 
            this.ManaPointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManaPointsLabel.Location = new System.Drawing.Point(85, 82);
            this.ManaPointsLabel.Name = "ManaPointsLabel";
            this.ManaPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.ManaPointsLabel.TabIndex = 18;
            // 
            // ManaLabel
            // 
            this.ManaLabel.AutoSize = true;
            this.ManaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManaLabel.Location = new System.Drawing.Point(28, 82);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(43, 17);
            this.ManaLabel.TabIndex = 12;
            this.ManaLabel.Text = "Mana";
            // 
            // StrengthPointsLabel
            // 
            this.StrengthPointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StrengthPointsLabel.Location = new System.Drawing.Point(85, 108);
            this.StrengthPointsLabel.Name = "StrengthPointsLabel";
            this.StrengthPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.StrengthPointsLabel.TabIndex = 19;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HealthLabel.Location = new System.Drawing.Point(22, 56);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(49, 17);
            this.HealthLabel.TabIndex = 11;
            this.HealthLabel.Text = "Health";
            // 
            // DefensePointsLabel
            // 
            this.DefensePointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DefensePointsLabel.Location = new System.Drawing.Point(84, 161);
            this.DefensePointsLabel.Name = "DefensePointsLabel";
            this.DefensePointsLabel.Size = new System.Drawing.Size(44, 17);
            this.DefensePointsLabel.TabIndex = 20;
            // 
            // MagicPointsLabel
            // 
            this.MagicPointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MagicPointsLabel.Location = new System.Drawing.Point(84, 187);
            this.MagicPointsLabel.Name = "MagicPointsLabel";
            this.MagicPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.MagicPointsLabel.TabIndex = 21;
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgilityLabel.Location = new System.Drawing.Point(29, 135);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(45, 17);
            this.AgilityLabel.TabIndex = 22;
            this.AgilityLabel.Text = "Agility";
            // 
            // AgilityPointsLabel
            // 
            this.AgilityPointsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgilityPointsLabel.Location = new System.Drawing.Point(85, 135);
            this.AgilityPointsLabel.Name = "AgilityPointsLabel";
            this.AgilityPointsLabel.Size = new System.Drawing.Size(44, 17);
            this.AgilityPointsLabel.TabIndex = 23;
            // 
            // CharacterDetailsGroupBox
            // 
            this.CharacterDetailsGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterDetailsGroupBox.BackgroundImage")));
            this.CharacterDetailsGroupBox.Controls.Add(this.AgilityPointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.AgilityLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.MagicPointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterDetailsGroupBox.Controls.Add(this.DefensePointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.HealthLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.StrengthPointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.ManaLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.ManaPointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.StrengthLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.HealthPointsLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.DefenseLabel);
            this.CharacterDetailsGroupBox.Controls.Add(this.MagicLabel);
            this.CharacterDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CharacterDetailsGroupBox.Location = new System.Drawing.Point(163, 5);
            this.CharacterDetailsGroupBox.Name = "CharacterDetailsGroupBox";
            this.CharacterDetailsGroupBox.Size = new System.Drawing.Size(149, 216);
            this.CharacterDetailsGroupBox.TabIndex = 16;
            this.CharacterDetailsGroupBox.TabStop = false;
            this.CharacterDetailsGroupBox.Text = "Character Details";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(26, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(103, 22);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.Text = "Player Name";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(163, 227);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(147, 31);
            this.NextButton.TabIndex = 17;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(378, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 63);
            this.button1.TabIndex = 53;
            this.button1.Text = "Change Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // LevelSearchTextBox
            // 
            this.LevelSearchTextBox.Location = new System.Drawing.Point(234, 316);
            this.LevelSearchTextBox.Name = "LevelSearchTextBox";
            this.LevelSearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.LevelSearchTextBox.TabIndex = 52;
            // 
            // LevelSearchLabel
            // 
            this.LevelSearchLabel.AutoSize = true;
            this.LevelSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelSearchLabel.Image = ((System.Drawing.Image)(resources.GetObject("LevelSearchLabel.Image")));
            this.LevelSearchLabel.Location = new System.Drawing.Point(231, 294);
            this.LevelSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelSearchLabel.Name = "LevelSearchLabel";
            this.LevelSearchLabel.Size = new System.Drawing.Size(91, 17);
            this.LevelSearchLabel.TabIndex = 51;
            this.LevelSearchLabel.Text = "Level Search";
            // 
            // ToonsListBox
            // 
            this.ToonsListBox.FormattingEnabled = true;
            this.ToonsListBox.ItemHeight = 16;
            this.ToonsListBox.Location = new System.Drawing.Point(21, 373);
            this.ToonsListBox.Name = "ToonsListBox";
            this.ToonsListBox.Size = new System.Drawing.Size(486, 84);
            this.ToonsListBox.TabIndex = 44;
            // 
            // LevelCheckBox
            // 
            this.LevelCheckBox.AutoSize = true;
            this.LevelCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LevelCheckBox.BackgroundImage")));
            this.LevelCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LevelCheckBox.Location = new System.Drawing.Point(257, 345);
            this.LevelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LevelCheckBox.Name = "LevelCheckBox";
            this.LevelCheckBox.Size = new System.Drawing.Size(64, 21);
            this.LevelCheckBox.TabIndex = 50;
            this.LevelCheckBox.Text = "Level";
            this.LevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(273, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 63);
            this.button2.TabIndex = 45;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NameCheckBox.BackgroundImage")));
            this.NameCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameCheckBox.Location = new System.Drawing.Point(153, 345);
            this.NameCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(67, 21);
            this.NameCheckBox.TabIndex = 49;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameSearchLabel.Image = ((System.Drawing.Image)(resources.GetObject("NameSearchLabel.Image")));
            this.NameSearchLabel.Location = new System.Drawing.Point(114, 294);
            this.NameSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(94, 17);
            this.NameSearchLabel.TabIndex = 46;
            this.NameSearchLabel.Text = "Name Search";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(143, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 63);
            this.button3.TabIndex = 48;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(117, 316);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.SearchTextBox.TabIndex = 47;
            // 
            // CharacterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(536, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LevelSearchTextBox);
            this.Controls.Add(this.LevelSearchLabel);
            this.Controls.Add(this.ToonsListBox);
            this.Controls.Add(this.LevelCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.NameSearchLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CharacterDetailsGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.HardCheckBox);
            this.Controls.Add(this.TimedCheckBox);
            this.Controls.Add(this.RaceSelectionBox);
            this.Controls.Add(this.CharacterClassSelectionLabel);
            this.Controls.Add(this.CharacterClassSelectionList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterSelectionForm";
            this.Text = "Character Selection";
            this.Load += new System.EventHandler(this.CharacterSelectionForm_Load);
            this.RaceSelectionBox.ResumeLayout(false);
            this.RaceSelectionBox.PerformLayout();
            this.CharacterDetailsGroupBox.ResumeLayout(false);
            this.CharacterDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CharacterClassSelectionLabel;
        private System.Windows.Forms.CheckBox TimedCheckBox;
        private System.Windows.Forms.CheckBox HardCheckBox;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton OrcRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
        private System.Windows.Forms.GroupBox RaceSelectionBox;
        private System.Windows.Forms.ListBox CharacterClassSelectionList;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label MagicLabel;
        private System.Windows.Forms.Label DefenseLabel;
        private System.Windows.Forms.Label HealthPointsLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label ManaPointsLabel;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.Label StrengthPointsLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label DefensePointsLabel;
        private System.Windows.Forms.Label MagicPointsLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label AgilityPointsLabel;
        private System.Windows.Forms.GroupBox CharacterDetailsGroupBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox LevelSearchTextBox;
        public System.Windows.Forms.Label LevelSearchLabel;
        public System.Windows.Forms.ListBox ToonsListBox;
        public System.Windows.Forms.CheckBox LevelCheckBox;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox NameCheckBox;
        public System.Windows.Forms.Label NameSearchLabel;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox SearchTextBox;
    }
}

