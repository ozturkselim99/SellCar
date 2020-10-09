using System.Collections.Generic;

namespace sellcar.webui.Models
{
    public class FavModel
    {
        public List<FavItemModel> Favs { get; set; }

    }
    public class FavItemModel
    {
        public int IlanId { get; set; }
        public string resimUrl { get; set; }
        public string ilanBasligi { get; set; }
        public string markaAdi { get; set; }
        public string seri { get; set; }
        public string model { get; set; }
        public double fiyat { get; set; }
    }
}
