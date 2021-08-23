using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class ChiTietKhoaDaoTao
    {
        public int MaHV { get; set; }
        public String? TenHocVien { get; set; }
        public String? Truong { get; set; }
        public int? IsHide { get; set; }

        public int? MaKhoaDaoTao { get; set; }
        public KhoaDaoTao KhoaDaoTao { get; set; }

    }
}
