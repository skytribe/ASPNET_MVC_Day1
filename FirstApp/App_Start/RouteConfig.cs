using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // These entries are very specific to general - more specific to general
            // if order is reverse then it would match general every time and no get to the specific entry.

            //All routes need to controller and actions

            //Blog entry for mapping incoming requests to controller.
            //Do not add the "controller" name on the controller name.
            //Pattern matching 

            routes.MapMvcAttributeRoutes();



            //// This ID will require a constraint
            //routes.MapRoute(
            //    name: "DocumentLookup",
            //    url: "documents/{*path}", 
            //    defaults: new { controller = "Documents", action = "GetDocument" }        
            //    );


            routes.MapRoute(
                name: "IWantMoviesMap",
                url: "{controller}/I/Want/Movies/{action}",
                defaults: new { controller = "Movies", action = "Index" });

            routes.MapRoute(
        name: "IWantMoviesMap2",
        url: "I/Want/Movies/{action}",
        defaults: new { controller = "Movies", action = "Index" });

            //// This ID will require a constraint
            //routes.MapRoute(
            //    name: "BlogByID",
            //    url: "blog/{entryid}",
            //    defaults: new { controller = "Blog", action = "GetEntryByID" },
            //      constraints: new { entryId = @"\d+" }   // regular expression mapping for just a digit
            //    );

            //routes.MapRoute(
            //    name: "BlogByDate",
            //    url: "blog/{entrydate}",
            //    defaults: new { controller = "Blog", action = "GetEntryByDate" }    // This action and controller are weakly typed - if you enter incorrect case then it wont work.              
            //    );


            //Most Generic - don't specify anything the we will go to the HomeController Index or in the case of the commented out version the movies index action
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }   //Change from home will make movies the default controller so will not generate 404 if not on movies view.
                //        defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional }   //Change from home will make movies the default controller so will not generate 404 if not on movies view.




);
        }
    }
}
