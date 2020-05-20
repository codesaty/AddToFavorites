using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.Business.Notional;
using AddToFavorites.MVC.UI.SessionServicies;
using Microsoft.AspNetCore.Mvc;

namespace AddToFavorites.MVC.UI.Controllers
{
    public class LikeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ILikeService _likeService;
        private ILikeSessionServicies _likeSessionServicies;
        private IProductService _productService;

        public LikeController(ILikeService likeService,
            ILikeSessionServicies likeSessionServicies,
            IProductService productService)
        {
            _likeService = likeService;
            _likeSessionServicies = likeSessionServicies;
            _productService = productService;
        }


        //ürünü favorilere ekleme işlemeni gerçekleştirmemiz gerek.
        public IActionResult AddToLiked(int productId)
        {
            var productToBeLiked = _productService.GetByFavoritesId(productId);
            var like = _likeSessionServicies.GetLike();
            _likeService.AddToFavorites(like, productToBeLiked);
            _likeSessionServicies.SetLike(like);
            return RedirectToAction("Index", "Product");
        }

        public ActionResult RemoveFromFavorites(int productId)
        {
            var like = _likeSessionServicies.GetLike();
            _likeService.RemoveFromFavorites(like, productId);
            _likeSessionServicies.SetLike(like);
            return RedirectToAction("Index", "Product");
        }
    }
}
