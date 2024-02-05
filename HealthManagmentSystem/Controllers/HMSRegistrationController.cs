using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthManagmentSystem.Controllers
{
    public class HMSRegistrationController : Controller
    {
        // GET: HMSRegistration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult registartionForm()
        {
            return View();
        }
    }
}