using BlueLightGames.Shared.Enums;
using BlueLightGames.Shared.Orchestrators;
using BlueLightGames.Web.Models;
using System.Web.Mvc;

namespace BlueLightGames.Web.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            var projectMemberOrchestrator = new ProjectMemberOrchestrator();

            var michelle = new MemberModel
            {
                FirstName = "Michelle",
                LastName = "Taylor",
                Email = "mmtaylor3@dmacc.edu",
                Role = RoleEnum.Developer
            };

            return View(michelle);
        }
    }
}