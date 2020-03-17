using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class EmployeesController : Controller
    {
        public static List<Employee> EList = new List<Employee>();
        public ActionResult Index()
        {
            return View(EList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EList.Add(e);
                    return RedirectToAction("Index");
                }
                else
                {
                    Debug.WriteLine(ModelState.Values);
                    return View(e);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
