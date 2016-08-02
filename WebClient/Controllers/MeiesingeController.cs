using System.Web.Mvc;

namespace Meiesinge.WebClient.Controllers
{
    public class MeiesingeController : Controller
    {
        [Route("Meiesinge")]
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}