using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents parameter must patch name in routings
        public ActionResult GetDocument(string path)
        {
            return View();

            // Return content rather than view
         //   return Content(String.Format("You requested the document {0}", path));
        }
    }
}