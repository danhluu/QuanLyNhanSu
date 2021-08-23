using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class Luong
    {
        public int MaLuong { get; set; }
        public int? luong { get; set; }
        public String Thang { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        public int? MaPhuCap { get; set; }
        public PhuCap PhuCap { get; set; }

        public int? MaBacLuong { get; set; }
        public BacLuong BacLuong { get; set; }

        public int? MaThuong { get; set; }
        public Thuong Thuong { get; set; }
    }
}
