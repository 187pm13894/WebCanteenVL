using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCanteenVL.Models;
namespace WebCanteenVL.Areas.Admin.Controllers
{
    public class FoodAdminController : Controller
    {
        QUANLYCANTEENEntities model = new QUANLYCANTEENEntities();
        // GET: Admin/FoodAdmin
        public ActionResult Index()
        {
            var food = model.FOODs.OrderByDescending(x => x.ID).ToList();
            return View(food);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var food = model.FOODs.FirstOrDefault(x => x.ID == id);
            ViewBag.food_type = model.CATEGORies.OrderByDescending(x => x.ID).ToList();
            return View(food);
        }

        [HttpPost]
        public ActionResult Edit(int id, FOOD f)
        {
            var food = model.FOODs.FirstOrDefault(x => x.ID == id);
            food.FOOD_CODE = f.FOOD_CODE;
            food.FOOD_NAME = f.FOOD_NAME;
            food.DESCRIPTION = f.DESCRIPTION;
            food.PRICE = f.PRICE;
            food.IMAGE_URL = f.IMAGE_URL;
            food.STATUS = f.STATUS;
            food.CATEGORY_ID = f.CATEGORY_ID;
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.food_type = model.CATEGORies.OrderByDescending(x => x.ID).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create( FOOD f)
        {
            var food = new FOOD();
            food.FOOD_CODE = f.FOOD_CODE;
            food.FOOD_NAME = f.FOOD_NAME;
            food.DESCRIPTION = f.DESCRIPTION;
            food.PRICE = f.PRICE;
            food.IMAGE_URL = f.IMAGE_URL;
            food.STATUS = f.STATUS;
            food.CATEGORY_ID = f.CATEGORY_ID;
            model.FOODs.Add(food);
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var food = model.FOODs.FirstOrDefault(x => x.ID == id);
            return View(food);
        }

        [HttpPost]
        public ActionResult Delete(int id, FOOD f)
        {
            var food = model.FOODs.FirstOrDefault(x => x.ID == id);
            model.FOODs.Remove(food);
            model.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var food = model.FOODs.FirstOrDefault(x => x.ID == id);
            return View(food);
        }
    }
}