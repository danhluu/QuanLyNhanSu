using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class ChucVu
    {
        public int MaChucVu { get; set; }
        public String TenChucVu { get; set; }
        public String MoTa { get; set; }

        public List<ChucVuNhanVien> ChucVuNhanVien { get; set; }
        public QuyetDinhBoNhiem QuyetDinhBoNhiem { get; set; }
    }
}
