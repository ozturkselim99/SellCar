using Microsoft.AspNetCore.Identity;
using System;

namespace sellcar.webui.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
