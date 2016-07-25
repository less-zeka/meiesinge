using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Web.Mvc;
using Meiesinge.Models;

namespace Meiesinge.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model.Name == "chrigi" && model.Password == "super")
            {
             
                Debug.WriteLine(User.Identity.Name);   
            }
            return View();
        }
    }
}