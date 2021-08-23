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
    public class KhoaDaoTaosController : BaseController<KhoaDaoTao>
    {
        IKhoaDaoTaoDL _db;
        public KhoaDaoTaosController(IBaseDL<KhoaDaoTao> dl, IKhoaDaoTaoDL db) : base(dl)
        {
            _db = db;
            
        }
        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _db.SetIsHide(MaNV);
            return Ok(x);
        }

        [HttpGet]
        [Route("HienThi")]
        public async Task<IActionResult> HienThi()
        {
            var x = await _db.HienThiKDT();
            return Ok(x);
        }
    }
}
