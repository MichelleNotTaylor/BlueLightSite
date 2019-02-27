using BlueLightGames.Shared.Orchestrators;
using BlueLightGames.Web.Models;
using System.Web.Mvc;

namespace BlueLightGames.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var projectMemberOrchestrator = new ProjectMemberOrchestrator();
            var projectMemberModel = new MemberModel
            {
                ProjectMembers = projectMemberOrchestrator.GetProjectMembers()
            };

            return View(projectMemberModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}