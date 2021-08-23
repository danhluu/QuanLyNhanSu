using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class ChucVu
    {
        public int MaChucVu { get; set; }
        public String TenChucVu { get; set; }
        public String? MoTa { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public List<ChucVuNhanVien> ChucVuNhanVien { get; set; }
        public List<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }
    }
}
