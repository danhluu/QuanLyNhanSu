using Common.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        protected readonly ILoginDL _dl;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dl"></param>
        public LoginController(ILoginDL dl)
        {
            _dl = dl;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Login login)
        {
            var x = await _dl.CheckLogin(login);
            if (x != null)
            {
                return Ok(x);
            }
            return Ok("Sai Tai Khoan Hoac Mat Khau");
        }

        [HttpPost]
        [Route("HAHA")]
        public IActionResult Create2()
        {
            return Ok("2 phuong thuc post Duoc Chu Sao Khong");
        }
    }
}
