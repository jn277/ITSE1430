/*
 * ITSE 1430
 * Donald Helaire
 * Lab5
 */

using System;
using System.Configuration;
using System.Web.Mvc;
using CharacterCreator;
using CharacterCreator.Memory;
using CharacterRoster.Web.Models;

namespace CharacterCreator.Memory 
{ 
}
namespace CharacterRoster.Web.Controllers
{
    public class CharacterController : Controller
    {
        private object id;

        public CharacterController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["CharacterDatabase"].ConnectionString;

            var _database = new MemoryCharacterDatabase(connString);
        }
        public ActionResult Index()
        {
            var character = _database.GetAll();

            //var model = character.Select(x => new CharacterModel(x));
            var model = character;

            return View("List", model);
        }
        public ActionResult Details (int id)
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        public ActionResult Edit ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        [HttpPost]
        public ActionResult Edit ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                _database.Update(model.Id, model.ToCharacter());
            };

            return View(model);
        }
        public ActionResult Create () => View(new CharacterModel());

        [HttpPost]
        public ActionResult Create ( CharacterModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var character = _database.Add(model.ToCharacter());

                    return RedirectToAction(nameof(Details), new { id = model.Id });
                } catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                };
            };

            return View(model);
        }

        public ActionResult Delete ( int id )
        {
            var character = _database.Get(id);
            if (character == null)
                return HttpNotFound();

            return View(new CharacterModel(character));
        }

        [HttpPost]
        public ActionResult Delete ( CharacterModel character )
        {
            try
            {
                _database.Delete(character.Id);

                return RedirectToAction(nameof(Index));
            } catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            };

            return View(character);
        }

    }
    internal class _database
    {
        internal static object Add ( object v )
        {
            throw new NotImplementedException();
        }

        internal static void Delete ( int id )
        {
            throw new NotImplementedException();
        }

        internal static object Get ( object id )
        {
            throw new NotImplementedException();
        }

        internal static object GetAll ()
        {
            throw new NotImplementedException();
        }

        internal static void Update ( int id, object p )
        {
            throw new NotImplementedException();
        }
    }
}