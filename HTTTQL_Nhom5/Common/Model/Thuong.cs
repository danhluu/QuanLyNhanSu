using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class Thuong
    {
        public int MaThuong { get; set; }
        public String LoaiThuong { get; set; }
        public int MucThuong { get; set; }

        public List<Luong> Luongs { get; set; }
    }
}
