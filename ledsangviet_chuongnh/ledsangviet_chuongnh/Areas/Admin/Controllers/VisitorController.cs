using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ledsangviet_chuongnh.Models;

namespace ledsangviet_chuongnh.Areas.Admin.Controllers
{
    public class VisitorController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Admin/Visitor
        public async Task<ActionResult> Index()
        {
            return View(await db.Visitors.ToListAsync());
        }

        // GET: Admin/Visitor/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.Visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // GET: Admin/Visitor/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Admin/Visitor/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.Visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Admin/Visitor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,DateTime,Browser,Version,Type,Platform,UserAgent,UserLanguages,UserHostAddress")] Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(visitor);
        }

        // GET: Admin/Visitor/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.Visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Admin/Visitor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Visitor visitor = await db.Visitors.FindAsync(id);
            db.Visitors.Remove(visitor);
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
