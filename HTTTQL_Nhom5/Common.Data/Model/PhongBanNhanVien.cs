using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class PhongBanNhanVien
    {
        public int MaPBNV { get; set; }

        public int? MaPB { get; set; }
        public PhongBan PhongBan;
        public String? TenPhongBan { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
        public String username { get; set; }

        public DateTime? NgayChuyen { get; set; }
        public String? LyDo { get; set; }
        public int? IsHide { get; set; }
        public int? Status { get; set; }


    }
}
