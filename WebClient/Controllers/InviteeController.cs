using System;
using System.Web.Mvc;

namespace Meiesinge.WebClient.Controllers
{
    public class InviteeController : Controller
    {
        // GET: Invitee
        [Route("Invitee")]
        public ActionResult Index()
        {
            return Test(Guid.Empty);
        }

        [Route("Test/{id}")]
        public ActionResult Test(Guid? id)
        {
            return View("Index",id.Value);
        }
    }
}