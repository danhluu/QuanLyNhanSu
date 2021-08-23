using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Model
{
    public class Login
    {
        public String  username { get; set; }

        public String password { get; set; }

        public String? Session { get; set; }

        public int Status { get; set; }
        public String Ten { get; set; }
    }
}
