using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Character_Class_Selection_Screen
{

    //This is the Class that is going to represent the character and it's attributes
    class Character
    {
        //Here are the basic attributes of the character
        private int id;
        private string name;
        private int health;
        private int mana;
        private int strength;
        private int agility;
        private int defense;
        private int magic;
        private int level;
        private string classes;
        

        //This is the loaded constructor allowing a string parameter for the name and all the attributes for the character
        public Character(string name)
        {
            this.id = 0;
            this.name = name;
            health = 100;
            mana = 100;
            strength = 10;
            agility = 10;
            defense = 10;
            magic = 10;
            level = 0;
            classes = null;
        }

        //Here are the Getters and Setters for the attributes to allow them to be set and retrieved by other classes
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Mana { get => mana; set => mana = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Magic { get => magic; set => magic = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Level { get => level; set => level = value; }
        public string Classes { get => classes; set => classes = value; }
    }



    //Upon adding the Character class I have implemented these properties not only by creating a new instance of the class, 
    // using a text box to input the characters name, but also by adding a bonus to each class selected and each race selected.
    //I have also adjusted the attributes when selecting hard mode to add more difficulty.  

    //I edited the form design to allow these changes to be visible.

    //Milestone Project
    //Chester Meedi
    //CST - 117
}
