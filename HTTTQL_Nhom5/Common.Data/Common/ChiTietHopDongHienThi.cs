using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class ChiTietHopDongHienThi
    {
        public int MaCTHD { get; set; }
        public String LoaiHopDong { get; set; }
        public DateTime? NgayKy { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }

        public String NoiDung { get; set; }
        public int? IsHide { get; set; }

        public int? MaHopDong { get; set; }

        public int? MaNV { get; set; }
        public String TenNhanVien { get; set; }

        public int? MaQL { get; set; }
        public String HoTen { get; set; }
    }
}
