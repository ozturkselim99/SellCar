using sellcar.entity;
using System.Collections.Generic;

namespace sellcar.webui.Models
{
    public class IlanListViewModel
    {
        public List<Ilan> ilanlar { get; set; }
        public string min_fiyat { get; set; }
        public string max_fiyat { get; set; }
        public string min_kilometre { get; set; }
        public string max_kilometre { get; set; }
        public string min_yil { get; set; }
        public string max_yil { get; set; }
        public string[] yakit_tipi { get; set; }
        public string[] vites_tipi { get; set; }
        public string[] kasa_tipi { get; set; }
        public string min_beygir { get; set; }
        public string max_beygir { get; set; }
        public string[] cekis { get; set; }
        public string[] renk { get; set; }
        public string kimden { get; set; }
        public string durumu { get; set; }
        public string takasli { get; set; }
        public string[] il { get; set; }
    }
}
