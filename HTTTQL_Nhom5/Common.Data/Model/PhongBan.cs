using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class PhongBan
    {
        public int MaPhongBan { get; set; }
        public String TenPhongBan { get; set; }
        public String? sdt { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public int? MaCongTy { get; set; }
        public CongTy CongTy { get; set; }

        public List<NhanVien> NhanViens { get; set; }

        public List<PhongBanNhanVien> PhongBanNhanViens { get; set; }
    }
}
