using DataAccessLayer.Concrete;
using MVCBitProjem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBitProjem.Controllers
{
    public class ChartController : Controller
    {
        Context c = new Context();

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> cs2 = new List<CategoryClass>();
            using (var c = new Context())
            {
                cs2 = c.Categories.Select(x => new CategoryClass
                {
                    CategoryName = x.CategoryName,
                    HeadingCount = x.Headings.Count
                }).ToList();
            }
            return cs2;
        }
    }
}