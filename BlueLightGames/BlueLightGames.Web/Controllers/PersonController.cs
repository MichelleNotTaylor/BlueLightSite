using BlueLightGames.Shared.Orchestrators.Interfaces;
using BlueLightGames.Shared.ViewModels;
using BlueLightGames.Web.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlueLightGames.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonOrchestrator _personOrchestrator;

        public PersonController(IPersonOrchestrator personOrchestrator)
        {
            _personOrchestrator = personOrchestrator;
        }

        // GET: Person
        public async Task<ActionResult> Index()
        {
            var personDisplayModel = new PersonDisplayModel
            {
                People = await _personOrchestrator.GetAllPeople()
            };

            return View(personDisplayModel);
        }

        public async Task<ActionResult> Create(CreatePersonModel person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                return View();
            }

            var updatedCount = await _personOrchestrator.CreatePerson(new PersonViewModel
            {
                PersonId = Guid.NewGuid(),
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateCreated = person.DateCreated,
                Email = person.Email
            });

            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public async Task<JsonResult> UpdatePerson(UpdatePersonModel person)
        {
            if(person.PersonId == Guid.Empty)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            var result = await _personOrchestrator.UpdatePerson(new PersonViewModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = person.Email
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public async Task<JsonResult> Search(string searchString)
        {
            var viewModel = await _personOrchestrator.SearchPerson(searchString);

            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}