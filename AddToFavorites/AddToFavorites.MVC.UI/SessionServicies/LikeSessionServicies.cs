using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddToFavorites.Entities.Tangible;
using AddToFavorites.MVC.UI.ExtendMethods;
using Microsoft.AspNetCore.Http;

namespace AddToFavorites.MVC.UI.SessionServicies
{
    public class LikeSessionServicies : ILikeSessionServicies
    {
        private IHttpContextAccessor _httpContextAccessor;
        public LikeSessionServicies(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Liked GetLike()
        {
            Liked LikegetObject = _httpContextAccessor.HttpContext.Session.GetObject<Liked>("like");
            if (LikegetObject == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("like", new Liked());
                LikegetObject = _httpContextAccessor.HttpContext.Session.GetObject<Liked>("like");
            }
            return LikegetObject;
        }

        public void SetLike(Liked liked)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("like", liked);
        }
    }
}
