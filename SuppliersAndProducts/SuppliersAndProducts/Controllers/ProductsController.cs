using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuppliersAndProducts.Data;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private IAppRepository _appRepository;
        private DataContext _context;
        public ProductsController(IAppRepository appRepository, DataContext context)
        {
            _appRepository = appRepository;
            _context = context;
        }

        // [Authorize]
        [HttpGet]
        public ActionResult GetProducts()
        {

            var products = _appRepository.GetProducts();

            return Ok(products);
        }

        // [Authorize]
        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            var supplier = _context.Products.FirstOrDefault(p=>p.ProductID==id);
            _appRepository.Delete(supplier);
            _appRepository.SaveAll();
            return Ok(supplier);
        }
    }
}
