using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Service.Util
{
    public class UserResponseDTO
    {
        public int InsertedRegistries { get; set; }
        public int UpdatedRegistries { get; set; }
        public int IgnoredRegistries { get; set; }
        public int FailedRegistries { get; set; }

        public static UserResponseDTO New(int InsertedRegistries, int UpdatedRegistries,
            int IgnoredRegistries, int FailedRegistries)
        {
            return new UserResponseDTO()
            {
                InsertedRegistries = InsertedRegistries,
                UpdatedRegistries = UpdatedRegistries,
                IgnoredRegistries = IgnoredRegistries,
                FailedRegistries = FailedRegistries
            };
        }

    }
}
