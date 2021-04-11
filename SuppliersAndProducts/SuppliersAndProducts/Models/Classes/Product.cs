using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }

        [JsonIgnore]
        public Supplier SupplierSupplier  { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }


    }
}
