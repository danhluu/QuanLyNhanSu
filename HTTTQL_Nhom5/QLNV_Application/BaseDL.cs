using Common.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QLNV_Application.Interface;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace QLNV_Application
{
    public class BaseDL<T> : IBaseDL<T>
        where T : class
    {
        public int IsHide { get; set; }
        protected readonly QLNVDbContext _dl;
        public BaseDL(QLNVDbContext dl)
        {
            _dl = dl;
        }

        public async Task<int> Create(T entity)
        {
            await _dl.Set<T>().AddAsync(entity);
            await _dl.SaveChangesAsync();
            return 1;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await GetById(id);
            _dl.Set<T>().Remove(entity);
            await _dl.SaveChangesAsync();
            return 1;
        }

        public async Task<IEnumerable<T>> GetAllData()
        {
            var tableName = typeof(T).Name;
            //var entities = await _dl.Set<T>().ToListAsync();
            var query = $"Select * From {tableName} as tbl Where tbl.IsHide=1;";
            var ens = await _dl.Set<T>().FromSqlRaw(query).ToListAsync();
            return ens;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetById(int id)
        {
            return await _dl.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dl.Set<T>().Update(entity);
            await _dl.SaveChangesAsync();
        }
    }
}
