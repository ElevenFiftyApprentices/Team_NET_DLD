using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DLDShoppingList.Data;

namespace DLDShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingList
        public ActionResult Index()
        {
            return View(db.ShoppingList.ToList());
        }

        // GET: ShoppingList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListContext shoppingListContext = db.ShoppingList.Find(id);
            if (shoppingListContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListContext);
        }

        // GET: ShoppingList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,Name,Color,CreatedUtc,ModifiedUtc")] ShoppingListContext shoppingListContext)
        {
            if (ModelState.IsValid)
            {
                db.ShoppingList.Add(shoppingListContext);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoppingListContext);
        }

        // GET: ShoppingList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListContext shoppingListContext = db.ShoppingList.Find(id);
            if (shoppingListContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListContext);
        }

        // POST: ShoppingList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,Name,Color,CreatedUtc,ModifiedUtc")] ShoppingListContext shoppingListContext)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoppingListContext).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoppingListContext);
        }

        // GET: ShoppingList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListContext shoppingListContext = db.ShoppingList.Find(id);
            if (shoppingListContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListContext);
        }

        // POST: ShoppingList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoppingListContext shoppingListContext = db.ShoppingList.Find(id);
            db.ShoppingList.Remove(shoppingListContext);
            db.SaveChanges();
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
