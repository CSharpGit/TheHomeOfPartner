using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Controllers
{
    public class RecruitController : Controller
    {
        private THOPContext db = new THOPContext();

        private static string TeamMember = "";
        private static string TeamContact = "";

        // GET: Recruit
        public ActionResult Index()
        {
            if (Session["UserLabel"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var teams = db.Teams.ToList();
            var teamsMd = from t in teams where DateTime.Compare(t.ReleaseDate, t.DueDate) < 0 select t;
            return View(teamsMd);
        }

        public ActionResult CreatedTeam()
        {
            if (Session["UserLabel"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            List<SelectListItem> itemList = new List<SelectListItem>();
            db.Projects.ToList().ForEach(o =>
            {
                if (o.Completion == "未接单")
                {
                    SelectListItem item = new SelectListItem()
                    {
                        Value = o.PName.ToString(),
                        Text = o.PName.ToString()
                    };
                    itemList.Add(item);
                }

            });
            SelectList select = new SelectList(itemList, "Value", "Text");
            ViewBag.select = select;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatedTeam([Bind(Include = "Id,PName,TeamName,SkillsRequirement,TeamMember,Contact,RequiredNumber,DueDate")] Team team)
        {
            if (ModelState.IsValid)
            {
                team.ReleaseDate = DateTime.Now.Date;
                db.Teams.Add(team);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team);
        }

        public ActionResult JoinTeam(int? id)
        {
            if (Session["UserLabel"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var Users = db.Users.ToList();
            string UserName = Users.Find(u => u.UserLabel == Session["UserLabel"].ToString()).UserName;//拿到姓名
            string UserPhone = Users.Find(u => u.UserLabel == Session["UserLabel"].ToString()).PhoneNumber;//拿到手机号
            ViewBag.UserName = UserName;//传递姓名到视图页面
            ViewBag.UserPhone = UserPhone;//传递手机号到视图页面

            var TeamMembers = db.Teams.ToList();
            TeamMember = TeamMembers.Find(t => t.Id == id).TeamMember;
            TeamContact = TeamMembers.Find(t => t.Id == id).Contact;

            Team team = db.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult JoinTeam([Bind(Include = "Id,PName,TeamName,SkillsRequirement,TeamMember,Contact,RequiredNumber,ReleaseDate,DueDate")] Team team)
        {
            if (ModelState.IsValid)
            {
                team.TeamMember += "|" + TeamMember;
                team.Contact += "|" + TeamContact;
                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}