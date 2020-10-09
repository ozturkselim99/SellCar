﻿using System.Collections.Generic;

namespace sellcar.webui.Models
{
    public class UserDetailModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailComfirmed { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
