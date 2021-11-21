namespace Character_Class_Selection_Screen
{
    partial class CharactersSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharactersSelection));
            this.button1 = new System.Windows.Forms.Button();
            this.ToonsListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NameSearchLabel = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.LevelCheckBox = new System.Windows.Forms.CheckBox();
            this.LevelSearchLabel = new System.Windows.Forms.Label();
            this.LevelSearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(508, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 63);
            this.button1.TabIndex = 43;
            this.button1.Text = "Change Name";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ToonsListBox
            // 
            this.ToonsListBox.FormattingEnabled = true;
            this.ToonsListBox.ItemHeight = 16;
            this.ToonsListBox.Location = new System.Drawing.Point(151, 231);
            this.ToonsListBox.Name = "ToonsListBox";
            this.ToonsListBox.Size = new System.Drawing.Size(486, 84);
            this.ToonsListBox.TabIndex = 34;
            this.ToonsListBox.SelectedIndexChanged += new System.EventHandler(this.ToonsListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(403, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 63);
            this.button2.TabIndex = 35;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // NameSearchLabel
            // 
            this.NameSearchLabel.AutoSize = true;
            this.NameSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameSearchLabel.Image = ((System.Drawing.Image)(resources.GetObject("NameSearchLabel.Image")));
            this.NameSearchLabel.Location = new System.Drawing.Point(244, 152);
            this.NameSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameSearchLabel.Name = "NameSearchLabel";
            this.NameSearchLabel.Size = new System.Drawing.Size(94, 17);
            this.NameSearchLabel.TabIndex = 36;
            this.NameSearchLabel.Text = "Name Search";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(247, 174);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(100, 22);
            this.SearchText.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(273, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 63);
            this.button3.TabIndex = 38;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NameCheckBox.BackgroundImage")));
            this.NameCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameCheckBox.Location = new System.Drawing.Point(283, 203);
            this.NameCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(67, 21);
            this.NameCheckBox.TabIndex = 39;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // LevelCheckBox
            // 
            this.LevelCheckBox.AutoSize = true;
            this.LevelCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LevelCheckBox.BackgroundImage")));
            this.LevelCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LevelCheckBox.Location = new System.Drawing.Point(387, 203);
            this.LevelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LevelCheckBox.Name = "LevelCheckBox";
            this.LevelCheckBox.Size = new System.Drawing.Size(64, 21);
            this.LevelCheckBox.TabIndex = 40;
            this.LevelCheckBox.Text = "Level";
            this.LevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // LevelSearchLabel
            // 
            this.LevelSearchLabel.AutoSize = true;
            this.LevelSearchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelSearchLabel.Image = ((System.Drawing.Image)(resources.GetObject("LevelSearchLabel.Image")));
            this.LevelSearchLabel.Location = new System.Drawing.Point(361, 152);
            this.LevelSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelSearchLabel.Name = "LevelSearchLabel";
            this.LevelSearchLabel.Size = new System.Drawing.Size(91, 17);
            this.LevelSearchLabel.TabIndex = 41;
            this.LevelSearchLabel.Text = "Level Search";
            // 
            // LevelSearchTextBox
            // 
            this.LevelSearchTextBox.Location = new System.Drawing.Point(364, 174);
            this.LevelSearchTextBox.Name = "LevelSearchTextBox";
            this.LevelSearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.LevelSearchTextBox.TabIndex = 42;
            // 
            // CharactersSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LevelSearchTextBox);
            this.Controls.Add(this.LevelSearchLabel);
            this.Controls.Add(this.ToonsListBox);
            this.Controls.Add(this.LevelCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.NameSearchLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchText);
            this.Name = "CharactersSelection";
            this.Text = "Characters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox ToonsListBox;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label NameSearchLabel;
        public System.Windows.Forms.TextBox SearchText;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckBox NameCheckBox;
        public System.Windows.Forms.CheckBox LevelCheckBox;
        public System.Windows.Forms.Label LevelSearchLabel;
        public System.Windows.Forms.TextBox LevelSearchTextBox;
    }
}