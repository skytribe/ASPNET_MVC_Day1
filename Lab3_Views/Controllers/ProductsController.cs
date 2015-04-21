using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3_Views.Models;


namespace Lab3_Views.Controllers
{
 
    public class ProductsController : Controller
    {
        //Field used to represent the repository -Gateway into the database in real world.
        private Repository _repository = new Repository();


        // GET: Products
        public ActionResult Index()
        {
              // Return a list of movies from the repository
            var movies = _repository.ListProducts();

            return View(movies); //this would be modified from the default to return the movies from the repository.
        }
    }
}