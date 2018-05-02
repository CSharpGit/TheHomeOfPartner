using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Controllers
{
    public class ChatController : Controller
    {
        private THOPContext db = new THOPContext();

        private static int UserId = 0;//用户姓名
        private static string UserName="";//用户姓名
        private static string UserType="";//用户类型
        private static int ProjectID = 0;//用户类型
        // GET: Chat
        public async Task<ActionResult> Index(int Id)
        {
            if (Id <0|Session["UserLabel"]==null)
            {
                return RedirectToAction("Login","Account");
            }
            var ChatLogModel =await db.ChatLogs.ToListAsync();
            foreach (var item in ChatLogModel)
            {
                if (item.User.UserLabel== Session["UserLabel"].ToString())
                {
                    UserId = item.UserId;
                    UserName = item.UserName;
                    UserType = item.UserType;
                }

            }
            ViewBag.userType = UserType;
            var ChatLogCount = (from c in ChatLogModel select c).Count();
            ViewBag.ChatLogCount = ChatLogCount;
            var ChatLogMd = from c in ChatLogModel orderby c.ChatTime ascending select c;//查出所有聊天记录，按时间升序排列

            var ProjectModel =await db.Projects.ToListAsync();
            var ProjectMd = from p in ProjectModel where p.Id==Id select p;
            ViewBag.ProjectMd = ProjectMd;

            ProjectID = Id;
            return View(ChatLogMd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include ="ChatContent")] ChatLog chatLog)
        {
            if (ModelState.IsValid)
            {
                chatLog.UserId = UserId;
                chatLog.UserName = UserName;
                chatLog.UserType = UserType;
                chatLog.ChatTime = DateTime.Now;
                db.ChatLogs.Add(chatLog);
                db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}