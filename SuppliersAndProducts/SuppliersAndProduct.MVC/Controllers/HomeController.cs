using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SuppliersAndProduct.MVC.Helper;
using SuppliersAndProduct.MVC.Models;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuppliersAndProduct.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        HelperAPI api = new HelperAPI();
        public async Task<IActionResult> Index()
        {
            List<Supplier> suppliers = new List<Supplier>();
            HttpClient client = api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/products/GetSuppliers");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(result);
            }
            return View(suppliers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
