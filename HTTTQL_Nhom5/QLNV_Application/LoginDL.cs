using Common.Data.EF;
using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using QLNV_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application
{
    public class LoginDL : BaseDL<Login>, ILoginDL
    {
        public LoginDL(QLNVDbContext dl) : base(dl)
        {
        }

        public async Task<Login> CheckLogin(Login login)
        {
            var quanly = await _dl.QuanLies.Where(x => x.username.Equals(login.username) 
                                                && x.password.Equals(login.password)).FirstOrDefaultAsync();
            if (quanly != null)
            {
                login.Session = "QuanLy";
                login.Ten = quanly.HoTen;
                return login;
            }

            var nv = await _dl.NhanViens.Where(x => x.username.Equals(login.username)
                                                && x.password.Equals(login.password)).FirstOrDefaultAsync();
            if (nv != null)
            {
                login.Session = "NhanVien";
                return login;
            }
            else
            {
                login.Session = null;
            }
            return null;
        }
    }
}
