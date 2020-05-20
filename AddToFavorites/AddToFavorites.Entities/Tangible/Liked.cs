using System;
using System.Collections.Generic;
using System.Text;

namespace AddToFavorites.Entities.Tangible
{
    //Favori Alanım.
    public class Liked
    {
        public Liked()
        {
            LikeMan = new List<LikeMan>();
        }
        public List<LikeMan> LikeMan  { get;}
    }
}
