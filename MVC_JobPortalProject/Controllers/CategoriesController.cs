using MVC_JobPortalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_JobPortalProject.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        Category obj = new Category();
        public ActionResult CategoriesDashBoard()
        {
            return View();
        }


        public ActionResult InserCategories(Category cat,int IsActive)
        {
            obj.CategoryName = cat.CategoryName;
            obj.IsActive = IsActive == 1 ? true : false;
            obj.Save();
            return RedirectToAction("CategoriesDashBoard");
        }
    }
}