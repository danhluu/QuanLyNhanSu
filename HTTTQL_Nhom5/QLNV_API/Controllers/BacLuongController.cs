using Common.Data.Model;
using Microsoft.AspNetCore.Mvc;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QLNV_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BacLuongController : BaseController<BacLuong>
    {
        IBacLuongDL _db;
        public BacLuongController(IBaseDL<BacLuong> dl, IBacLuongDL db) : base(dl)
        {
            _db = db;
        }

        [HttpPost("SetIsHide/{Ma}")]
        public async Task<IActionResult> SetIsHide(int Ma)
        {
            var x = await _db.SetIsHide(Ma);
            return Ok(x);
        }
    }
}
