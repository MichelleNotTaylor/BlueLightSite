using BlueLightGames.Shared.Enums;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlueLightGames.Web.Models
{
    public class MemberModel
    {
        public string FirstName { get; set; }
        [Display(Name = "")]
        public string LastName { get; set; }
        [Display(Name = "")]
        public string Email { get; set; }
        [Display(Name = "")]
        public RoleEnum Role { get; set; }
        public string RoleName => Role.ToString();
        public List<ProjectMemberViewModel> ProjectMembers { get; set; }
    }
}