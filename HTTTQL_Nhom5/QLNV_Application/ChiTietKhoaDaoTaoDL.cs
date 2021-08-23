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
    public class ChiTietKhoaDaoTaoDL : BaseDL<ChiTietKhoaDaoTao>, IChiTietKhoaDaoTaoDL
    {
        public ChiTietKhoaDaoTaoDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<IEnumerable<ChiTietKhoaDaoTao>> GetDanhSachLop(int MaLop)
        {
            var entities = await _dl.ChiTietKhoaDaoTaos.Where(x => x.MaKhoaDaoTao == MaLop).ToListAsync();
            return entities;
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.ChiTietKhoaDaoTaos.FindAsync(Ma);
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
