using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int? IsHide { get; set; }

        public String? GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int Status { get; set; }

        public int? MaCongTy { get; set; }
        public CongTy CongTy { get; set; }

        public ChucVuNhanVien ChucVuNhanVien { get; set; }

        public List<Luong> Luong { get; set; }

       public List<PhongBanNhanVien> PhongBanNhanViens { get; set; }

        public List<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }

        public int? MaPhongBan { get; set; }
        public PhongBan PhongBan { get; set; }

        public ChiTietHopDong ChiTietHopDong { get; set; }

        public List<DonXin> DonXins { get; set; }

        public List<KhoaDaoTao> KhoaDaoTaos { get; set; }

        public int? MaHSNV { get; set; }
        public HoSoNhanVien HoSoNhanVien { get; set; }

    }
}
