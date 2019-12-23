using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using ONLINE_AUCTION_PROJECT.Models;

namespace ONLINE_AUCTION_PROJECT.Controllers
{
    public class auctionController : Controller
    {
        Auction_ProjectEntities en = new Auction_ProjectEntities();
        // GET: auction
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult SignUp(User obj)
        {
            en.Users.Add(obj);
            en.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult aboutus()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult contact(string txtname, string txtemail, string txtmessage)
        {
            SmtpClient obj = new SmtpClient();
            obj.Host = "smtp.gmail.com";
            obj.Port = 587;
            obj.EnableSsl = true;
            obj.UseDefaultCredentials = false;
            obj.Credentials = new NetworkCredential("sznew578@gmail.com", "SamraZehra12345");


            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("sznew578@gmail.com");
            msg.To.Add("sznew578@gmail.com");
            msg.ReplyTo = new MailAddress(txtemail);
            msg.Body = txtmessage + "br/" + "Your Truely" + "br/" + txtname;
            msg.IsBodyHtml = true;
            obj.Send(msg);

            Response.Write("<script>alert('Message Sent')</script>");


            return View();
        }

        public ActionResult elements()
        {
            return View();
        }

        public ActionResult index()
        {
            return View();
        }

        public ActionResult Paintings()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Paintings(string btn)
        {
            if (Session["un"] != null)
            {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems", "Items");
        }
        public ActionResult Property()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Property(string btn)
        {
            if (Session["un"] != null) {
                return RedirectToAction("SignIn");
            }
            return RedirectToAction("AddItems","Items");
        }

        public ActionResult Furniture()
        {
            return View();
        }

        public ActionResult Vehicles()
        {
            return View();
        }
        public ActionResult Accessories()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Testimonials()
        {
            return View();
        }
        public ActionResult UserDashboard()
        {
            return View();
        }
        public ActionResult Electronics()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(string email, string pass)
        {
            if (email == "admin@gmail.com" && pass == "admin")
            {
                return RedirectToAction("Dashboard","Admin");

            }
            User obj = en.Users.Where(a => a.User_Email == email && a.User_Password == pass).SingleOrDefault();
            if (obj != null)
            {
                Session["un"] = obj.User_Name;
                return RedirectToAction("Index");
            }
            Response.Write("<script>alert('Login Successfully')</script>");
            return View();
        }

    }
}