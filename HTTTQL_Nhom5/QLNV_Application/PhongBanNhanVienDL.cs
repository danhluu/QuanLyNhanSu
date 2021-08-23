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
    public class PhongBanNhanVienDL : BaseDL<PhongBanNhanVienDL>, IPhongBanNhanVienDL
    {
        public PhongBanNhanVienDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<int> AddPhongBanNhanVien(PhongBanNhanVien pbnv)
        {
            var pb = await _dl.PhongBans.FindAsync(pbnv.MaPB);
            var nv = await _dl.NhanViens.FindAsync(pbnv.MaNV);
            nv.MaPhongBan = pbnv.MaPB;
            pbnv.TenPhongBan = pb.TenPhongBan;
            pbnv.username = nv.username;
            pbnv.IsHide = 1;

            _dl.NhanViens.Update(nv);
            await _dl.PhongBanNhanViens.AddAsync(pbnv);

            await _dl.SaveChangesAsync();

            return pbnv.MaPBNV;
        }

        public async Task<IEnumerable<PhongBanNhanVien>> getDatas()
        {
            var entities = await _dl.PhongBanNhanViens.Where(x => x.IsHide == 1).ToListAsync();

            return entities;
        }

    }
}
