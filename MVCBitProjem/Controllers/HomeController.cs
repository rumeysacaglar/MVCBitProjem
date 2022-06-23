using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using MVCBitProjem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBitProjem.Controllers
{
    public class HomeController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        Context c = new Context();
        ViewModel viewModel = new ViewModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ViewModel viewModel)
        {
            Contact c = new Contact();
            c.Username = viewModel.UserName;
            c.UserMail = viewModel.UserMail;
            c.Subject = viewModel.Subject;
            c.Message = viewModel.Message;
            c.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.ContactAdd(c);
            return RedirectToAction("HomePage");
        }

        [AllowAnonymous]
        public ActionResult HomePage()
        {
            
            viewModel.ContentCount = c.Contents.Count();
            viewModel.HeadingCount = c.Headings.Count();
            viewModel.MessageCount = c.Messages.Count();
            viewModel.WriterCount = c.Writers.Count();
            return View(viewModel);
        }
    }
}