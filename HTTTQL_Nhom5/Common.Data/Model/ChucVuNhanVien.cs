using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class ChucVuNhanVien
    {
        public int MaCVNV { get; set; }
        public DateTime? NgayBoNhiem { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public int? MaChucVu { get; set; }
        public ChucVu ChucVu { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
