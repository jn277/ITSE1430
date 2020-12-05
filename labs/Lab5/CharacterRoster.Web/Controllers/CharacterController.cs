/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Configuration;
using System.Web.Mvc;
using CharacterCreator.Memory;
using CharacterRoster.Web.Models;

namespace CharacterCreator.Memory 
{ 
}
namespace CharacterRoster.Web.Controllers
{
    public class CharacterController : Controller
    {
        public CharacterController ()
        {
            //Gets the CharacterDatabase connection string from the config file
            var connString = ConfigurationManager.ConnectionStrings["CharacterDatabase"].ConnectionString;

           var _database = new MemoryCharacterDatabase(connString);
        }

        // GET: Character
        public ActionResult Index()
        {
            return View();
        }
    }
}