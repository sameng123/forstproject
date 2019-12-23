using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONLINE_AUCTION_PROJECT.Models;

namespace ONLINE_AUCTION_PROJECT.Controllers
{
    public class AdminController : Controller
    {
        Auction_ProjectEntities en = new Auction_ProjectEntities();
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult AddCat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCat(Category obj)
        {
            en.Categories.Add(obj);
            en.SaveChanges();
            Response.Write("<script>alert('Category Added')</script>");
            return View();
        }
        public ActionResult ViewCat()
        {
            return View(en.Categories.ToList());
        }

        public ActionResult ViewItem()
        {
            return View(en.Items.ToList());
        }
        public ActionResult ViewBid()
        {
            return View(en.Items.ToList());
        }
        public ActionResult DeleteCat(int id)
        {
            Category ct = en.Categories.Find(id).ToList();
            en.Categories.Remove(ct);
            en.SaveChanges();
            return RedirectToAction("ViewCat");
        }
        public ActionResult DeletUser(int id)
        {
            User ct = en.Users.Find(id);
            en.Users.Remove(ct);
            en.SaveChanges();
            return RedirectToAction("ViewUser");
        }

        public ActionResult EditCat(int id)
        {
            ViewBag.Category = en.Categories.Where(a=>a.Cat_Id == id).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult EditCat(Category obj)
        {
            en.Entry<Category>(obj).State = System.Data.Entity.EntityState.Modified();
            en.SaveChanges();
            return RedirectToAction("ViewCat");
        }
    }
}
