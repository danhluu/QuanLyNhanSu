using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class QuanLy
    {
        public int MaQL { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String Email { get; set; }
        public String HoTen { get; set; }
        public String DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public String GhiChu { get; set; }
        public double NamKinhNghiem { get; set; }

        public int MaCongTy { get; set; }
        public CongTy CongTy { get; set; }

        public List<QuyetDinhBoNhiem> QuyetDinhBoNhiems { get; set; }

        public List<ChiTietHopDong> ChiTietHopDongs { get; set; }

    }
}
