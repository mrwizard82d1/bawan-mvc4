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
            var message = Server.HtmlEncode(name);
            return Json(new {Message = message, Name = "Mr. Wizard"}, JsonRequestBehavior.AllowGet);
        }

    }
}
