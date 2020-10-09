using sellcar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sellcar.webui.Models
{
    public class IlModel
    {
        public int ilId { get; set; }
        public string adi { get; set; }
        public List<Ilan> Ilanlar { get; set; }
    }
}
