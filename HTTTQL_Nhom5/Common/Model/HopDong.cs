using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class HopDong
    {
        public int MaHopDong { get; set; }
        public String NoiDung { get; set; }
        public String GhiChu { get; set; }

        public ChiTietHopDong ChiTietHopDong { get; set; }
    }
}
