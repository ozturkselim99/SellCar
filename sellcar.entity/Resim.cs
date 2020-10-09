using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace sellcar.entity
{
    public class Resim
    {
        [Key]
        public int Id { get; set; }
        public string url { get; set; }

        public int IlanId { get; set; }
        public Ilan Ilan { get; set; }

    }
}
