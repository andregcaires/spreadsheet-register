using Microsoft.AspNetCore.Http;
using SpreadsheetRegister.Service.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Service.Interface
{
    public interface IUserService
    {
        UserResponseDTO Insert(IFormFile file);
    }
}
