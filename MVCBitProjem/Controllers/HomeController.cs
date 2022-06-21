using DataAccessLayer.Concrete;
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
        Context c = new Context();
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
        [AllowAnonymous]
        public ActionResult HomePage()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.ContentCount = c.Contents.Count();
            viewModel.HeadingCount = c.Headings.Count();
            viewModel.MessageCount = c.Messages.Count();
            viewModel.WriterCount = c.Writers.Count();
            return View(viewModel);
        }
    }
}