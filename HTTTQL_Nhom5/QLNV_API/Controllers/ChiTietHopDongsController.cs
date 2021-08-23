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
    public class ChiTietHopDongsController : BaseController<ChiTietHopDong>
    {
        IChiTietHopDongDL _db;
        public ChiTietHopDongsController(IBaseDL<ChiTietHopDong> dl, IChiTietHopDongDL db) : base(dl)
        {
            _db=db;
        }
        [HttpPost("SetIsHide/{Ma}")]
        public async Task<IActionResult> SetIsHide(int Ma)
        {
            var x = await _db.SetIsHide(Ma);
            return Ok(x);
        }

        [HttpGet]
        [Route("HienThi")]
        public async Task<IActionResult> HienThi()
        {
            var x = await _db.HienThiCTHD();
            return Ok(x);
        }
    }
}
