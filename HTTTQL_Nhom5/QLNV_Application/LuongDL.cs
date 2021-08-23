using Common.Data.Common;
using Common.Data.EF;
using Common.Data.Model;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QLNV_Application
{
    public class LuongDL : BaseDL<Luong>, ILuongDL
    {
        public LuongDL(QLNVDbContext dl) : base(dl)
        {
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.Luongs.FindAsync(Ma);
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

        //XYZ
        public async Task<int> AddLuong(Luong luong)
        {
            var bacLuong = await _dl.BacLuongs.FindAsync(luong.MaBacLuong);
            var thuong = await _dl.Thuongs.FindAsync(luong.MaThuong);
            var phuCap = await _dl.PhuCaps.FindAsync(luong.MaPhuCap);
            if (bacLuong.MucLuong == 0 && thuong.MucThuong == 0 && phuCap.MucPhuCap == 0)
                luong.luong = 0;
            else
                luong.luong = bacLuong.MucLuong * 26 + thuong.MucThuong + phuCap.MucPhuCap;
            await _dl.Luongs.AddAsync(luong);
            await _dl.SaveChangesAsync();

            return luong.MaLuong;

        }

        public async Task<int> UpdateLuong(Luong luong)
        {
            var bacLuong = await _dl.BacLuongs.FindAsync(luong.MaBacLuong);
            var thuong = await _dl.Thuongs.FindAsync(luong.MaThuong);
            var phuCap = await _dl.PhuCaps.FindAsync(luong.MaPhuCap);
            if (bacLuong.MucLuong == 0 && thuong.MucThuong == 0 && phuCap.MucPhuCap == 0)
                luong.luong = 0;
            else
                luong.luong = bacLuong.MucLuong * 26 + thuong.MucThuong + phuCap.MucPhuCap;
            _dl.Luongs.Update(luong);
            await _dl.SaveChangesAsync();
            return luong.MaLuong;
        }

        /// <summary>
        /// Hiển thị lương
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LuongHienThi>> HienThiLuong()
        {
            var query = from l in _dl.Luongs
                        join nv in _dl.NhanViens on l.MaNV equals nv.MaNV
                        join bl in _dl.BacLuongs on l.MaBacLuong equals bl.MaBacLuong
                        join pc in _dl.PhuCaps on l.MaPhuCap equals pc.MaPhuCap
                        join th in _dl.Thuongs on l.MaThuong equals th.MaThuong
                        select new { l, nv, bl, pc, th };
            var entities = await query.Select(x => new LuongHienThi()
            {
                MaLuong = x.l.MaLuong,
                luong = x.l.luong,
                Thang = x.l.Thang,
                IsHide = x.l.IsHide,
                MaNV = x.l.MaNV,
                username = x.nv.username,
                MaPhuCap = x.l.MaPhuCap,
                MucPhuCap = x.pc.MucPhuCap,
                MaBacLuong = x.l.MaBacLuong,
                MucLuong = x.bl.MucLuong,
                MaThuong = x.l.MaThuong,
                MucThuong = x.th.MucThuong

            }).Where(z => z.IsHide == 1).ToListAsync();
            return entities;
        }
    }
}
