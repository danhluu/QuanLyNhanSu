using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String Email { get; set; }
        public String HoTen { get; set; }
        public String DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public String GhiChu { get; set; }

        public int MaCongTy { get; set; }
        public CongTy CongTy { get; set; }

        public ChucVuNhanVien ChucVuNhanVien { get; set; }

        public Luong Luong { get; set; }

        public List<BangCap> BangCaps { get; set; }

        public List<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }

        public int MaPhongBan { get; set; }
        public PhongBan PhongBan { get; set; }

        public ChiTietHopDong ChiTietHopDong { get; set; }

    }
}
