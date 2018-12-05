using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ass23_POPSApi.Controllers;
using Ass23_POPSApi;
using System.Collections.Generic;
using System.Data.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using NUnit;
using System.Net.Http;
using System.Net;

namespace APIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private PODbEntities db = new PODbEntities();
        [TestMethod]
        public void Test_AllSuppliers()
        {
            var suplierList = GetSUPPLIERs();
            var SC = new SUPPLIERsController();
            var result = SC.GetSUPPLIERs() as List<SUPPLIER>;
            Assert.AreEqual(suplierList.Count, result.Count);

        }
        [TestMethod]
        public void Test_SupplierBasedOnID()
        {
            string supplierid = "1";
            // var supplier = GetSUPPLIERs().Find(x => x.SUPLNO == supplierid);
            var SC = new SUPPLIERsController();

            var res = SC.GetSUPPLIER(supplierid);
            var ct = res as OkNegotiatedContentResult<SUPPLIER>;
            Assert.IsNotNull(ct);
            Assert.IsNotNull(ct.Content);
            Assert.AreEqual("1", ct.Content.SUPLNO.Trim());


        }
        [TestMethod]
        public void Test_SupplierNotFound()
        {
            var controller = new SUPPLIERsController();
            IHttpActionResult actionResult = controller.GetSUPPLIER("100");
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public void Test_AddSupplier()
        {
            var controller = new SUPPLIERsController();
            SUPPLIER Sup = new SUPPLIER { SUPLNO = "10", SUPLADDR = "Chennai", SUPLNAME = "NRN" };
            IHttpActionResult actionResult = controller.PostSUPPLIER(Sup);
            var result = actionResult as CreatedAtRouteNegotiatedContentResult<SUPPLIER>;
            Assert.IsNotNull(result);
            Assert.AreEqual("DefaultApi", result.RouteName);
            Assert.IsNotNull(result.RouteValues["id"]);

        }

        [TestMethod]
        public void Test_DeleteSupplier()
        {
            var controller = new SUPPLIERsController();
            IHttpActionResult actionResult = controller.DeleteSUPPLIER("10");
            IHttpActionResult actionResult1 = controller.GetSUPPLIER("10");
            Assert.IsInstanceOfType(actionResult1, typeof(NotFoundResult));
        }

        [TestMethod]
        public void UpdateDepartmentTest()
        {
            // Arrange  
            var controller = new SUPPLIERsController();
            SUPPLIER Sup = new SUPPLIER { SUPLNO = "1", SUPLADDR = "Mumbai",SUPLNAME="KK ERP" };
            // Act  
            IHttpActionResult actionResult = controller.PutSUPPLIER(Sup.SUPLNO,Sup);
            var contentResult = actionResult as NegotiatedContentResult<SUPPLIER>;
            Assert.IsNull(contentResult);
            Assert.AreEqual(HttpStatusCode.Accepted, contentResult.StatusCode);
            Assert.IsNotNull(contentResult.Content);
        }


        private List<SUPPLIER> GetSUPPLIERs()
        {
            List<SUPPLIER> suplierList = new List<SUPPLIER>();

            suplierList.Add(new SUPPLIER { SUPLNO = "1", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            suplierList.Add(new SUPPLIER { SUPLNO = "2", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            suplierList.Add(new SUPPLIER { SUPLNO = "3", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            suplierList.Add(new SUPPLIER { SUPLNO = "4", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            suplierList.Add(new SUPPLIER { SUPLNO = "5", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            suplierList.Add(new SUPPLIER { SUPLNO = "6", SUPLNAME = "MRN", SUPLADDR = "Chennai" });
            return suplierList;
        }
    }
}
