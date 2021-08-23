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
    public class PhongBanNhanVienController : BaseController<PhongBanNhanVien>
    {
        IPhongBanNhanVienDL _db;
        public PhongBanNhanVienController(IBaseDL<PhongBanNhanVien> dl, IPhongBanNhanVienDL db) : base(dl)
        {
            _db = db;
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddPBNV(PhongBanNhanVien pbnv)
        {
            var x = await _db.AddPhongBanNhanVien(pbnv);
            return Ok(x);

        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetDatas()
        {
            var en = await _db.getDatas();
            return Ok(en);
        }
    }
}
