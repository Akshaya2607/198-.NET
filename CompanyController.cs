using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationDemo.Models;
using System.IO;

namespace ValidationDemo.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            string path = Server.MapPath("~/Uploads/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (postedFile != null)
            {
                string filename = Path.GetFileName(postedFile.FileName);
                postedFile.SaveAs(path + filename);
                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", filename);
            }
            return View();
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, HttpPostedFileBase postedFile)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    CompanyDetails d = new CompanyDetails();
                    d.CompanyID = Convert.ToInt32(Request.Form["CompanyID"]);
                    
                    d.NoOfEmployees = Convert.ToInt32(Request.Form["NoOfEmployees"]);
                    d.CompanyName = Request.Form["CompanyName"];
                    d.email = Request.Form["email"];
                    d.url = Request.Form["url"];
                    d.City =Request.Form["City"];
                    string path = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (postedFile != null)
                    {
                        string filename = Path.GetFileName(postedFile.FileName);
                        postedFile.SaveAs(path + filename);
                        ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", filename);
                    }
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Company/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
