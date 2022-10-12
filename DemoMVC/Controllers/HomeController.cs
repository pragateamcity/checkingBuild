using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "<h1>Hello C# Corner. This is My First MVC APP</h1>";
        }

    }
}
