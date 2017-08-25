using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LW_WEB.Models.TestModels;

namespace LW_WEB.Controllers
{
    public class DefaultController : Controller
    {
        private Entities db = new Entities();
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
            //Controller用ViewData傳遞資料使用方式
            ViewData["Message_ViewData"] = "Controller用ViewData傳遞資料使用方式";

            //Controller用ViewBag傳遞資料使用方式
            ViewBag.Message_ViewBag = "Controller用ViewBag傳遞資料使用方式";

            //Controller用TempData傳遞資料使用方式
            TempData["Message"] = "Controller用TempData傳遞資料使用方式";

            return View();
        }

        //ITEM_MST
        public ActionResult ItemMST()
        {
            //Controller讀取Model：讀取已建之ItemMSTModel.edmx
            var routes = db.ITEM_MST.Take(10);
            return View(routes.ToList());
        }
    }
}