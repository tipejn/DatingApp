using DatingApp.Models;
using DatingApp.Models.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DatingApp.Controllers
{
    public class ResultController : Controller
    {
        private DatingRepository repo;
        private IEnumerable<IPersonValidator> validators;
        public ResultController(DatingRepository repo, IEnumerable<IPersonValidator> validators)
        {
            this.repo = repo;
            this.validators = validators;
        }
        public ViewResult Index()
        {
            return View(new PersonMatcher(validators)
            {
                Woman = repo.GetPerson(Gender.Female),
                Man = repo.GetPerson(Gender.Male)
            });
        }
    }
}
