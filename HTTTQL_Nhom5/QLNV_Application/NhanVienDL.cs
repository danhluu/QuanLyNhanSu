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
    public class NhanVienDL : BaseDL<NhanVien>, INhanVienDL
    {
        public NhanVienDL(QLNVDbContext dl) : base(dl)
        {
        }


        public async Task<IEnumerable<NhanVienHienThi>> DanhSachNhanVien()
        {
            //MaNV - NhanVien
            //Ten NV - HoSoNhanVien
            //TenPhongBan - PhongBan
            //var sql = "Select nv.MaNV, hsnv.HoTen, nv.username, pb.TenPhongBan" +
            //    " from NhanVien as nv left join PhongBan as pb" +
            //    " on nv.MaPhongBan = pb.MaPhongBan " +
            //    "left join HoSoNhanVien as hsnv " +
            //    "on nv.MaHSNV = hsnv.MaHSNV; ";
            var query = from nv in _dl.NhanViens
                        join hsnv in _dl.HoSoNhanViens on nv.MaHSNV equals hsnv.MaHSNV
                        join pb in _dl.PhongBans on nv.MaPhongBan equals pb.MaPhongBan
                        select new { nv, hsnv, pb };
            var data = await query.Select(x => new NhanVienHienThi()
            {
                MaNV = x.nv.MaNV,
                TenNV = x.hsnv.HoTen,
                MaPB = x.pb.MaPhongBan,
                PhongBan = x.pb.TenPhongBan,
                username = x.nv.username,
                password = x.nv.password,
                Status = x.nv.Status,
                IsHide = x.nv.IsHide
            }).Where(z=>z.IsHide==1).ToListAsync();
            
            //var data = await _dl.NhanViens.FromSqlRaw(sql).ToListAsync();
            return data;
        }

        public async Task<int> ChangeStatus(int MaNV)
        {
            var entity = await _dl.NhanViens.FindAsync(MaNV);
            if (entity.Status == 0) entity.Status = 1;
            else entity.Status = 0;
            _dl.Update(entity);
            await _dl.SaveChangesAsync();
            return entity.Status;
        }

        public async Task<int> SetIsHide(int MaNV)
        {
            var nv = await _dl.NhanViens.FindAsync(MaNV);
            if (nv.IsHide == 1)
            {
                nv.IsHide = 0;
            }
            else
            {
                nv.IsHide = 1;
            }
            _dl.Update(nv);
            return await _dl.SaveChangesAsync();
        }

        public async Task<IEnumerable<NhanVien>> NhanVienChuaCoHopDong()
        {
            var sql = "select * from NhanVien as nv " +
                "where nv.MaNV not in (select MaNV from ChiTietHopDong ) AND IsHide = 1";
            var entities = await _dl.NhanViens.FromSqlRaw(sql).ToListAsync();
            return entities;
        }

        public async Task<NhanVien> getNhanVietByUserName(String username)
        {
            var query = await _dl.NhanViens.Where(x => x.username == username).FirstOrDefaultAsync();
            return query;
        }

        public async Task<int> DoiMatKhau(Login nv)
        {
            var x = await getNhanVietByUserName(nv.username);
            x.password = nv.password;
            _dl.NhanViens.Update(x);
            await _dl.SaveChangesAsync();
            return x.MaNV;
        }
    }
}
