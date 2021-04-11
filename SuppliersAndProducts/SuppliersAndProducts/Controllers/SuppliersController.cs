using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuppliersAndProducts.Data;
using SuppliersAndProducts.Dtos;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SuppliersController : Controller
    {
        private IAppRepository _appRepository;
        private DataContext _context;

        public SuppliersController(IAppRepository appRepository, DataContext context)
        {
            _appRepository = appRepository;
            _context = context;
        }

        // [Authorize]
        [HttpGet]
        public ActionResult GetSuppliers() {

            var suppliers = _appRepository.GetSuppliers();

            return Ok(suppliers);
        }

        // [Authorize]
        [HttpPost]
        public ActionResult Add([FromBody] Supplier supplier)
        {
            _appRepository.Add(supplier);
            _appRepository.SaveAll();
            return Ok(supplier);
        }

        // [Authorize]
        [HttpPut]
        public ActionResult Update([FromBody] Supplier supplier)
        {
       
            _context.Suppliers.Update(supplier);
            _appRepository.SaveAll();
            return Ok(supplier);
        }

        // [Authorize]
        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            var supplier = _context.Suppliers.Include(s => s.Products).Where(s => s.SupplierID == id).FirstOrDefault();
            _appRepository.Delete(supplier);
            _appRepository.SaveAll();
            return Ok(supplier);
        }

        // [Authorize]
        [HttpGet("{Id}")]

        public ActionResult GetSupplierByID(int id)
        {
            var supplier = _appRepository.GetSupplierByID(id);
            return Ok(supplier);
        }

       // [Authorize]
        [HttpGet("{supplierID}")]
        public ActionResult GetProductBySupplier(int supplierID)
        {
            var products = _appRepository.GetProductsBySupplier(supplierID);
            return Ok(products);
        }
    }
}
