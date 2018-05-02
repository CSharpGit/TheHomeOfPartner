using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Controllers
{
    public class ProjectBrowsingController : Controller
    {

        private THOPContext db = new THOPContext();

        // GET: ProjectBrowsing
        public ActionResult Index()
        {
            if (Session["UserLabel"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(db.Projects.ToList());
        }

        public ActionResult ProjectRelease()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProjectRelease([Bind(Include = "ProjectID,PName,ProjectPequirement,ProjectType,DevelopLanguage,Price")] Project project)
        {
            if (ModelState.IsValid)
            {
                project.ReleaseDate = DateTime.Now.Date;//自动填入发布日期
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);
        }
    }
}