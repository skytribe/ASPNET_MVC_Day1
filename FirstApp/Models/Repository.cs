using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class Repository
    {
        /// <summary>
        /// Used for return some data for example - usually would be retrieving from a real source...
        /// </summary>
        /// <returns></returns>
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
               new Movie {Title="Star Warsds", Director="George Lucas"},
               new Movie {Title="King Kong", Director="Jackson"},
               new Movie {Title="Star Trek", Director="Abrams"}
            };
        }
    }
}