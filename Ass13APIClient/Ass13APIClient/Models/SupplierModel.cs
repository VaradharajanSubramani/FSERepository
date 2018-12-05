using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ass13APIClient.Models
{
    public class SupplierModel
    {
        [Display(Name ="Supplier No")]
        public string SUPLNO { get; set; }
        [Display(Name = "Supplier Name")]
        public string SUPLNAME { get; set; }
        [Display(Name = "Supplier Address")]
        public string SUPLADDR { get; set; }
    }
}