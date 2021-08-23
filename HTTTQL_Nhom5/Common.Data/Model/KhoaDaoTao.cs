using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class KhoaDaoTao
    {
        public int MaKhoaDaoTao { get; set; }
        public String? TenKhoa { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        public List<ChiTietKhoaDaoTao> ChiTietKhoaDaoTaos { get; set; }
    }
}
