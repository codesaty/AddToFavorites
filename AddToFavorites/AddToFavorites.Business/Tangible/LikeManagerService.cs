using AddToFavorites.Business.Notional;
using System;
using System.Collections.Generic;
using System.Text;
using AddToFavorites.Entities.Tangible;
using System.Linq;

namespace AddToFavorites.Business.Tangible
{
    //İş Katmanım
    public class LikeManagerService : ILikeService
    {
        public void AddToFavorites(Liked liked, Product product)
        {
            LikeMan likeMan = liked.LikeMan.FirstOrDefault(l => l.Product.ProductId == product.ProductId);
            if (likeMan == null)
            {
                liked.LikeMan.Add(new LikeMan { Product = product, DateTime = DateTime.Now });
            }
            else if (likeMan.Product.ProductName == product.ProductName)
            {
                throw new Exception("Bu Ürün Daha Önce Favorilere Eklendi");
            }
        }


        public void RemoveFromFavorites(Liked liked, int productId)
        {
            liked.LikeMan.Remove(liked.LikeMan.FirstOrDefault(l => l.Product.ProductId == productId));
        }
    }
}
