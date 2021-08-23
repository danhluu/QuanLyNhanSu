using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class BangCap
    {
        public int MaBangCap { get; set; }
        public String TenChuyenMon { get; set; }
        public String NoiDaoTao { get; set; }
        public String HeDaoTao { get; set; }
        
        public int MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
