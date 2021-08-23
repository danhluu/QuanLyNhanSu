using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class QuyetDinhBoNhiem
    {
        public int MaQDBN { get; set; }
        public DateTime? NgayBoNhiem { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        public int? MaQL { get; set; }
        public QuanLy QuanLy { get; set; }

        public int? MaChucVu { get; set; }
        public ChucVu ChucVu { get; set; }


    }
}
