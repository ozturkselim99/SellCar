using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace sellcar.entity
{
    public class Fav
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int IlanId { get; set; }
        public Ilan Ilan { get; set; }
    }
}
