using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeTofood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        public ActionResult Search(string name)
        {
            // Because the name parameter is not present in the `Index` action of the `Home` controller, this 
            // (temporary) redirect results in MVC simply appending the query string, for example, "?name=swedish," for
            // the route "/Cuisine/swedish."
            return RedirectToAction("Index", "Home", new {name = name});
        }

    }
}
