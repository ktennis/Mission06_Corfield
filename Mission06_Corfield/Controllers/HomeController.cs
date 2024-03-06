using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Corfield.Models;
using System.Diagnostics;
using System.Linq;

namespace Mission06_Corfield.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext movies)
        {
            _context = movies;
        }

        // Action method to handle requests to the home page
        public IActionResult Index()
        {
            return View();

        }

        // Action method to handle requests to the privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action method to handle GET requests to the form page
        [HttpGet]
        public IActionResult form()
        {
            var newJoel = new Joel
            {
                //Category = "Null", 
                //Title = "Null",
                //Director = "Null"
            };
            return View("form", newJoel);
        }

        // Action method to handle POST requests from the form page
        [HttpPost]
        public IActionResult form(Joel response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("confirmation", response);
            }
            else
            {
                return View(response);
            }
        }

        // Action method to display a table of movies
        public IActionResult movieTable()
        {
            var movies = _context.Movies
                .OrderBy(movie => movie.Title).ToList();

            return View(movies);
        }

        // Action method to handle GET requests to edit a movie
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(movie => movie.MovieId == id);
            return View("form", recordToEdit);
        }

        // Action method to handle POST requests to update movie information
        [HttpPost]
        public IActionResult Edit(Joel updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("movieTable");
        }

        // Action method to handle GET requests to delete a movie
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(movie => movie.MovieId == id);

            return View(recordToDelete);
        }

        // Action method to handle POST requests to delete a movie
        [HttpPost]
        public IActionResult Delete(Joel joel)
        {
            _context.Movies.Remove(joel);
            _context.SaveChanges();

            return RedirectToAction("form");
        }
    }
}
