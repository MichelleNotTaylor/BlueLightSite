using BlueLightGames.Shared.Orchestrators;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace BlueLightGames.Web.Api
{
    [Route("api/v1/people")]

    public class PersonApiController : ApiController
    {
        private readonly PersonOrchestrator _personOrchestrator;
        public PersonApiController()
        {
            _personOrchestrator = new PersonOrchestrator();
        }

        [HttpGet]
        public List<PersonViewModel> GetAllPeople()
        {
            var people = _personOrchestrator.GetAllPeople();

            return people;
        }
    }
}
