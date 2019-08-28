using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitCRUD.BusinessAccessLayer;
using GitCRUD.Repositary;

namespace GitCRUD.Controllers
{
    public class HomeController : Controller
    {
        public BAL Obj = new BAL(new Reposit());

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}