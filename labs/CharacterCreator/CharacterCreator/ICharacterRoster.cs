/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class ICharacterRoster: IValidatableObject
    {
        public ICharacterRoster()
        {
            var character = new IValidatableObject() {
                CharacterName = "",
                Profession = "",
                Race = "",
                Description = "",
                Attributes = 50,
                CharacterRoster= "",
            };
            Add(character, out var error);
        }

        private void Add ( IValidatableObject character, out string error )
        {
            throw new NotImplementedException();
        }

        public ICharacterRoster Add ( ICharacterRoster character, out string error )
        {
            error = "";
            var item = CloneCharacter(character);
            character.Id = _id++;

            return character;
        }

        private object CloneCharacter ( ICharacterRoster character )
        {
            throw new NotImplementedException();
        }

        public void Delete ( int id )
        {
            var character = GetById(id);
            if (character == null)
            {
                _characterRoster.Remove(character);
            };
        }

        public ICharacterRoster[] GetAll ()
        {
            var items = new ICharacterRoster[_characterRoster.Count()];
            var index = 0;

            foreach (var character in _characterRoster)
                items[index++] = character;

            return items;
        }
        public ICharacterRoster Get ( int id )
        {
            var character = GetById(id);
            return (ICharacterRoster)((character != null) ? CloneCharacter(character) : null);
        }

        private ICharacterRoster GetById ( int id )
        {
            foreach (var character in _characterRoster)
            {
                if (character?.Id == id)
                    return character;
            };
            return null;
        }

        public string Update ( int id, ICharacterRoster character )
        {
            var existing = GetById(id);
            if (existing == null)
                return "Character not found";
            CopyCharacter(existing, character);

            return "";
        }

        internal ICharacterDatabase Add ( ICharacterRoster item )
        {
            throw new NotImplementedException();
        }

        private void CopyCharacter ( ICharacterRoster target, ICharacterRoster source )
        {
            target.CharacterName = source.CharacterName;
            target.Profession = source.Profession;
            target.Race = source.Race;
            target.Description = source.Description;
            target.Attributes = source.Attributes;
        }

        private List<ICharacterRoster> _characterRoster = new List<ICharacterRoster>();
        private int _id = 1;

        public ICharacterRoster _CharName = new ICharacterRoster();
        
        public ICharacterRoster _Prof = new ICharacterRoster();

        public ICharacterRoster _Race = new ICharacterRoster();

        public ICharacterRoster _Descrip = new ICharacterRoster();

        public ICharacterRoster _Attrib = new ICharacterRoster(); 
    }
}
