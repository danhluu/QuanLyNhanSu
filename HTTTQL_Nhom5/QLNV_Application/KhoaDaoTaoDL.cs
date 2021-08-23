using Common.Data.Common;
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
    public class KhoaDaoTaoDL : BaseDL<KhoaDaoTao>, IKhoaDaoTaoDL
    {
        public KhoaDaoTaoDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<IEnumerable<KhoaDaoTaoHienThi>> HienThiKDT()
        {
            var query = from kdt in _dl.KhoaDaoTaos
                        join nv in _dl.NhanViens on kdt.MaNV equals nv.MaNV
                        select new { kdt, nv };
            var entities = await query.Select(x => new KhoaDaoTaoHienThi()
            {
                MaKhoaDaoTao = x.kdt.MaKhoaDaoTao,
                TenKhoa = x.kdt.TenKhoa,
                NgayBatDau = x.kdt.NgayBatDau,
                NgayKetThuc = x.kdt.NgayKetThuc,
                MaNV = x.nv.MaNV,
                TenNhanVien = x.nv.username,
                IsHide = x.kdt.IsHide
            }).Where(z=>z.IsHide==1).ToListAsync();

            return entities;
        }

        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.KhoaDaoTaos.FindAsync(Ma);
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
