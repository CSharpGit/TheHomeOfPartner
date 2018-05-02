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
    public class ReplyManageController : Controller
    {
        private THOPContext db = new THOPContext();

        // GET: Admin/ReplyManage
        public async Task<ActionResult> Index()
        {
            var replies = db.Replies.Include(r => r.Topic).Include(r => r.User);
            return View(await replies.ToListAsync());
        }

        // GET: Admin/ReplyManage/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = await db.Replies.FindAsync(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            return View(reply);
        }

        // GET: Admin/ReplyManage/Create
        public ActionResult Create()
        {
            ViewBag.TopicId = new SelectList(db.Topics, "Id", "Title");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel");
            return View();
        }

        // POST: Admin/ReplyManage/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,TopicId,UserId,ReContent,Approval,ReplyDate")] Reply reply)
        {
            if (ModelState.IsValid)
            {
                db.Replies.Add(reply);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.TopicId = new SelectList(db.Topics, "Id", "Title", reply.TopicId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", reply.UserId);
            return View(reply);
        }

        // GET: Admin/ReplyManage/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = await db.Replies.FindAsync(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            ViewBag.TopicId = new SelectList(db.Topics, "Id", "Title", reply.TopicId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", reply.UserId);
            return View(reply);
        }

        // POST: Admin/ReplyManage/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,TopicId,UserId,ReContent,Approval,ReplyDate")] Reply reply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reply).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.TopicId = new SelectList(db.Topics, "Id", "Title", reply.TopicId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserLabel", reply.UserId);
            return View(reply);
        }

        // GET: Admin/ReplyManage/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reply reply = await db.Replies.FindAsync(id);
            if (reply == null)
            {
                return HttpNotFound();
            }
            return View(reply);
        }

        // POST: Admin/ReplyManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Reply reply = await db.Replies.FindAsync(id);
            db.Replies.Remove(reply);
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
