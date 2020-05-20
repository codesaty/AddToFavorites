using AddToFavorites.Core.DataAccess.EntityFramework;
using AddToFavorites.DataAccess.Notional;
using AddToFavorites.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Text;
using AddToFavorites.DataAccess.Context;

namespace AddToFavorites.DataAccess.Tangible
{
    public class EfProductDal:EfEntityRepositoryBase<Product, NortwindContext>,IProductDal
    {

    }
}
