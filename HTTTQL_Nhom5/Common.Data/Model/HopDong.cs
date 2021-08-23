using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class HopDong
    {
        public int MaHopDong { get; set; }
        public String? NoiDung { get; set; }
        public String? GhiChu { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public List<ChiTietHopDong> ChiTietHopDongs { get; set; }
    }
}
