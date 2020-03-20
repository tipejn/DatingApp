using DatingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    public class ManController : Controller
    {
        private DatingRepository repo;
        public ManController(DatingRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Start()
        {
            return View("Person", new Person
            {
                Gender = Gender.Male
            });
        }

        public IActionResult Next(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View("Person", person);
            }

            repo.AddPerson(person);
            return RedirectToAction("Index", "Result");
        }
    }
}
