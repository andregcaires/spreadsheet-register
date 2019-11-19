using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Domain.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

        public static User New()
        {
            return new User();
        }

    }
}
