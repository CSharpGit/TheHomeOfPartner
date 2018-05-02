using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Controllers
{
    public class AccountController : Controller
    {
        private THOPContext db = new THOPContext();

        // GET: SignIn
        public ActionResult Login()
        {
            return View();
        }


        // post: SignIn
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string UserLabel,string UserPassWord)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(UserLabel) && !String.IsNullOrEmpty(UserPassWord))
                {
                    var user = db.Users.ToList();
                    string UserName = user.Find(u=>u.UserLabel==UserLabel).UserName;
                    int isUser = (from u in user where u.UserLabel == UserLabel && u.UserPassWord == UserPassWord select u).Count();
                    if (isUser > 0)
                    {
                        Session["UserLabel"] = UserLabel;
                        Session["UserName"] = UserName;
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "Id,UserLabel,UserName,UserSex,UserPassWord,PasswordPalt,PhoneNumber,UserType")] User user)
        {
            if (ModelState.IsValid)
            {
                user.RegisterDate = DateTime.Now.Date;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }
    }

}