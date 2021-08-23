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
    public class ChiTietKhoaDaoTaosController : BaseController<ChiTietKhoaDaoTao>
    {
        IChiTietKhoaDaoTaoDL _db;
        public ChiTietKhoaDaoTaosController(IBaseDL<ChiTietKhoaDaoTao> dl, IChiTietKhoaDaoTaoDL db) : base(dl)
        {
            _db = db;
        }


        [HttpGet("Lop/{MaLop}")]
        public async Task<IActionResult> Get(int MaLop)
        {
            var x = await _db.GetDanhSachLop(MaLop);
            return Ok(x);
        }
        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _db.SetIsHide(MaNV);
            return Ok(x);
        }
    }
}
