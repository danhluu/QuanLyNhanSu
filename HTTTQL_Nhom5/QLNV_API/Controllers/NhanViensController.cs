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
    public class NhanViensController : BaseController<NhanVien>
    {
        INhanVienDL _db;
        public NhanViensController(IBaseDL<NhanVien> dl, INhanVienDL db) : base(dl)
        {
            _db = db;
        }

        [HttpPost("{MaNV}")]
        public async Task<IActionResult> changeStatus(int MaNV)
        {
            var x = await _db.ChangeStatus(MaNV);
            return Ok(x);
        }

        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _db.SetIsHide(MaNV);
            return Ok(x);
        }

        [HttpGet]
        [Route("NhanVienChuaCoHopDong")]
        public async Task<IActionResult> NhanVienChuaCoHopDong()
        {
            var entities = await _db.NhanVienChuaCoHopDong();
            return Ok(entities);
        }

        [HttpGet("Get/{username}") ]
        public async Task<IActionResult> GetNhanVienByUserName(String username)
        {
            var entities = await _db.getNhanVietByUserName(username);
            return Ok(entities);
        }



        [HttpPost]
        [Route("DoiMatKhau")]
        public async Task<IActionResult> SetIsHide(Login nv)
        {
            var x = await _db.DoiMatKhau(nv);
            return Ok(x);
        }
    }
}
