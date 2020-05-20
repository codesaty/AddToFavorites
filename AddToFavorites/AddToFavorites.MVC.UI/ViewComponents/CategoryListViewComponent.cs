using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.Business.Notional;
using AddToFavorites.DataAccess.Notional;
using AddToFavorites.MVC.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AddToFavorites.MVC.UI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var categoryListModel = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(categoryListModel);
        }
    }
}
