using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                if (Request.Form.Files.Count() > 0)
                {
                    return new JsonResult(_service.Insert(Request.Form.Files.FirstOrDefault()));
                }

                return new JsonResult("File not found")
                {
                    StatusCode = 404
                };
            } catch (Exception e)
            {
                return new JsonResult(e)
                {
                    StatusCode = 500
                };
            }
        }
    }
}