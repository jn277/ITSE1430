/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

namespace CharacterRoster.Web.Controllers
{
    internal class MemoryCharacterDatabase
    {
        private string connString;

        public MemoryCharacterDatabase ( string connString )
        {
            this.connString=connString;
        }
    }
}