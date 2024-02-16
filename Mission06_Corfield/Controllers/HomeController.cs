using Microsoft.AspNetCore.Mvc;
using Mission06_Corfield.Models;
using System.Diagnostics;

namespace Mission06_Corfield.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext movies) 
        {
            _context = movies;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult form()
        {
            return View();
        }

       [HttpPost]
       public IActionResult form(JoelContext response)
        {

            _context.Movies.Add(response);
            _context.SaveChanges();

            
            return View("confirmation", response);
        }
    }
}
