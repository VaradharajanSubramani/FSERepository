using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ass23_WCF.EmpServiceReference;

namespace Ass23_WCF.Controllers
{
    public class EmployeeController : Controller
    {
        // WCF Client
        EmployeeClient empCli = new EmployeeClient();
        public ActionResult Index()
        {
            List<EmployeeModel> empList = empCli.GetAllEmployees().ToList();
            return View(empList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(collection["EmpId"]);
                emp.FirstName = collection["FirstName"];
                emp.LastName = collection["LastName"];
                emp.Department = collection["Department"];
                int res = empCli.SaveEmployee(emp);

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeModel emp = empCli.SearchById(id);
            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = id;
                emp.FirstName = collection["FirstName"];
                emp.LastName = collection["LastName"];
                emp.Department = collection["Department"];
                int res = empCli.UpdateEmployee(emp);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                int res = empCli.DeleteEmployee(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
