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
    public class BaseController<T> : ControllerBase
        where T : class
    {
        protected readonly IBaseDL<T> _dl;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dl"></param>
        public BaseController(IBaseDL<T> dl)
        {
            _dl = dl;
        }



        /// <summary>
        /// Lay Tat Ca Ban Ghi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<T>> Get()
        {
            return await _dl.GetAllData();
        }

        /// <summary>
        /// Get By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<T> Get(int id)
        {
            return await _dl.GetById(id);
        }

        /// <summary>
        /// Them Moi Ban Ghi
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            var x = await _dl.Create(entity);
            return Ok(x);
        }

        /// <summary>
        /// Sua Ban Ghi
        /// </summary>
        /// <param name="thuong"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] T entity)
        {
            await _dl.Update(entity);
            return Ok(1);
        }


        /// <summary>
        /// Xoa Ban Ghi
        /// </summary>
        /// <param name="Ma"></param>
        /// <returns></returns>
        [HttpDelete("{Ma}")]
        public async Task<IActionResult> Delete(int Ma)
        {
            var x = await _dl.Delete(Ma);
            return Ok(x);
        }
    }
}
