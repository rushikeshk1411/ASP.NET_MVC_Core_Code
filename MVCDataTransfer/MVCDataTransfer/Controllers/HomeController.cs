using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace MVCDataTransfer.Controllers
{
   
    public class HomeController : Controller
    {
        #region ViewData
        public ActionResult Index(int? id, string name, double? price)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["Price"] = price;
            return View();
        }
        #endregion

        #region ViewBag
        public ViewResult Index2(int id, string name, double price)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.price = price;
            return View();
        }
        #endregion

        #region TempDate
        public RedirectToRouteResult index3(int? id, string name, double? price)
        {
            TempData["Id"] = id;
            TempData["Name"] = name;
            TempData["Price"] = price;

            return RedirectToAction("Index4");
        }
        public ViewResult Index4()
        {
            return View();
        }
        public RedirectToRouteResult Index5(int? id, string name, double? price)
        {
            TempData["Id"] = id;
            TempData["Name"] = name;
            TempData["Price"] = price;
            return RedirectToAction("Index1", "Test");
        }
        #endregion

        public ViewResult Index6(int? Id, string Name, double? Price)
        {
            HttpCookie cookie = new HttpCookie("ProductCookies");
            cookie["Id"] = Id.ToString();
            cookie["Name"] = Name;
            cookie["Price"] = Price.ToString();
            cookie.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cookie);
            return View();
        }
        public ViewResult Index7()
        {
            
            return View();
        }
    }
}