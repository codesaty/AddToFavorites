using AddToFavorites.Business.Notional;
using System;
using System.Collections.Generic;
using System.Text;
using AddToFavorites.DataAccess.Notional;
using AddToFavorites.Entities.Tangible;

namespace AddToFavorites.Business.Tangible
{
    public class ProductManager : IProductService
    {
        //Veri Tabanına Ulaşmak için.
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public Product GetByFavoritesId(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
           
        }
    }
}
