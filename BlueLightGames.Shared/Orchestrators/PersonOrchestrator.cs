using BlueLightGames.Domain;
using BlueLightGames.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLightGames.Shared.Orchestrators
{
    public class PersonOrchestrator
    {
        private readonly BlueLightContext _blueLightContext;

        public PersonOrchestrator()
        {
            _blueLightContext = new BlueLightContext();
        }

        public List<PersonViewModel> GetAllPeople()
        {
            var people = _blueLightContext.People.Select(x => new PersonViewModel
            {
                PersonId = x.PersonId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToList();

            return people;
        }

    }
}
