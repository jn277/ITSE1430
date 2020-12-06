/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Collections.Generic;
using System.Linq;

using CharacterCreator;

namespace CharacterCreator
{
    public abstract class ICharacterDatabase : CharacterDatabase
    {
        internal int Id;
    }

    public abstract class CharacterDatabase
    {
        private string Name;

        public ICharacterDatabase Add ( ICharacterDatabase character )
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));
            ObjectValidator.ValidateFullObject(character);

            var existing = GetByName(character.GetByName());
            if (existing != null)
                throw new InvalidOperationException("Movie must be unique");
            try
            {
                return AddCore(character);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Add Failed", e);
            };
        }

        public void Delete ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            try
            {
                DeleteCore(id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Delete Failed", e);
            };
        }
        public ICharacterDatabase Get ( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            try
            {
                return GetByIdCore(id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Get Failed", e);
            };
        }
        public IEnumerable<ICharacterDatabase> GetAll ()
        {
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }
        public void Update ( int id, ICharacterDatabase character )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character  == null)
                throw new ArgumentNullException(nameof(character));
            ObjectValidator.ValidateFullObject(character);

            var existing = GetByName(character.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Movie must be unique");
            try
            {
                UpdateCore(id, character);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Update Failed", e);
            };
        }
        protected abstract ICharacterDatabase AddCore ( ICharacterDatabase character );
        protected abstract void DeleteCore ( int id );
        protected abstract IEnumerable<ICharacterDatabase> GetAllCore ();
        protected abstract ICharacterDatabase GetByIdCore ( int id );
        protected virtual ICharacterDatabase GetByName ( string name )
        {
            foreach (var character in GetAll())
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return character;
            };

            return null;
        }
        protected abstract ICharacterDatabase UpdateCore ( int id, ICharacterDatabase character );
        private string GetByName ()
        {
            throw new NotImplementedException();
        }
    }
    internal class ObjectValidator
    {
        internal static void ValidateFullObject ( ICharacterDatabase character )
        {
            throw new NotImplementedException();
        }
    }
}

