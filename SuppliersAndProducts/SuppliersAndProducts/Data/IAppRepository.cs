using SuppliersAndProducts.Dtos;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();
        List<Supplier> GetSuppliers();
        List<Product> GetProductsBySupplier(int supplierID);
        Supplier GetSupplierByID(int supplierID);
        List<Product> GetProducts();
       


    }
}
