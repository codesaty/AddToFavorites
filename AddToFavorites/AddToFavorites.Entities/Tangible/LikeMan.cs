using System;
using System.Collections.Generic;
using System.Text;

namespace AddToFavorites.Entities.Tangible
{
    //Favorim'deki nesneler
    public class LikeMan
    {
        //Favorim'deki Ürünler
        public Product Product { get; set; }
        //Ürünün Favoriye Eklendiği Tarih
        public DateTime DateTime { get; set; }
    }
}
