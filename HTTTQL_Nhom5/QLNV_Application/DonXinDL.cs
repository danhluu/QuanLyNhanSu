using Common.Data.EF;
using Common.Data.Model;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QLNV_Application
{
    public class DonXinDL : BaseDL<DonXin>, IDonXinDL
    {
        public DonXinDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<int> CountDonXin()
        {
            var entities = await _dl.DonXins.Where(x => x.Status == 0).CountAsync();
            return entities;
        }

        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.DonXins.FindAsync(Ma);
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

        public async Task<int> ChangeStatus(int MaDon)
        {
            var entity = await _dl.DonXins.FindAsync(MaDon);
            if (entity.Status == 0) entity.Status = 1;
            else entity.Status = 0;
            _dl.Update(entity);
            await _dl.SaveChangesAsync();
            return entity.Status;
        }

    }
}
