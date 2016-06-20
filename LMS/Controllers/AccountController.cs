using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using LMS.Model;
using LMS.BLL;

namespace LMS.Controllers
{
    public class AccountController : Controller
    {
        LMS.BLL.AdminBLL bll = new LMS.BLL.AdminBLL();
        public ActionResult index()
        {
            return View();
        }
        public ActionResult login()
        {
            //bll.Islogin();
            return View();
        }
        [HttpPost]
        public ActionResult login(string name,string pwd)
        {
            bll.Islogin(name, pwd);
            return View();
        }
        public ActionResult result()
        {
            return View();
        }

        
    }
}