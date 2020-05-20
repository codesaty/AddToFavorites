using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.MVC.UI.Models;
using AddToFavorites.MVC.UI.SessionServicies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AddToFavorites.MVC.UI.ViewComponents
{
    public class LikeViewComponent : ViewComponent
    {
        private ILikeSessionServicies _likeSessionServicies;
        public LikeViewComponent(ILikeSessionServicies likeSessionServicies)
        {
            _likeSessionServicies = likeSessionServicies;
        }
        public ViewViewComponentResult Invoke()
        {
            var likeModel = new LikeViewModel
            {
                Liked = _likeSessionServicies.GetLike()
            };
            return View(likeModel);
        }
    }
}
