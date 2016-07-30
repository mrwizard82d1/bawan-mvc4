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
            // Perform HTML encoding to prevent a cross-site scripting attack. (Very, very bad to send raw content to
            // the browser.
            var message = Server.HtmlEncode(name);
            return Content(string.Format("Hello, {0}!", name));
        }

    }
}
