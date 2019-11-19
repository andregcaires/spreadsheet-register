using Microsoft.AspNetCore.Http;
using SpreadsheetRegister.Context.Interface;
using SpreadsheetRegister.Domain.Fluent;
using SpreadsheetRegister.Domain.Model;
using SpreadsheetRegister.Service.Interface;
using SpreadsheetRegister.Service.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpreadsheetRegister.Service.Application
{
    public class UserService : IUserService
    {
        private IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public UserResponseDTO Insert(IFormFile file)
        {
            int inserted = 0, updated = 0, ignored = 0, failed = 0;
            using (StreamReader reader = new StreamReader(file.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var values = reader.ReadLine().Split(";");

                    var user = User.New()
                        .WithName("name")
                        .WithEmail("email")
                        .WithGender("gender")
                        .WithBirthdate("birthdate");
                }

                return UserResponseDTO.New(inserted, updated, ignored, failed);
            }
        }
    }
}
