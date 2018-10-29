using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Out_of_Class_Practice1.Controllers
{
    public class HomeController : Controller
    {
        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
        // GET: Index
        public ActionResult Index()
        {

            Queue<string> customers = new Queue<string>();
            Dictionary<string, int> customerLine = new Dictionary<string, int>();
            string name;

            for (int i = 0; i<=100; i++)
            {
                name = randomName();
                customers.Enqueue(name);
                if(customerLine.ContainsKey(name))
                {
                    customerLine[name] += randomNumberInRange();
                }else
                {
                    customerLine[name] = randomNumberInRange();
                }

            }
            ViewBag.Results=customerLine;
            return View();
        }
        public static string practiceName()
        {
            System.String Drexler = "My name is Drexler";
            ViewBag.Results = Drexler;
            return View("Index");
        }

    }
}