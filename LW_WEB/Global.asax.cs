using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LW_WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_BeginRequest(Object sender,EventArgs e)
        {
            // 先去看cookie的值如果有就顯示cookie的語系,沒有就顯示瀏覽器的語言
            HttpCookie cLang =Request.Cookies["Lang"];
            if (cLang != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture= new System.Globalization.CultureInfo(cLang.Value);
                System.Threading.Thread.CurrentThread.CurrentUICulture= new System.Globalization.CultureInfo(cLang.Value);
            }
        }
    }
}
