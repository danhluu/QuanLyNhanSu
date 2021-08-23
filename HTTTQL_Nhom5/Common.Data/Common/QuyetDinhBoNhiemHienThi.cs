using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class QuyetDinhBoNhiemHienThi
    {
        public int MaQDBN { get; set; }
        public DateTime? NgayBoNhiem { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public String TenNhanVien { get; set; }

        public int? MaQL { get; set; }
        public String TenQuanLy { get; set; }

        public int? MaChucVu { get; set; }
        public String TenChucVu { get; set; }

    }
}
