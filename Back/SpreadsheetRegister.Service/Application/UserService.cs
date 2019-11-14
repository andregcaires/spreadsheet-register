using SpreadsheetRegister.Context.Repository;
using SpreadsheetRegister.Service.Interface;
using System;
using System.Collections.Generic;
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
    }
}
