using System;
using System.Collections.Generic;
using System.Text;
using AddToFavorites.Entities.Tangible;

namespace AddToFavorites.Business.Notional
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);
        Product GetByFavoritesId(int productId);
    }
}
