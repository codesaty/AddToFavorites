using AddToFavorites.Entities.Tangible;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddToFavorites.MVC.UI.SessionServicies
{
    public interface ILikeSessionServicies
    {
        Liked GetLike();
        void SetLike(Liked liked);
    }
}
