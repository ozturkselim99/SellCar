using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sellcar.entity
{
    public class Marka
    {
        [Key]
        public int MarkaId { get; set; }
        public string adi { get; set; }
        public string url { get; set; }

        public List<Ilan> Ilanlar  { get; set; }
    }
}
