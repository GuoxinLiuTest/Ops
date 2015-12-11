using Ops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ops.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        [Route(@"")]
        public ActionResult Index()
        {
            return View(db.Storms.ToList());
        }
    }
}