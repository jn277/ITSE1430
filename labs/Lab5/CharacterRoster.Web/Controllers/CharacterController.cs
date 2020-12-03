using System;
using System.Configuration;
using System.Web.Mvc;

using CharacterRoster.Web.Models;


namespace CharacterRoster.Web.Controllers
{
    public class CharacterController : Controller
    {
        public CharacterController ()
        {
            //Gets the CharacterDatabase connection string from the config file
            var connString = ConfigurationManager.ConnectionStrings["MemoryCharacterDatabase"].ConnectionString;

           //var _database = new MemoryCharacterDatabase.MemoryCharacterDatabase(connString);
        }

        // GET: Character
        public ActionResult Index()
        {
            return View();
        }
    }
}