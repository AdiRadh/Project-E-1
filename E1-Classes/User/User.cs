using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E1_Classes.User
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public Role UserRole { get; set; }
    }
}
