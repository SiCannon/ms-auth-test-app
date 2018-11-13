using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    [Authorize]
    public class PieController : Controller
    {
        // GET: Pie
        public ActionResult Index()
        {
            return View();
        }
    }
}