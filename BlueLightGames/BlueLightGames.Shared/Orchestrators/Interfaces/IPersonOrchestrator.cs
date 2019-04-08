using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlueLightGames.Shared.Orchestrators.Interfaces
{
    public interface IPersonOrchestrator
    {
        Task<List<PersonViewModel>> GetAllPeople();
        Task<int> CreatePerson(PersonViewModel person);
        Task<bool> UpdatePerson(PersonViewModel person);
        Task<PersonViewModel> SearchPerson(string searchString);
    }
}
