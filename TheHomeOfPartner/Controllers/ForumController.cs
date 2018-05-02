using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Controllers
{
    public class ForumController : Controller
    {
        private THOPContext db = new THOPContext();

        private static int UserId=0;
        // GET: Forum
        public ActionResult Index()
        {
            if (Session["UserLabel"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var users = db.Users.ToList();
            ViewBag.users = users;

            UserId = (from u in users where u.UserLabel == Session["UserLabel"].ToString() select u.Id).First();

            var replies = db.Replies.ToList();
            ViewBag.replies = replies;

            var topicMd = from t in db.Topics.ToList() orderby t.ReleaseDate ascending select t;
            return View(topicMd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "TopicId,ReContent")] Reply reply)
        {
            if (ModelState.IsValid&&string.IsNullOrEmpty(reply.ReContent))
            {
                reply.UserId = UserId;
                reply.ReplyDate = DateTime.Now;
                db.Replies.Add(reply);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}