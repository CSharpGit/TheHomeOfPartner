using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheHomeOfPartner.DAL;
using TheHomeOfPartner.Models;

namespace TheHomeOfPartner.Areas.Admin.Controllers
{
    public class ChatLogManageController : Controller
    {
        private THOPContext db = new THOPContext();

        // GET: Admin/ChatLogManage
        public async Task<ActionResult> Index()
        {
            var chatLogs = db.ChatLogs.Include(c => c.User);
            return View(await chatLogs.ToListAsync());
        }

        // GET: Admin/ChatLogManage/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLog chatLog = await db.ChatLogs.FindAsync(id);
            if (chatLog == null)
            {
                return HttpNotFound();
            }
            return View(chatLog);
        }

        // GET: Admin/ChatLogManage/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel");
            return View();
        }

        // POST: Admin/ChatLogManage/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserId,UserName,ChatContent,ChatTime,UserType")] ChatLog chatLog)
        {
            if (ModelState.IsValid)
            {
                db.ChatLogs.Add(chatLog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", chatLog.UserId);
            return View(chatLog);
        }

        // GET: Admin/ChatLogManage/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLog chatLog = await db.ChatLogs.FindAsync(id);
            if (chatLog == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", chatLog.UserId);
            return View(chatLog);
        }

        // POST: Admin/ChatLogManage/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,UserName,ChatContent,ChatTime,UserType")] ChatLog chatLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chatLog).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", chatLog.UserId);
            return View(chatLog);
        }

        // GET: Admin/ChatLogManage/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChatLog chatLog = await db.ChatLogs.FindAsync(id);
            if (chatLog == null)
            {
                return HttpNotFound();
            }
            return View(chatLog);
        }

        // POST: Admin/ChatLogManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ChatLog chatLog = await db.ChatLogs.FindAsync(id);
            db.ChatLogs.Remove(chatLog);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
