using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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


        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Create([Bind("Id,MovieName,Genre,Rating,ReleaseYear,ImdbLink")] MovieList movieList)
        {
            if (ModelState.IsValid)
            {
                db.Add(movieList);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movieList);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movieList = await db.MovieList.SingleOrDefaultAsync(m => m.Id == id);
            if (movieList == null)
            {
                return NotFound();
            }
            return View(movieList);
        }

        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieName,Genre,Rating,ReleaseYear,ImdbLink")] MovieList movieList)
        {
            if (id != movieList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(movieList);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieListExists(movieList.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movieList);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movieList = await db.MovieList
                .SingleOrDefaultAsync(m => m.Id == id);
            if (movieList == null)
            {
                return NotFound();
            }

            return View(movieList);
        }

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieList = await db.MovieList.SingleOrDefaultAsync(m => m.Id == id);
            db.MovieList.Remove(movieList);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieListExists(int id)
        {
            return db.MovieList.Any(e => e.Id == id);
        }

    }
}
