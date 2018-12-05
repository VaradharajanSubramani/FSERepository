using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ass13APIClient.Helper;
using Ass13APIClient.Models;

namespace Ass13APIClient.Proxy
{   
    public class SupplierProxy
    {
        APIHelper _helper = new APIHelper();
        public IEnumerable<SupplierModel> GetAllSuppliers()
        {
            return _helper.HttpGet<IEnumerable<SupplierModel>>("api/Suppliers", new Dictionary<string, object>(), "application/json");
        }


        public SupplierModel CreateSupplier(SupplierModel Model)
        {           
            return _helper.HttpPost<SupplierModel, SupplierModel>("api/Suppliers/PostSupplier", Model, "application/json");

        }
        public SupplierModel UpdateSupplier(SupplierModel Model)
        {
            return _helper.HttpPost<SupplierModel, SupplierModel>("api/Suppliers/PutSupplier", Model, "application/json");

        }

        public SupplierModel DeleteSupplier(string SupplierId)
        {
            return _helper.HttpPost<SupplierModel, string>("api/Suppliers/DeleteSupplier", SupplierId, "application/json");

        }

        public SupplierModel GetSupplierDetails(string SupplierId)
        {
            Dictionary<string, object> Prams = new Dictionary<string, object>();
            Prams.Add("id", SupplierId);
            return _helper.HttpGet<SupplierModel>("api/Suppliers/GetSUPPLIER", Prams, "application/json");

        }
    }
}