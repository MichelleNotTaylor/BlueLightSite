using BlueLightGames.Shared.Enums;

namespace BlueLightGames.Shared.ViewModels
{
    public class ProjectMemberViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public RoleEnum Role { get; set; }
    }
}
