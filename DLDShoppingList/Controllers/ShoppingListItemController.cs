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
    public class ShoppingListItemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingListItem
        public ActionResult Index()
        {
            return View(db.ShoppingListItem.ToList());
        }

        // GET: ShoppingListItem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListItemContext shoppingListItemContext = db.ShoppingListItem.Find(id);
            if (shoppingListItemContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListItemContext);
        }

        // GET: ShoppingListItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingListItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoppingListItemContextID,ShoppingListContextID,Contents,Note,Priority,IsChecked,CreatedUtc,ModifiedUtc")] ShoppingListItemContext shoppingListItemContext)
        {
            if (ModelState.IsValid)
            {
                db.ShoppingListItem.Add(shoppingListItemContext);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ShoppingListContextID = new SelectList(db.ShoppingList, "ShoppingListContextID", "Name", shoppingListItemContext.ShoppingListContextID);
            return View(shoppingListItemContext);
        }

        // GET: ShoppingListItem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListItemContext shoppingListItemContext = db.ShoppingListItem.Find(id);
            if (shoppingListItemContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListItemContext);
        }

        // POST: ShoppingListItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoppingListItemContextID,ShoppingListContextID,Contents,Note,Priority,IsChecked,CreatedUtc,ModifiedUtc")] ShoppingListItemContext shoppingListItemContext)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoppingListItemContext).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoppingListItemContext);
        }

        // GET: ShoppingListItem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoppingListItemContext shoppingListItemContext = db.ShoppingListItem.Find(id);
            if (shoppingListItemContext == null)
            {
                return HttpNotFound();
            }
            return View(shoppingListItemContext);
        }

        // POST: ShoppingListItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoppingListItemContext shoppingListItemContext = db.ShoppingListItem.Find(id);
            db.ShoppingListItem.Remove(shoppingListItemContext);
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
