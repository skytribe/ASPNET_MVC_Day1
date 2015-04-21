using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    [RoutePrefix ("Employees")]  // Optional Prefix for Employees as an example Employees/ILIKECAKE will work but /ILIKECAKE wont
    public class EmployeesController : Controller
    {
        // GET: Employees
        [Route("ILikeCake/{id:int}")]
        public ActionResult Index(int id)
        {
            // Return content rather than view
            return Content(String.Format( "You requested the post for ILIKECAKE with ID {0}", id));        
        }
        // GET: Employees
        [Route("ILikeCake")]
        public ActionResult Index( )
        {
            // Return content rather than view
            return Content(String.Format("You requested the post for ILIKECAKE " ));
        }
    }
}