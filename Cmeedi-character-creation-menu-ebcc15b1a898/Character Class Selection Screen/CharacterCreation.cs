using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Character_Class_Selection_Screen
{

    
    //This struct has duplicate variables of the Character class
    struct Characters
    {
        public string name;
        public int health;
        public int mana;
        public int level;
        public string classes;

        //These will be used in the future
        //public int id;
        //public int strength;
        //public int agility;
        //public int defense;
        //public int magic;
    }


    public partial class CharacterSelectionForm : Form
    {
        //I created an object of WindowsMediaPlayer and called it "player" (Playa Playa)
        WindowsMediaPlayer player = new WindowsMediaPlayer();


        //A new instance of the "CharacterSelection" Class is created
        CharactersSelection charsel = new CharactersSelection();


        //This is a list created to hold all the "characters" that we are going to be able to create
        List<Characters> myCharactersList = new List<Characters>(4);


        
        //We create a list of the "Characters" to keep track of them all
        Characters characters = new Characters();

        //This is an enum declaration with 4 enums that have been assigned thaier corresponding int values
//        enum CharacterCodes { 
//            Echaracter = 0, 
//            Ename = 1, 
//            Ehealth = 2, 
//            Emana = 3,
//            Elevel = 4,
//            Eclass = 5
//        }


        public CharacterSelectionForm()
        {
            InitializeComponent();
            player.URL = "If-Dinner-was-served-for-Breakfast.mp3";

        }


        private void getData(ref Characters characters)
        {
            //As mentioned above the "Toons" struct has duplicate information of the "Character" class
            //and here we have a method to link the information of the class to the struct variables
            try
            {
                Character ch = new Character(NameTextBox.Text);
                characters.name = ch.Name;
                characters.health = ch.Health;
                characters.mana = ch.Mana;
                //characters.strength = ch.Strength;
                //characters.agility = ch.Agility;
                //characters.defense = ch.Defense;
                //characters.magic = ch.Magic;
                characters.level = ch.Level;
                characters.classes = ch.Classes;                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //This is the Create
        private void OKButton_Click(object sender, EventArgs e)
        {

            //We call the "createCharacter()" Method
            createCharacter();
        }


        public void createCharacter()
        {
            //Then we call the "getData()" method to link the information from the "Character" Class
            getData(ref characters);
            //Once we click the add button then we create a "toon" and get the data with the "getData()" method
            //and then add it to our "toonsList"
            myCharactersList.Add(characters);

            //then call the "display()" method to display the information in out listBox
            display();

            //Here we create a String data type to later use
            string character;

            //This creates a new instance of the character class called "player" and allowing the name to be changed via the "NameTextBox" TextBox
            Character player = new Character(NameTextBox.Text);


            //Here we have a Short-Circuit
            if (HumanRadioButton.Checked || OrcRadioButton.Checked)
            {
                //The Selection list index starts at zero.
                //If nothing is selected then by default the SelectedIndex is "-1" which displays nothing
                if (CharacterClassSelectionList.SelectedIndex != -1)
                {
                    //Here we use the character String in order to convert the Character Selection into a String
                    character = CharacterClassSelectionList.SelectedItem.ToString();


                    //This switch statement uses the Character String assignment to be able to create a case for each class
                    switch (character)
                    {
                        case "Ranger":
                            //This uses the radio button Human,  Since there's only 2 races anything other than human is orc
                            if (HumanRadioButton.Checked)
                            {
                                //This pulls the picture from the image index which is linked to 
                                //the picture label to display which picture is associated with that index
                                PictureLabel.ImageIndex = 1;
                                player.Defense += 10;
                                player.Classes = CharacterClassSelectionList.SelectedIndex.ToString();
                            }
                            else
                            {
                                PictureLabel.ImageIndex = 3;
                                player.Strength += 10;
                                player.Classes = "Ranger";

                            }

                            player.Classes = "Ranger";



                            //The Ranger class adds a 5 point bonus to agility
                            player.Agility += 5;
                            break;

                        //Each case is assigned to each word in the list box and displays the character accordingly
                        case "Warrior":

                            //The Humans get a 10 point Defense bonus
                            if (HumanRadioButton.Checked)
                            {
                                PictureLabel.ImageIndex = 0;
                                player.Defense += 10;
                            }
                            //The Orcs get a 10 point Strenth bonus
                            else
                            {
                                PictureLabel.ImageIndex = 4;
                                player.Strength += 10;
                            }

                            player.Classes = "Warrior";



                            //The warrior class adds a 5 point bonus to Strength
                            player.Strength += 5;
                            break;

                        case "Wizard":
                            if (HumanRadioButton.Checked)
                            {
                                PictureLabel.ImageIndex = 2;
                                player.Defense += 10;
                            }
                            else
                            {
                                PictureLabel.ImageIndex = 5;
                                player.Strength += 10;
                            }

                            player.Classes = "Wizard";



                            //The wizard class adds a 5 point bonus to magic
                            player.Magic += 5;
                            break;
                    }


                    if (HardCheckBox.Checked && TimedCheckBox.Checked)
                    {
                        //This creates an object of the Dialogue box that appears after checking a box and pressing ok
                        DialogResult dr = MessageBox.Show("By selecting these two options you are entering Champion mode.  Are you sure you want to continue",
                             "Champion Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.No)
                        {
                            HardCheckBox.Checked = false;
                            TimedCheckBox.Checked = false;
                        }
                    }
                    else if (HardCheckBox.Checked)
                    {
                        DialogResult dr = MessageBox.Show("You've selected hard mode.  Are you sure you want to continue",
                            "Hard Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //If the hardmode box is checked then the players attributes get adjusted to increase the difficulty
                        player.Health = player.Health / 2;
                        player.Mana = player.Mana / 2;
                        player.Strength -= 9;
                        player.Agility -= 9;
                        player.Magic -= 9;


                        if (dr == DialogResult.No)
                        {
                            HardCheckBox.Checked = false;
                        }
                    }
                    else if (TimedCheckBox.Checked)
                    {
                        DialogResult dr = MessageBox.Show("You will be timed.  Are you sure you want to continue", "Timed Mode", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            TimedCheckBox.Checked = false;
                        }
                    }


                    //Here We assign each attribute to its corresponding label on the form to be displayed

                    HealthPointsLabel.Text = player.Health.ToString();
                    ManaPointsLabel.Text = player.Mana.ToString();
                    StrengthPointsLabel.Text = player.Strength.ToString();
                    AgilityPointsLabel.Text = player.Agility.ToString();
                    DefensePointsLabel.Text = player.Defense.ToString();
                    MagicPointsLabel.Text = player.Magic.ToString();

                }

                else
                {
                    //
                    MessageBox.Show("Please select a Class", "Class not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Race", "Race not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //This is the Read
        //This is our "display()" method
        private void display()
        {

            //A placeholder is created to hold our data
            string output;

            //We clear our listbox
            //charsel.
                ToonsListBox.Items.Clear();

            //Now for each of our "toons" in "toonsList" we assign the name and level of the toon to "output"
            //and then display "output" to the listbox
            //This displays the "toons" name and level
            foreach(Characters characters in myCharactersList)
            {
                output = characters.name + " is level " + characters.level;


                //charsel.
                ToonsListBox.Items.Add(output);
            }
        }

        //This is the search method.  With this method we can search for "toons" using select parameters
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            //We clear the listbox in the "CharacterSelection" menu
            //charsel.
            ToonsListBox.Items.Clear();

            //and create a placeholder
            string output;

            //We do the same thing as the display method pretty much

            //if the "NameCheckBox" is checked then the search commences
            if (NameCheckBox.Checked)
            {
                //We pull each character in the list
                foreach (Characters characters in myCharactersList)
                {
                     if (SearchTextBox.Text == characters.name)
                    {
                        //And assign them to "output" with concatonations
                        output = characters.name + " is level " + characters.level;

                        //And display them to the list
                        ToonsListBox.Items.Add(output);
                    }
                }
            }
            //if the "LevelCheckBox" is checked then the search commences

            else if (LevelCheckBox.Checked)
            {
                foreach(Characters characters in myCharactersList)
                {
                    if(int.Parse(LevelSearchTextBox.Text) == characters.level)
                    {
                        output = characters.name + " is level " + characters.level;

                        ToonsListBox.Items.Add(output);
                    }
                }
            }
            //if the "NameCheckBox" and "LevelCheckBox" is checked then the search commences
            else if (NameCheckBox.Checked && LevelCheckBox.Checked) 
            {
                foreach(Characters characters in myCharactersList)
                {
                    while(SearchTextBox.Text == characters.name && int.Parse(LevelSearchTextBox.Text) == characters.level)
                    {
                        output = characters.name + " is level " + characters.level;
                        ToonsListBox.Items.Add(output);

                    }
                }
            }

            else
            {
                ToonsListBox.Items.Clear();
                //Then the display method is called to display the items
                display();
                MessageBox.Show("The character you are looking for could not be found");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //We clear the listbox in the "CharacterSelection" menu
            //charsel.
            ToonsListBox.Items.Clear();

            //and create a placeholder 
            string output;

            //We do the same thing as the display method pretty much

            //if the "NameCheckBox" is checked then the search commences
            if (NameCheckBox.Checked)
            {
                //We pull each character in the list and compare it to "SearchTextBox"
                for(int i = myCharactersList.Count-1; i >= -1; i--)
                {
                    if(SearchTextBox.Text == characters.name)
                   {
                        myCharactersList.Remove(characters);

                    }
                }
            }

            display();
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Self explanatory but if you must know this closes the program
            this.Close();
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            //This opens up the "CharacterSelection" menu
            charsel.ShowDialog();
        }

        private void CharacterSelectionForm_Load(object sender, EventArgs e)
        {
            //This is to start the music when the program gets executed
            player.controls.play();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //after searching for the character you can change their name by typing a new name
        //in the text box with "Player Name" and hit the "Change Name" button
        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            //We clear the listbox in the "CharacterSelection" menu
            //charsel.
            ToonsListBox.Items.Clear();

            //and create a placeholder 
            string output;

            //We do the same thing as the display method pretty much

            //if the "NameCheckBox" is checked then the search commences
            if (NameCheckBox.Checked)
            {
                //We pull each character in the list and compare it to "SearchTextBox"
                for (int i = myCharactersList.Count - 1; i >= -1; i--)
                {
                    if (SearchTextBox.Text == characters.name)
                    {
                        characters.name = NameTextBox.Text;

                    }
                }
            }
       }
    }

    //Created and Developed
    //by Chester Meedi
    //CST - 117
}



