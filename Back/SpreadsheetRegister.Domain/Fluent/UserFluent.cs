using SpreadsheetRegister.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Domain.Fluent
{
    public static class UserFluent
    {
        public static User WithName(this User user, string name)
        {
            user.Name = name;
            return user;
        }

        public static User WithEmail(this User user, string email)
        {
            user.Email = email;
            return user;
        }

        public static User WithBirthdate(this User user, string birthDate)
        {
            user.BirthDate = DateTime.Parse(birthDate);
            return user;
        }

        public static User WithGender(this User user, string gender)
        {
            user.Gender = gender;
            return user;
        }
    }
}
