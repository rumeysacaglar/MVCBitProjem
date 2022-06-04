using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBitProjem.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messageList = mm.GetListInbox();
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messageList = mm.GetListSendbox();
            return View(messageList);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}