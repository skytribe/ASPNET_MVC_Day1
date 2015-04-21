using FirstApp.Models;  // Required for namespace for repository
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class MoviesController : Controller
    {
        //Field used to represent the repository -Gateway into the database in real world.
        private Repository _repository = new Repository();


        // GET: Movies
        public ActionResult Index()
        {
            // Return a list of movies from the repository
            var movies = _repository.ListMovies();

            return View(movies); //this would be modified from the default to return the movies from the repository.
        }
    }
}