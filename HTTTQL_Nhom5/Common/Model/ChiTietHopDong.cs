using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class ChiTietHopDong
    {
        public int MaCTHD { get; set; }
        public String LoaiHopDong { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public int MaHopDong { get; set; }
        public HopDong HopDong { get; set; }

        public int MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        public int MaQL { get; set; }
        public QuanLy QuanLy { get; set; }


    }
}
