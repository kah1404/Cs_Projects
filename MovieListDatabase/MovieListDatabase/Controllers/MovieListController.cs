using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieListDatabase.Models;

namespace MovieListDatabase.Controllers
{
    public class MovieListController : Controller
    {
        private TestContext db = new TestContext();
            public async Task<IActionResult> Index()
            {
                return View(await db.MovieList.ToListAsync());
            }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MovieList movieList = await db.MovieList.FindAsync(id);
            if (movieList == null)
            {
                return NotFound();
            }

            return View(movieList);
        }
    }
}
