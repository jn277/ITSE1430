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
        public ICharacterRoster ()
        {
            var character = new Character() {
                CharacterName = "Donald Helaire",
                Profession = "Fighter",
                Race = "Dwarf",
                Description = "Unknown",
                Attributes = 5,
                CharacterRoster= "Unknown",
            };
            Add(character, out var error);
        }
        
    
        public Character Add( Character character, out string error )
            {
                error = "";
                var item = CloneCharacter(character);
                item.Id = _id++;
                //_characterRoster.Add(item);
                character.Id = item.Id;
                _characterRoster.Add(character);

                return character;
            }

        public void Delete (int id)
            {
                var character = GetById(id);
                if (character == null)
                {
                    _characterRoster.Remove(character);
                };
            }

        public Character[] GetAll ()
            {
                var items = new Character[_characterRoster.Count()];
                var index = 0;
            Character character = null;
            foreach (var movie in _characterRoster)
                    items[index++] = CloneCharacter(character);

                return items;
            }
        public Character Get (int id)
            {
                var character = GetById(id);

                return (character != null) ? CloneCharacter(character) : null;
            }

        private Character GetById ( int id )
            {
                foreach (var character in _characterRoster)
                {
                    if (character?.Id == id)
                    
                        return character;
                };
                return null;
            }

        public string Update ( int id, Character character )
            {
                var existing = GetById(id);
                if (existing == null)
                    return "Character not found";
                CopyCharacter(existing, character);

                return "";
            }

        private Character CloneCharacter ( Character character )
            {
                var item = new Character();
                CopyCharacter(item, character);

                return item;
            }

        private void CopyCharacter ( Character target, Character source )
            {
                target.CharacterName = source.CharacterName;
                target.Profession = source.Profession;
                target.Race = source.Race;
                target.Description = source.Description;
                target.Attributes = source.Attributes;
            }

        private List<Character> _characterRoster = new List<Character>();
        private int _id = 1;

        
        //Character character1 = new Character();

    }
}
