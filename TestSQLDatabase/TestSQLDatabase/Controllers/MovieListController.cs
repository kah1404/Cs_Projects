using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSQLDatabase.Models;

namespace TestSQLDatabase.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult Index()
        {
            TestContext db = new TestContext();

            return View(db.MovieList.ToList());
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
