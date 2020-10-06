using System;
using System.Collections.Generic;
using System.Text;

namespace E1_Classes.User
{
    public class User
    {
        public  Guid UserID { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public Role UserRole { get; set; }


    }
}
