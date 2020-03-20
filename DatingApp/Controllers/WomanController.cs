using DatingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    public class WomanController : Controller
    {
        private DatingRepository repo;
        public WomanController(DatingRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Start()
        {
            return View("Person", new Person
            {
                Gender = Gender.Female
            });
        }

        public IActionResult Next(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View("Person", person);
            }

            repo.AddPerson(person);
            ModelState.Clear();

            return RedirectToAction("Start", "Man");
        }
    }
}
