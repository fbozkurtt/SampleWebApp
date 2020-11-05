using System;
using System.Runtime.Versioning;
using System.Web.Mvc;

namespace SampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error(int statusCode, Exception exception)
        {
            Response.StatusCode = statusCode;
            ViewBag.StatusCode = statusCode + " " + Languages.Global.error;
            ViewBag.Message = exception.Message;
            return View();
        }
    }
}