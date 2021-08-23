using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class KhoaDaoTaoHienThi
    {
        public int MaKhoaDaoTao { get; set; }
        public String? TenKhoa { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public String? TenNhanVien { get; set; }

    }
}
