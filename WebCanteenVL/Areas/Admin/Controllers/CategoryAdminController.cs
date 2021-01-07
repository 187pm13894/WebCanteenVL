using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCanteenVL.Models;

namespace WebCanteenVL.Areas.Admin.Controllers
{
    public class CategoryAdminController : Controller
    {
        QUANLYCANTEENEntities model = new QUANLYCANTEENEntities();
        // GET: Admin/CategoryAdmin
        public ActionResult Index()
        {
            var category = model.CATEGORies.OrderByDescending(x => x.ID).ToList();
            return View(category);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = model.CATEGORies.FirstOrDefault(x => x.ID == id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(int id, CATEGORY c)
        {
            var category = model.CATEGORies.FirstOrDefault(x => x.ID == id);
            category.CATEGORY_CODE = c.CATEGORY_CODE;
            category.CATEGORY_NAME = c.CATEGORY_NAME;
            category.IMAGE_URL = c.IMAGE_URL;
            category.STATUS = c.STATUS;
            category.CATEGORY_CODE = c.CATEGORY_CODE;
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Create()
        {
  
            return View();
        }

        [HttpPost]
        public ActionResult Create(CATEGORY c)
        {
            var category = new CATEGORY();
            category.CATEGORY_CODE = c.CATEGORY_CODE;
            category.CATEGORY_NAME = c.CATEGORY_NAME;
            category.IMAGE_URL = c.IMAGE_URL;
            category.STATUS = c.STATUS;
            category.CATEGORY_CODE = c.CATEGORY_CODE;
            model.CATEGORies.Add(category);
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = model.CATEGORies.FirstOrDefault(x => x.ID == id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Delete(int id, CATEGORY c)
        {
            var category = model.CATEGORies.FirstOrDefault(x => x.ID == id);
            model.CATEGORies.Remove(category);
            model.SaveChanges();
            return RedirectToAction("index");
        }
    }
}