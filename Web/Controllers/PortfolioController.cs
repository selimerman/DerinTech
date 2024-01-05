using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Reflection;
using Web.Models;
using static Web.Models.ProductViewModel;

namespace Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ILogger<PortfolioController> _logger;

        public PortfolioController(ILogger<PortfolioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new ProductLst
            {
                Products = new List<Product>()
            };
            model.Products.Add(new Product
            {
                Id=1,
                PageName = "TR7Page",
                PageUrl = Url.Action("ProductDetail", "ProductDetailController"),
                ImageUrl = "img/works/tr7logo.jpg",
                Category = "Siber Güvenlik",
                CategoryTag = "Siber"
            }) ;
            model.Products.Add(new Product
            {
                Id=2,
                PageName = "AtackFlowPage",
                PageUrl = Url.Action("ProductDetail", "ProductDetailController"),
                ImageUrl = "img/works/atack.jpg",
                Category = "Siber Güvenlik",
                CategoryTag = "Siber"
            });
            model.Products.Add(new Product
            {
                Id=3,
                PageName = "ForestallPage",
                PageUrl = Url.Action("ProductDetail", "ProductDetailController"),
                ImageUrl = "img/works/forestall.jpg",
                Category = "Active Directory",
                CategoryTag = "ActiveDirectory"
            });
            model.Products.Add(new Product
            {
                Id=4,
                PageName = "BrandefansePage",
                PageUrl = Url.Action("ProductDetail", "ProductDetailController"),
                ImageUrl = "img/works/brand.jpg",
                Category = "Koruma",
                CategoryTag = "Koruma"
            });
            return View(model);
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



