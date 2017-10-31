using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestASPNETCore.Models;

namespace TestASPNETCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var person1 = new Person { Name = "Jon Jonson", Age = 22, Height = 186, Weight = 89 };

            return View(person1);
        }

        public IActionResult Index2()
        {

            return View();
        }
    }
}