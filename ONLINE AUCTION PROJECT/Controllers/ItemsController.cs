using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ONLINE_AUCTION_PROJECT.Models;

namespace ONLINE_AUCTION_PROJECT.Controllers
{
    public class ItemsController : Controller
    {
        Auction_ProjectEntities en = new Auction_ProjectEntities();
        // GET: Items
        public ActionResult AddItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItems(Item obj)
        {
            en.Items.Add(obj);
           
            Response.Write("<script>alert('Item Added')</script>");

            return View();
        }
        public ActionResult Appartments()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Appartments(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }

        public ActionResult Lamps()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Lamps(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }

        public ActionResult Shoes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Shoes(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }

        public ActionResult Wallclock()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Wallclock(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Shops()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Shops(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Bags()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bags(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Bikes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Bikes(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Trucks()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Trucks(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Cars()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cars(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Tables()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tables(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Beds()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Beds(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult WoodenCupboard()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WoodenCupboard(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Fridge()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Fridge(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult AC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AC(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Generators()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Generators(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
    }
}