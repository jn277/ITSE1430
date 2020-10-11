﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string CharacterName;    //The name of the character.
        public string Profession;       //The profession of the character.
        public string Race;             //The race of the character. 
        public int Attributes;          //A set of numeric attributes that define a character.
        public string Description;      //The optional, biographic details of the character.


        private string _characterName;
        private string _profession;
        private string _race;
        private int _attributes;
        private string _description;
        public string _CharacterName
        {
            get { return _CharacterName ?? ""; }
            set { _CharacterName = value; }
        }
        public string _Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }
        public string _Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int _Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        public string _Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
    }
}
