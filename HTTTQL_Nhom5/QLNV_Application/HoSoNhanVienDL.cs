using Common.Data.EF;
using Common.Data.Model;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Common.Data.Common;

namespace QLNV_Application
{
    public class HoSoNhanVienDL : BaseDL<HoSoNhanVien>, IHoSoNhanVienDL
    {
        public HoSoNhanVienDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<IEnumerable<HoSoNhanVien>> getMaHSSV()
        {
            var query = await _dl.HoSoNhanViens.FromSqlRaw("select distinct hsnv.* from HoSoNhanVien as hsnv " +
                "where hsnv.MaHSNV not in (select NhanVien.MaHSNV from NhanVien where NhanVien.MaHSNV is not null)").ToListAsync();
            return query;
        }
        public async Task<int> SetIsHide(int Ma)
        {
            var entity = await _dl.HoSoNhanViens.FindAsync(Ma);
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

        public async Task<HienThiHSNV> HienThiHSNV(String username)
        {
            var nv =await _dl.NhanViens.Where(x => x.username == username).FirstOrDefaultAsync();
            var hsnv = await _dl.HoSoNhanViens.FindAsync(nv.MaHSNV);
            var pb = await _dl.PhongBans.FindAsync(nv.MaPhongBan);

            var cths = new HienThiHSNV()
            {
                MaNV = nv.MaNV,
                username = nv.username,
                password = nv.password,
                IsHide = hsnv.IsHide,
                MaPhongBan = nv.MaPhongBan,
                TenPhongBan = pb.TenPhongBan,
                MaHSNV = nv.MaHSNV,
                HoTen = hsnv.HoTen,
                DiaChi = hsnv.DiaChi,
                QueQuan = hsnv.QueQuan,
                NgaySinh = hsnv.NgaySinh,
                Email = hsnv.Email,
                sdt = hsnv.sdt,
                TruongHoc = hsnv.TruongHoc
            };
            return cths;
        }
    }
}
