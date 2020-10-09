using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sellcar.entity
{
    public class Il
    {
        [Key]
        public int ilId { get; set; }
        public string adi { get; set; }
        public List<Ilan> Ilanlar { get; set; }
    }
}