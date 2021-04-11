using Microsoft.EntityFrameworkCore;
using SuppliersAndProducts.Dtos;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {

            _context.Remove(entity);
        }

        public List<Product> GetProductsBySupplier(int supplierID)
        {
            var products = _context.Products.Where(p => p.SupplierID == supplierID).ToList();
            return products;
        }

        public Supplier GetSupplierByID(int supplierID)
        {
            var supplier = _context.Suppliers.Include(s => s.Products).FirstOrDefault(s => s.SupplierID == supplierID);
            return supplier;
        }
        public Supplier updateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            return supplier;
        }
        public List<Supplier> GetSuppliers()
        {
            var suppliers = _context.Suppliers.Include(x => x.Products).ToList();
            return suppliers;
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
