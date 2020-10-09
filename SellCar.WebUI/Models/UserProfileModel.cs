using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sellcar.webui.Models
{
    public class UserProfileModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MembershipDate { get; set; }
    }
}
