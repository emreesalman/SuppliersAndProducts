using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Models.Classes
{
    public class Supplier
    {
        public Supplier() {
            Products = new List<Product>();
        
        }
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        [JsonIgnore]
        public List<Product> Products { get; set; }

    }
}
