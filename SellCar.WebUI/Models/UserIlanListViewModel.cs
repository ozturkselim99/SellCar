using sellcar.entity;
using sellcar.webui.Identity;
using System.Collections.Generic;

namespace sellcar.webui.Models
{
    public class UserIlanListViewModel
    {
        public List<Ilan>  ilanlar { get; set; }
        public User user { get; set; }
    }
}
