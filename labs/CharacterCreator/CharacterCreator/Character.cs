﻿/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CharacterCreator
{
    public class IValidatableObject
    {
        private string _characterName;      //The name of the character.
        private string _characterRoster;    //The name of the character in roster.
        private string _profession;         //The profession of the character.
        private string _race;               //The race of the character. 
        private int _attributes;            //A set of numeric attributes that define a character.
        private string _description;        //The optional, biographic details of the character.
        public int Id = 100;
        public string CharacterName
        {
            get { return _characterName ?? ""; }
            set { _characterName = value; }
        }

        public string CharacterRoster
        {
            get { return _characterRoster ?? ""; }
            set { _characterRoster = value; }
        }
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public string Validate ()
        {
             
            if (String.IsNullOrEmpty(_characterName)) 
                return "Name is required";

            if (String.IsNullOrEmpty(_characterRoster))
                return "Name is required";

            if (String.IsNullOrEmpty(_profession)) 
                return "Profession is required";

            if (String.IsNullOrEmpty(_race)) 
                return "Race is required";

            if (_attributes  > 100)
                return "The attribute number cannot exceed 100";

            if (String.IsNullOrEmpty(_description)) 
                return "Description is required";
            return null;
        }
       
    }
}
