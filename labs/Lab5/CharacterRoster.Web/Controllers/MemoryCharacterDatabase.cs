/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */
using System;
using CharacterCreator;

namespace CharacterCreator 
{ 
    public class CharacterDatabase
    {

    }
}
namespace CharacterRoster.Web.Controllers
{
    internal class MemoryCharacterDatabase
    {
        private string connString;

        public MemoryCharacterDatabase ( string connString )
        {
            this.connString=connString;
        }

        public void GetAll ( CharacterDatabase _database)
        {

        }
    }
}