using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public class BacLuong
    {
        public int MaBacLuong { get; set; }
        public String LoaiLuong { get; set; }
        public int MucLuong { get; set; }
         
        public List<Luong> Luongs { get; set; }
    }
}
