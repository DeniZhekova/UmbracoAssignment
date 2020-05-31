using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
//using AarhusWebDevCoop.ViewModels;
//using UmbracoAssignment.ViewModels;
using System.Net.Mail;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace UmbracoAssgnment.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        
        // GET: ContactFormSurface
        public ActionResult Index()
        {
            return PartialView("ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            // Send e-mail
            MailMessage message = new MailMessage();
            message.To.Add("eaadezh@students.eaaa.dk");
            message.Subject = model.Subject;
            message.From = new MailAddress(model.Email, model.Name);
            message.Body = model.Message;

            GuidUdi currentPageUdi = new GuidUdi(CurrentPage.ContentType.ItemType.ToString(), CurrentPage.Key);

            IContent msg = Services.ContentService.CreateContent(model.Subject, currentPageUdi, "message");
            msg.SetValue("name", model.Name);
            msg.SetValue("email", model.Email);
            msg.SetValue("phoneNumber", model.PhoneNumbert);
            msg.SetValue("messageContent", model.Message);
            msg.SetValue("umbracoNaviHide", true);

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("denitsa.zh97@gmail.com", "c9GT5r9p0");

                smtp.Send(message);
            }

            TempData["success"] = true;

            Services.ContentService.Save(msg);

            return RedirectToCurrentUmbracoPage();
        }
    }

    }
