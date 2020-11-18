/*
 * ITSE 1430
 * Donald Helaire
 * Lab4
 */

using System;
using System.Collections.Generic;
using System.Linq;

using CharacterCreator;

namespace CharacterRoster
{
    public abstract class CharacterDatabase : ICharacterRoster 
    {
        public ICharacterRoster Add ( ICharacterRoster character )
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));  
                ObjectValidator.ValidateFullObject(character);
   
            var existing = GetByName(character.CharacterName);
            if (existing != null)
                throw new InvalidOperationException("character must be unique");
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
        public IEnumerable<ICharacterRoster> GetAll ()
        {
            try
            {
                return GetAllCore();
            } catch (Exception e)
            {
                throw new InvalidOperationException("GetAll Failed", e);
            };
        }
        public ICharacterRoster Get ( int id )
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
        public void Update ( int id, ICharacterRoster character )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character == null)
                throw new ArgumentNullException(nameof(character));       
                ObjectValidator.ValidateFullObject(character);

            var existing = GetByName(CharacterName);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Character name must be unique");       
            try
            {
                UpdateCore(id, Id);
            } catch (Exception e)
            {
                throw new InvalidOperationException("Update Failed", e);
            };
        }
        protected abstract ICharacterRoster AddCore ( ICharacterRoster character );

        protected abstract void DeleteCore ( int id );
        protected virtual ICharacterRoster GetByName ( string name )
        {
            foreach (var character in GetAll())
            {
                if (String.Compare(character.CharacterName, name, true) == 0)
                    return character;
            };

            return null;
        }

        protected abstract IEnumerable<ICharacterRoster> GetAllCore ();

        protected abstract ICharacterRoster GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, ICharacterRoster character );
    }
}

