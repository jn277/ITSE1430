/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Collections.Generic;
using CharacterCreator.Memory;

namespace CharacterCreator.Memory
{
    public class MemoryCharacterDatabase : CharacterDatabase
    {
        protected  MemoryCharacterDatabase AddCore ( MemoryCharacterDatabase memoryCharacter )
        {
            var item = CloneMovie(memoryCharacter);

            memoryCharacter._id = _id++;

            memoryCharacter.Add((ICharacterDatabase)item);

            memoryCharacter.Id = memoryCharacter.Id;
            return memoryCharacter;
        }

        private object CloneMovie ( object memoryCharacter )
        {
            throw new NotImplementedException();
        }

        protected override void DeleteCore ( int id )
        {
            var memoryCharacter = FindById(id);
            if (memoryCharacter != null)
            {
                memoryCharacter.Equals(memoryCharacter);
            };

        }
        protected override IEnumerable<ICharacterDatabase> GetAllCore ()
        {
            foreach (var memoryCharacter in Character)
                yield return (ICharacterDatabase)CloneMovie(memoryCharacter);
        }
        protected override ICharacterDatabase GetByIdCore ( int id )
        {
            var memoryCharacter = FindById(id);

            return (memoryCharacter != null) ? (ICharacterDatabase)CloneMovie(memoryCharacter) : null;
        }
        protected override ICharacterDatabase GetByName ( string name )
        {
            foreach (var memoryCharacter in Character)
            {
                //if (String.Compare(Character.Equals(), true) != 0)
                    //continue;
                return (ICharacterDatabase)CloneMovie(memoryCharacter: memoryCharacter);
            };

            return null;
        }
        //protected void UpdateCore ( int id, ICharacterDatabase memoryCharacter )
        //{
            //var existing = FindById(id);
        //}

        ICharacterDatabase CloneMovie ( ICharacterRoster memoryCharacter )
        {
            var item = new ICharacterRoster();
            item.Id = memoryCharacter.Id;

            CopyMovie(item, memoryCharacter);

            return item.Add(item);
        }
        private void CopyMovie ( ICharacterRoster target, ICharacterRoster source )
        {
            target._CharName = source._CharName;
            target._Attrib = source._Attrib;
            target._Descrip = source._Descrip;
            target._Prof = source._Prof;
            target._Race = source._Race;
        }
        private ICharacterRoster FindById ( int id )
        {
            foreach (var memoryCharacter in Character)
            {
                //if ((ICharacterRoster)Character.Equals() == id)                 
                    return (ICharacterRoster)Character;
            };

            return null;
        }

        protected override ICharacterDatabase AddCore ( ICharacterDatabase character )
        {
            throw new NotImplementedException();
        }

        protected override ICharacterDatabase UpdateCore ( int id, ICharacterDatabase character )
        {
            throw new NotImplementedException();
        }

        private List<ICharacterDatabase> _movies = new List<ICharacterDatabase>(); 
        private int _id = 1;
        private object Id;
        private IEnumerable<object> Character;
        private object memoryCharacter;

        private class existing
        {
        }
    }
}
