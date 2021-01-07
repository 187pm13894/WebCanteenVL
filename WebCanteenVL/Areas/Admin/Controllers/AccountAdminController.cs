using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCanteenVL.Models;

namespace WebCanteenVL.Areas.Admin.Controllers
{
    public class AccountAdminController : Controller
    {
        QUANLYCANTEENEntities model = new QUANLYCANTEENEntities();
        // GET: Admin/AccountAdmin
        public ActionResult Index()
        {
            var account = model.ACCOUNTs.OrderByDescending(x => x.ID).ToList();
            return View(account);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var account = model.ACCOUNTs.FirstOrDefault(x => x.ID == id);
            return View(account);
        }

        [HttpPost]
        public ActionResult Edit(int id, ACCOUNT a)
        {
            var account = model.ACCOUNTs.FirstOrDefault(x => x.ID == id);
            account.EMAIL = a.EMAIL;
            account.PASSWORD = a.PASSWORD;
            account.FULL_NAME = a.FULL_NAME;
            account.STATUS = a.STATUS;
            account.ROLE = a.ROLE;
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ACCOUNT a)
        {
            var account = new ACCOUNT();
            account.EMAIL = a.EMAIL;
            account.PASSWORD = a.PASSWORD;
            account.FULL_NAME = a.FULL_NAME;
            account.STATUS = a.STATUS;
            account.ROLE = a.ROLE;
            model.ACCOUNTs.Add(account);
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var account = model.ACCOUNTs.FirstOrDefault(x => x.ID == id);
            return View(account);
        }

        [HttpPost]
        public ActionResult Delete(int id, ACCOUNT a)
        {
            var account = model.ACCOUNTs.FirstOrDefault(x => x.ID == id);
            model.ACCOUNTs.Remove(account);
            model.SaveChanges();
            return RedirectToAction("index");
        }
    }
}