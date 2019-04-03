using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVC_JobPortalProject.Models;
using MVC_JobPortalProject.Models.ViewModel;

namespace MVC_JobPortalProject.Controllers
{

    public class JobsController : Controller
    {
        DB_Context conn = new DB_Context();

        // GET: Jobs
        //[ActionName("Dashboard")] // changes the name of Action Method


        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        // GET Method
        public ActionResult AddNewsPaper()
        {
            NewsPaperViewModel obj = new NewsPaperViewModel()
            {
                ListofNewsPapers = conn.tbl_NewsPaper.ToList()
            };

            return View(obj);
        }

        [HttpPost]
        public ActionResult InsertNewsPaper(NewsPaper newspaper)
        {
            //model.IsActive = IsActive == 1 ? true : false;

            tbl_NewsPaper news = new tbl_NewsPaper()
            {
                NewsPaperName = newspaper.NewsPaperName,
                IsActive=newspaper.IsActive
            };
            if (TryUpdateModel(news))
            {
                conn.tbl_NewsPaper.Add(news);
                conn.SaveChanges();
                ViewBag.Message = "Data saved";
            }
            NewsPaperViewModel obj = new NewsPaperViewModel()
            {
                ListofNewsPapers = conn.tbl_NewsPaper.ToList()
            };
            return View("AddNewsPaper",obj);
        }

        public ActionResult RemovePaper(int? ID)
        {
            var RecordFound = conn.tbl_NewsPaper.Find(ID);
            conn.tbl_NewsPaper.Remove(RecordFound);
            conn.SaveChanges();
            return RedirectToAction("AddNewsPaper");
        }


        //public ActionResult DetailPaper(int? ID)
        //{
        //    var data = conn.tbl_NewsPaper.Find(ID);
        //    return View(data);
        //}
        //**********************************************************************
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[HttpGet]
        //// GET Method
        //public ActionResult AddNewsPaper()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult InsertNewsPaper(NewsPaper model)
        //{
        //    //model.IsActive = IsActive == 1 ? true : false;

        //    if (ModelState.IsValid)
        //    {
        //     using (SqlCommand cmd = new SqlCommand("SP_InsertNews", conn))
        //     {
        //         cmd.CommandType = CommandType.StoredProcedure;
        //         cmd.Parameters.AddWithValue("@Name", model.NewsPaperName);

        //         cmd.Parameters.AddWithValue("@IsActive", model.IsActive);
        //         conn.Open();
        //         cmd.ExecuteNonQuery();
        //         ViewBag.Message = "Inserted";
        //         conn.Close();
        //     }
        //    }
        //     return View("AddNewsPaper");
        //}
    }
}