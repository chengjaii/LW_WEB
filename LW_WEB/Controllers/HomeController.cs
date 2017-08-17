using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LW_WEB.Controllers
{
    public class HomeController : Controller
    {
        // 首頁
        public ActionResult Index()
        {
            return View();
        }

    }
}