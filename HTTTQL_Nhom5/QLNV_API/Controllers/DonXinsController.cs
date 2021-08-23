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
    public class DonXinsController : BaseController<DonXin>
    {
        IDonXinDL _db;
        public DonXinsController(IBaseDL<DonXin> dl, IDonXinDL db) : base(dl)
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
        [Route("CountDonXin")]
        public async Task<IActionResult> CountDonXin()
        {
            var x = await _db.CountDonXin();
            return Ok(x);
        }
        [HttpPost("{MaDon}")]
        public async Task<IActionResult> changeStatus(int MaDon)
        {
            var x = await _db.ChangeStatus(MaDon);
            return Ok(x);
        }
    }
}
