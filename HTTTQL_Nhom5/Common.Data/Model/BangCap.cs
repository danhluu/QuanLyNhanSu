using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class BangCap
    {
        public int MaBangCap { get; set; }
        public String TenChuyenMon { get; set; }
        public String? NoiDaoTao { get; set; }
        public String? HeDaoTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public int? MaHSNV { get; set; }
        public HoSoNhanVien HoSoNhanVien { get; set; }
    }
}
