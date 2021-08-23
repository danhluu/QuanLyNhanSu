using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class CongTy
    {
        public int MaCongTy { get; set; }
        public String TenCongTy { get; set; }
        public String DiaChi { get; set; }
        public String sdt { get; set; }
        public String MoTa { get; set; }

        public List<NhanVien> NhanViens { get; set; }
        public List<QuanLy> QuanLies { get; set; }
        public List<PhongBan> PhongBans { get; set; }
    }
}
