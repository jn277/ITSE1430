/*
 * ITSE 1430
 * Donald Helaire
 * Lab3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class ICharacterRoster
    {
        public Character Add ( Character character, out string error )
        {
            error = "";
            for (var index = 0; index < _characterRoster.Length; ++index)
            {
                // Array element access ::=  V[int]
                if (_characterRoster[index] == null)
                {
                    var item = CloneCharacter(character);
                    //Set a unique ID
                    item.Id = _id++;

                    //Add movie to array
                    _characterRoster[index] = item;

                    //Set ID on original object and return
                    character.Id = item.Id;
                    return character;
                };
            };
            error = "No more room";
            return null;
        }

        public Character Delete ()
        {
            
        }

        public Character Get ()
        {
            
        }

        public Character GetAll ()
        {
            
        }

        public Character Update ()
        {

        }

        private Character CloneCharacter ( Character character )
        {
            var item = new Character();
            item.Id = character.Id;
            item.CharacterName = character.CharacterName;
            item.Attributes = character.Attributes;
            item.Description = character.Description;
            item.Profession = character.Profession;
            item.Race = character.Race;
            return item;
        }
        private Character[] _characterRoster = new Character[100]; 
        private int _id = 1;

    }
}
