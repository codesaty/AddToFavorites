using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.Business.Notional;
using AddToFavorites.MVC.UI.Models;

namespace AddToFavorites.MVC.UI.Controller
{
    public class ProductController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int categorySelect = 0)
        {
            ProductListViewModel productModelList = new ProductListViewModel
            {
                Products = _productService.GetByCategory(categorySelect)
            };
            return View(productModelList);
        }

       
    }
}
