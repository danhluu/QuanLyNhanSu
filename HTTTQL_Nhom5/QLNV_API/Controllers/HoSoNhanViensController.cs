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
    public class HoSoNhanViensController : BaseController<HoSoNhanVien>
    {
        public readonly IHoSoNhanVienDL _db;
        public HoSoNhanViensController(IBaseDL<HoSoNhanVien> dl, IHoSoNhanVienDL db) : base(dl)
        {
            _db = db;
        }

        [HttpGet]
        [Route("GetMaHSNV")]
        public async Task<IActionResult> GetMaHSNV()
        {
            var results = await _db.getMaHSSV();
            return Ok(results);
        }
        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _db.SetIsHide(MaNV);
            return Ok(x);
        }

        [HttpGet("HienThi/{username}")]
        public async Task<IActionResult> HienThiHSNV(String username)
        {
            var x = await _db.HienThiHSNV(username);
            return Ok(x);
        }
    }
}
