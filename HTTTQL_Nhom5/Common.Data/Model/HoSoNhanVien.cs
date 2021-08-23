using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class HoSoNhanVien
    {
        public int MaHSNV { get; set; }
        public String HoTen { get; set; }
        public String? DiaChi { get; set; }
        public String? QueQuan { get; set; }
        public DateTime? NgaySinh { get; set; }
        public String? Email { get; set; }
        public String? sdt { get; set; }
        public String? TruongHoc { get; set; }
        public int? IsHide { get; set; }

        public NhanVien NhanVien { get; set; }
        public List<BangCap> BangCaps { get; set; }
        //TODO : xyz
    }
}
