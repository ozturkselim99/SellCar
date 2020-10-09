using sellcar.entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sellcar.webui.Models
{
    public class MarkaModel
    {
        [Required]
        public int MarkaId { get; set; }
        public string adi { get; set; }
        public string url { get; set; }
        public List<Ilan> Ilanlar { get; set; }
    }
}
