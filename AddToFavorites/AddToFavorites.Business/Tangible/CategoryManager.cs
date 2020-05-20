using AddToFavorites.Business.Notional;
using System;
using System.Collections.Generic;
using System.Text;
using AddToFavorites.Entities.Tangible;
using AddToFavorites.DataAccess.Notional;

namespace AddToFavorites.Business.Tangible
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
