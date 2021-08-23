using Common.Data.EF;
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
    public class ThuongsController : ControllerBase
    {
        // GET: api/<ThuongsController>
        IThuongDL _dl;
        public ThuongsController(IThuongDL dl)
        {
            _dl = dl;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var x = await _dl.GetAllData();
            return Ok(x);
        }

        [HttpGet("{Ma}")]
        public async Task<IActionResult> Get(int Ma)
        {
            var x = await _dl.GetByID(Ma);
            return Ok(x);
        }


        // POST api/<ThuongsController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Thuong thuong)
        {
            var x = await _dl.Create(thuong);
            return Ok(x);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Thuong thuong)
        {
            await _dl.Update(thuong);
            return Ok(1);
        }

        [HttpDelete("{Ma}")]
        public async Task<IActionResult> Delete(int Ma)
        {
            var x = await _dl.Delete(Ma);
            return Ok(x);
        }

        [HttpPost("SetIsHide/{MaNV}")]
        public async Task<IActionResult> SetIsHide(int MaNV)
        {
            var x = await _dl.SetIsHide(MaNV);
            return Ok(x);
        }


    }
}
