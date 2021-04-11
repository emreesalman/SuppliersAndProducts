using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SuppliersAndProduct.MVC.Helper;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuppliersAndProduct.MVC.Controllers
{
    public class ProductsController : Controller
    {
        HelperAPI api = new HelperAPI();
        public async Task<IActionResult> Index()
        {
            List<Product> products = new List<Product>();
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/products/GetProducts");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                products = JsonConvert.DeserializeObject<List<Product>>(result);
            }
            return View(products);
        }
        public async Task<IActionResult> Delete(int id)
        {
            
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/products/Delete/{id}");
            return RedirectToAction("Index");
        }

    }
}
