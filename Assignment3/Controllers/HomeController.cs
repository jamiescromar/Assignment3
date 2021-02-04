using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Index.html this is the view for the index
        public IActionResult Index()
        {
            return View();
        }
 
        //This is the view for the podcasts, create and action
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //HttpGet when we go there for the first time
        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();

        }

        //HttpPost: if the user clicks a button then that is a post
        [HttpPost]
        public IActionResult NewMovie(NewMovieResponse movieResponse)
        {
            if (ModelState.IsValid)
            {
                MovieList.AddMovie(movieResponse);
                return View("Confirmation", movieResponse);
            }
            else
            {
                return View();
            }
            
            
        }

        //Action for movie list
        public IActionResult TotalMovieList()
        {
            return View(MovieList.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
