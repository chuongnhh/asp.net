using ledsangviet_chuongnh.Common;
using ledsangviet_chuongnh.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ledsangviet_chuongnh.Controllers
{
    public class ContactController : Controller
    {
        DBContext db = new DBContext();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Title = ConfigurationManager.AppSettings["ContactTitle"].ToString();
            ViewBag.Contact = db.Abouts.FirstOrDefault<About>();
            return View();
        }

        public async Task<ActionResult> Create([Bind(Include = "Id,Name,PhoneNumber,Address,Email,Content")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                db.Feedback.Add(feedback);
                await db.SaveChangesAsync();

                string content =
                System.IO.File.ReadAllText(Server.MapPath("/Assets/Client/Template/mailtemplate.html"));
                content = content.Replace("{{customerName}}", feedback.Name);
                content = content.Replace("{{phoneNumber}}", feedback.PhoneNumber);
                content = content.Replace("{{emailAddress}}", feedback.Email);
                content = content.Replace("{{Address}}", feedback.Address);
                content = content.Replace("{{content}}", feedback.Content);
                var toEmail = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();
                MailHelper mail = new MailHelper();
                mail.SendMail(toEmail, "Thông tin từ khách hàng", content);

                return RedirectToAction("Index");
            }
            
            return View(feedback);
        }
    }
}