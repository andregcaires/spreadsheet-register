using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpreadsheetRegister.Service.Interface;

namespace SpreadsheetRegister.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public JsonResult Post()
        {
            IFormFileCollection file = Request.Form.Files;

            return new JsonResult(file)
            {
                StatusCode = 200
            };
        }
    }
}