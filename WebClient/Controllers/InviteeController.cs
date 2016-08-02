using System;
using System.Web.Mvc;
using Meiesinge.WebClient.DAL;
using Meiesinge.WebClient.Models;

namespace Meiesinge.WebClient.Controllers
{
    public class InvitationController : Controller
    {
        [Route("Invitation/{guid?}")]
        [HttpGet]
        public ActionResult Index(Guid? guid)
        {
            var model = new InvitationViewModel {Host = "Chrigi"};

            using (var context = new MeiesingeContext())
            {
                var invitee = context.Invitees.Find(guid);
                if (invitee != null)
                {
                    model.Guid = invitee.Id;
                    model.Invitee = invitee.InviteeName;
                }
            }
            return View("Index", model);
        }

        [Route("Invitation/Accept")]
        [HttpPost]
        public ActionResult Accept(InvitationViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new MeiesingeContext())
                {
                    var entity = context.Invitees.Find(model.Guid);
                    if (entity != null)
                    {
                        var artist = new Artist{Name = model.Invitee};
                        context.Artists.Add(artist);
                        context.SaveChanges();
                    }
                }
            }
            return View("Index", model);
        }
    }
}