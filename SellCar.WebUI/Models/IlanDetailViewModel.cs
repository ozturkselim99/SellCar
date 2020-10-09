using sellcar.entity;
using sellcar.webui.Identity;
using System.Collections.Generic;

namespace sellcar.webui.Models
{
    public class IlanDetailViewModel
    {
        public  Ilan ilan { get; set; }
        public User user { get; set; }
        public bool ilanFavorilerdemi { get; set; }
        public List<Resim> ilanResimleri { get; set; }
    }
}
