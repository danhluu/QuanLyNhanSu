using Common.Data.EF;
using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application
{
    public class ThuongDL : BaseDL<Thuong>, IThuongDL
    {
        public ThuongDL(QLNVDbContext dl) : base(dl)
        {
        }
        //public readonly QLNVDbContext _dl2;

        //public ThuongDL(QLNVDbContext dl2)
        //{
        //    _dl2 = dl2;
        //}

        public async Task<int> Create(Thuong thuong)
        {
            _dl.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Thuong ON;");
            _dl.Thuongs.Add(thuong);
            await _dl.SaveChangesAsync();
            return thuong.MaThuong;
        }

        public async Task<int> Delete(int id)
        {
            var x = await _dl.Thuongs.FindAsync(id);
            _dl.Thuongs.Remove(x);
            return await _dl.SaveChangesAsync();
        }

        public async Task<IEnumerable<Thuong>> GetAllData()
        {
            var y = await base.GetAllData();
            //var x = await _dl.Thuongs.ToListAsync();
            return y;
        }

        public async Task<Thuong> GetByID(int maThuong)
        {
            
            return await base.GetById(maThuong);
        }

        public async Task Update(Thuong thuong)
        {
            await base.Update(thuong);
            
        }

        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.Thuongs.FindAsync(Ma);
            if (entity.IsHide == 1)
            {
                entity.IsHide = 0;
            }
            else
            {
                entity.IsHide = 1;
            }
            _dl.Update(entity);
            return await _dl.SaveChangesAsync();
        }
    }
}
