using BlueLightGames.Domain;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BlueLightGames.Shared.Orchestrators
{
    public class PersonOrchestrator
    {
        private readonly BlueLightGamesContext _blueLightGamesContext;

        public PersonOrchestrator()
        {
            _blueLightGamesContext = new BlueLightGamesContext();
        }

        public List<PersonViewModel> GetAllPeople()
        {
            var people = _blueLightGamesContext.People.Select(p => new PersonViewModel
            {
                PersonId = p.PersonId,
                FirstName =  p.FirstName,
                LastName = p.LastName,
                DateCreated = p.DateCreated,
                Email = p.Email
            }).ToList();

            return people;
        }
    }
}
