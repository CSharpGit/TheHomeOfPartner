using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;

namespace TheHomeOfPartner.Controllers
{
    public class HomeController : Controller
    {
        private THOPContext db = new THOPContext();

        public ActionResult Index()
        {
            var ReachAgreementModel = db.ReachAgreements.ToList();
            var ReachAgreementMd = (from R in ReachAgreementModel orderby R.PageViews select R).Take(9);//查询阅读量排名前4的数据

            var ProjectModel = db.Projects.ToList();
            var ProjectModelmd = (from R in ProjectModel where R.Completion == "未接单" orderby R.ReleaseDate select R).Take(3);//查询截止日期在此刻以前的前4的数据
            ViewBag.ProjectModel = ProjectModelmd;

            var RecruitModel = db.Teams.ToList();
            var Recruitmd = (from R in RecruitModel where R.DueDate >= DateTime.Now.Date orderby R.Id select R).Take(8);//查询截止日期在此刻以前的前4的数据
            ViewBag.RecruitModel = Recruitmd;
            return View(ReachAgreementMd);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult NotFound()
        {
            return View();
        }
    }
}