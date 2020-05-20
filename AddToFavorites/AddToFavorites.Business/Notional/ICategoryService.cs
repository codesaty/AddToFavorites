using AddToFavorites.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddToFavorites.Business.Notional
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
