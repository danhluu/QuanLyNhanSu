using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Common
{
    public class NhanVienHienThi
    {
        public int MaNV { get; set; }
        public String TenNV { get; set; }
        public int MaPB { get; set; }
        public String PhongBan { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public int Status { get; set; }
        public int? IsHide { get; set; }
    }
}
