using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult login()
        {
            return View();
        }
        
    }
}