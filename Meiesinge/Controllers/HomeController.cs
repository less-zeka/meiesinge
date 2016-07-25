using System.Web.Mvc;
using Meiesinge.Models;

namespace Meiesinge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[Authorize(Users = @"DMNJRQE\\less")]
        public ActionResult Invite()
        {
            return View("Invite");
        }

        [HttpPost]
        //[Authorize(Users = @"DMNJRQE\\less")]
        public ActionResult Invite(InvitationViewModel model)
        {
            return View("Invite");
        }

    }
}