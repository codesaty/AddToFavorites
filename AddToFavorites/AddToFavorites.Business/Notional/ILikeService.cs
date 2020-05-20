using AddToFavorites.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddToFavorites.Business.Notional
{
    public interface ILikeService
    {
        void AddToFavorites(Liked liked, Product product);
        void RemoveFromFavorites(Liked liked, int productId);
    }
}
