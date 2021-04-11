using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Dtos
{
    public class ProductBySupplierDto
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
       
        public int Stock { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }
    }
}
