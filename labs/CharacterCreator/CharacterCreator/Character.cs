using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string characterName;    //The name of the character.
        public string profession;       //The profession of the character.
        public string race;             //The race of the character. 
        public int attributes;          //A set of numeric attributes that define a character.
        public string description;      //The optional, biographic details of the character.


        private string _characterName = " ";
        private string _profession = "Fighter, Hunter, Priest, Rogue, Wizard";
        private string _race = "Dwarf, Elf, Gnome, Half Elf, Human";
        private int _attributes = 100;
        private string _description = "";
    }
}
