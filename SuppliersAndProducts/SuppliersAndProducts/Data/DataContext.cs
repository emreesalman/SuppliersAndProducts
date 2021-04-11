using Microsoft.EntityFrameworkCore;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Data
{
    public class DataContext: DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {


        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
