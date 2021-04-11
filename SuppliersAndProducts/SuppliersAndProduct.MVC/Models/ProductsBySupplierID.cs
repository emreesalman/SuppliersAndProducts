using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProduct.MVC.Models
{
    public class ProductsBySupplierID
    {
        public string SupplierName { get; set; }
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}
