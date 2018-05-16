using Scienoveda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Scienoveda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult SendMail(MailModel mailModel)
        {
            string result;
            MailMessage mail = new MailMessage();
            

            mail.From = new MailAddress("scienovedapreeti@gmail.com");
            mail.To.Add("scienoveda5bf@gmail.com");
            mail.Subject = "Enquiry from Website by " + mailModel.Name;
            mail.Body = mailModel.Content + "<br><br><br>" +"Email: " + mailModel.Email + "<br><br><br>" + "Contact: " + mailModel.Mobile;
            mail.IsBodyHtml = true;


            using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587)) { 
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.EnableSsl = true;
            SmtpServer.Credentials = new System.Net.NetworkCredential("scienovedapreeti@gmail.com", "Preeti@1995");
            try { 
            SmtpServer.Send(mail);
                result = "OK";
            }
                catch (Exception ex)
                {
                    result = ex.InnerException.ToString();
                }
            }
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}