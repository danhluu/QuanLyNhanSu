using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class PhuCap
    {
        public int MaPhuCap { get; set; }
        public String? LoaiPhuCap { get; set; }
        public int? MucPhuCap { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public List<Luong> Luongs { get; set; }
    }
}
