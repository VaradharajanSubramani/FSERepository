using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ass13APIClient.Models;
using Ass13APIClient.Proxy;

namespace Ass13APIClient.Controllers
{
    public class SupplierController : Controller
    {
        SupplierProxy _proxy = new SupplierProxy();
        // GET: Supplier
        public ActionResult Index()
        {
            List<SupplierModel> supList = new List<SupplierModel>();

            supList = _proxy.GetAllSuppliers().ToList();
            return View(supList);
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                SupplierModel model = new SupplierModel();
                model.SUPLNO = collection["SUPLNO"];
                model.SUPLNAME = collection["SUPLNAME"];
                model.SUPLADDR = collection["SUPLADDR"];
                _proxy.CreateSupplier(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(string id)
        {
            SupplierModel model = _proxy.GetSupplierDetails(id);
            return View(model);
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                SupplierModel model = new SupplierModel();
                model.SUPLNO = collection["SUPLNO"];
                model.SUPLNAME = collection["SUPLNAME"];
                model.SUPLADDR = collection["SUPLADDR"];
                _proxy.UpdateSupplier(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(string id)
        {
            SupplierModel model = _proxy.GetSupplierDetails(id);
            return View(model);
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                _proxy.DeleteSupplier(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
