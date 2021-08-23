using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class DonXin
    {
        public int MaDon { get; set; }
        public String? LoaiDon { get; set; }//xin nghi-xin di muon,...
        public DateTime? NgayViet { get; set; }
        public String? LyDo { get; set; }
        public int Status { get; set; }
        public int? IsHide { get; set; }

        public int? MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
