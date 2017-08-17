using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LW_WEB.Controllers
{
    public class DefaultController : Controller
    {
        // 首頁
        public ActionResult Index()
        {
            return View();
        }

        //應用程式
        public ActionResult SystemApplication()
        {
            return View();
        }
        // 行事曆
        public ActionResult Calender()
        {
            return View();
        }

        // 說明
        public ActionResult Description()
        {
            return View();
        }

        // 設定
        public ActionResult SystemSetup()
        {
            return View();
        }


    }
}