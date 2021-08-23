using Common.Data.EF;
using Common.Data.Model;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application
{
    public class PhuCapDL : BaseDL<PhuCap>, IPhuCapDL
    {
        public PhuCapDL(QLNVDbContext dl) : base(dl)
        {
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.PhuCaps.FindAsync(Ma);
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
