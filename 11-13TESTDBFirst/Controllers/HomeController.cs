using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11_13TESTDBFirst.Models; //Need to add this and add .Models to the end

namespace _11_13TESTDBFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddItemPage()
        {
            return View();
        }

        public ActionResult AddItem(Item newItem)
        {
            TestDBFirstEntities ORM = new TestDBFirstEntities();
            ORM.Items.Add(newItem);
            ORM.SaveChanges();
            ViewBag.AddedItem = "Item was successfully added";
            return View("AddItemPage");
            //ORM.Users.Add(newUser);
            //ORM.Items.Where(x => x.Name == "Banana"); //Select * from Items where Name = 'Banana'

        }
    }
}