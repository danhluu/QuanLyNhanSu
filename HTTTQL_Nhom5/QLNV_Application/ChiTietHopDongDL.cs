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
    public class ChiTietHopDongDL : BaseDL<ChiTietHopDong>, IChiTietHopDongDL
    {
        public ChiTietHopDongDL(QLNVDbContext dl) : base(dl)
        {
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.ChiTietHopDongs.FindAsync(Ma);
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
        public async Task<IEnumerable<ChiTietHopDongHienThi>> HienThiCTHD()
        {
            var query = from cthd in _dl.ChiTietHopDongs
                        join nv in _dl.NhanViens on cthd.MaNV equals nv.MaNV
                        join ql in _dl.QuanLies on cthd.MaQL equals ql.MaQL
                        join hd in _dl.HopDongs on cthd.MaHopDong equals hd.MaHopDong
                        select new { cthd, ql, nv, hd };
            var entities = await query.Select(x => new ChiTietHopDongHienThi()
            {
                MaCTHD  = x.cthd.MaCTHD,
                LoaiHopDong = x.cthd.LoaiHopDong,

                NgayKy = x.cthd.NgayKy,
                NgayKetThuc = x.cthd.NgayKetThuc,
                NoiDung = x.hd.NoiDung,
                IsHide = x.cthd.IsHide,
                MaHopDong = x.hd.MaHopDong,
                MaNV = x.nv.MaNV,
                TenNhanVien = x.nv.username,
                MaQL = x.ql.MaQL,
                HoTen = x.ql.HoTen

            }).Where(z => z.IsHide == 1).ToListAsync();
            return entities;

        }
    }
}
