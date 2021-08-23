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
    public class HienThiNhanVienController : ControllerBase
    {
        protected readonly INhanVienDL _dl;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dl"></param>
        public HienThiNhanVienController(INhanVienDL dl)
        {
            _dl = dl;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var x = await _dl.DanhSachNhanVien();
            return Ok(x);
        }
    }
}
