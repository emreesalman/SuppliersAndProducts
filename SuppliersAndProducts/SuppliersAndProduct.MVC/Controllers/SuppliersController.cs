using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SuppliersAndProduct.MVC.Helper;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;

using System.Text;
using System.Threading.Tasks;

namespace SuppliersAndProduct.MVC.Controllers
{
    public class SuppliersController : Controller
    {

        HelperAPI api = new HelperAPI();
        public async Task<IActionResult> Index()
        {
            List<Supplier> suppliers = new List<Supplier>();
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Suppliers/GetSuppliers");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(result);
            }
           
            
            return View(suppliers);
        }

        public async Task<IActionResult> Details(int id)
        {
            var supplier = new Supplier();
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/suppliers/GetSupplierByID/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                supplier = JsonConvert.DeserializeObject<Supplier>(result);

            }
            return View(supplier);
        }
        public async Task<IActionResult> ProductBySupplierID(int id)
        {

            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/suppliers/GetProductBySupplier/{id}");
            var result = res.Content.ReadAsStringAsync().Result;
            var products = JsonConvert.DeserializeObject<List<Product>>(result);
            return View(products);

        }
        public async Task<IActionResult> Delete(int id)
        {
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/suppliers/Delete/{id}");
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {

            return View();
        }
       
        [HttpPost]
        public IActionResult Create( Supplier supplier) 
        {
            HttpClient client = api.Initial();
            var postTask =  client.PostAsJsonAsync($"api/suppliers/add", supplier);
            postTask.Wait();
            var result =  postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            HttpClient client = api.Initial();
            var postTask = client.PutAsJsonAsync($"api/suppliers/Update", supplier);
            postTask.Wait();
            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult UpdateSupplier1()
        {
            return null;
        }

    }
}
