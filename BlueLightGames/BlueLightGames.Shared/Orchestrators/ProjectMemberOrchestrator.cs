using BlueLightGames.Shared.Orchestrators.Interfaces;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;

namespace BlueLightGames.Shared.Orchestrators
{
    public class ProjectMemberOrchestrator : IProjectMemberOrchestrator
    {
        public List<ProjectMemberViewModel> GetProjectMembers()
        {
            var members = new List<ProjectMemberViewModel>
            {
                new ProjectMemberViewModel
                {
                    FirstName = "Michelle",
                    LastName = "Taylor",
                    Email = "mmtaylor3@dmacc.edu",
                    Role = Enums.RoleEnum.Developer
                }
            };

            return members;
        }
    }
}
