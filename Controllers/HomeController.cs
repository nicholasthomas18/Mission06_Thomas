using Microsoft.AspNetCore.Mvc;
using Movie_Collection.Models;
using System.Diagnostics;

namespace Movie_Collection.Controllers
{
    public class HomeController : Controller
    {
        private EnterMoviesContext _context;
        public HomeController(EnterMoviesContext temp) // Constructor
        { 
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovies(Film film)
        {
            _context.Films.Add(film);
            _context.SaveChanges();
            
            return View("Confirm", film);
        }
    }
}
