using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blogs Blog/998
        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            // Return content rather than view
            return Content(String.Format("You requested the post for date {0}", entryDate));

  
        }

        // GET: Blogs Blog/12-25-2010
        public ActionResult GetEntryByID(int entryId)
        {
            // Return content rather than view
            return Content(String.Format("You requested the post for ID {0}",  entryId));

        }
    }
}