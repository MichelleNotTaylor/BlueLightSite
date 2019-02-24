using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;

namespace BlueLightGames.Shared.Orchestrators.Interfaces
{
    interface IProjectMemberOrchestrator
    {
        List<ProjectMemberViewModel> GetProjectMembers();
    }
}
