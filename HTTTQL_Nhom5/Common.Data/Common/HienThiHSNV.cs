using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class HienThiHSNV
    {
        public int MaNV { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int? IsHide { get; set; }

        public int? MaPhongBan { get; set; }
        public String TenPhongBan { get; set; }

        public int? MaHSNV { get; set; }

        public String HoTen { get; set; }
        public String? DiaChi { get; set; }
        public String? QueQuan { get; set; }
        public DateTime? NgaySinh { get; set; }
        public String? Email { get; set; }
        public String? sdt { get; set; }
        public String? TruongHoc { get; set; }
    }
}
