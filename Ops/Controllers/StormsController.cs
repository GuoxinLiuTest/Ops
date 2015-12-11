using Ops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ops.Controllers
{
    public class StormsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Storm
        [AllowAnonymous]
        [Route(@"employees")]
        public ActionResult Index()
        {
            return View(db.Storms.ToList());
        }

        [AllowAnonymous]
        [Route(@"employees/create")]
        public ActionResult Create()
        {
            return View();
        }

        [AllowAnonymous]
        [Route(@"employees/edit")]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route(@"employees/create")]
        public ActionResult Create(Storm model)
        {
            return RedirectToAction("Index");
        }
    }
}