/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;

using CharacterRoster;

namespace CharacterCreator.Memory
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {
        protected override ICharacterRoster AddCore ( ICharacterRoster character )
        {
            var item = Clonecharacter(character);

            item.Id = _id++;

            _characters.Add(item);

            character.Id = item.Id;
            return character;
        }

        protected override void DeleteCore ( int id )
        {
            var character = FindById(id);
            if (character != null)
            {
                _characters.Remove(character);
            };

        }
        protected override IEnumerable<character> GetAllCore ()
        {
            foreach (var character in _characters)
                yield return Clonecharacter(character);
         }
        protected override character GetByIdCore ( int id )
        {
            var character = FindById(id);

            return (character != null) ? Clonecharacter(character) : null;
        }
        protected override character GetByName ( string name )
        {
            foreach (var character in _characters)
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return Clonecharacter(character);
            };

            return null;
        }
        protected override void UpdateCore ( int id, character character )
        {
            var existing = FindById(id);

            Copycharacter(existing, character);
        }

        private character Clonecharacter ( character character )
        {
            var item = new character();
            item.Id = character.Id;

            Copycharacter(item, character);

            return item;
        }

        private void Copycharacter ( character target, character source )
        {
            target.Name = source.Name;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.RunLength = source.RunLength;
            target.IsClassic = source.IsClassic;
            target.Description = source.Description;
        }

        private character FindById ( int id )
        {
            foreach (var character in _characters)
            {
                if (character?.Id == id)                 
                    return character;
            };

            return null;
        }

        private List<character> _characters = new List<character>(); 
        private int _id = 1;
    }
}
