using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;

namespace TheHomeOfPartner.Controllers
{
    public class ProjectDisplayController : Controller
    {
        private THOPContext db = new THOPContext();

        // GET: ProjectDisplay
        public ActionResult Index(int? id)
        {
            var raMd = db.ReachAgreements.ToList();
            if (id!=null)
            {
                raMd = (from r in raMd where r.Id == id select r).ToList();
            }
            return View(raMd);
        }
    }
}