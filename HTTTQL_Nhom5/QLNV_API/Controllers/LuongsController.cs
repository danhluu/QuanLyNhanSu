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
    public class LuongsController : BaseController<Luong>
    {
        ILuongDL _db;
        public LuongsController(IBaseDL<Luong> dl, ILuongDL db) : base(dl)
        {
            _db = db;
        }
        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _db.SetIsHide(MaNV);
            return Ok(x);
        }

        [HttpPost]
        [Route("AddLuong")]
        public async Task<IActionResult> AddLuong(Luong luong)
        {
            var x = await _db.AddLuong(luong);
            return Ok(x);
        }
        
        [HttpPut]
        [Route("UpdateLuong")]
        public async Task<IActionResult> UpdateLuong(Luong luong)
        {
            var x = await _db.UpdateLuong(luong);
            return Ok(x);
        }

        [HttpGet]
        [Route("HienThi")]
        public async Task<IActionResult> HienThiLuong()
        {
            var x = await _db.HienThiLuong();
            return Ok(x);
        }
    }
}
