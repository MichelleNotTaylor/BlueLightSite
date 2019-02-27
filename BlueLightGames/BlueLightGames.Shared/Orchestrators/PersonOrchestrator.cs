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
            var people = _blueLightGamesContext.People.Select(x => new PersonViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToList();

            return people;
        }
    }
}
