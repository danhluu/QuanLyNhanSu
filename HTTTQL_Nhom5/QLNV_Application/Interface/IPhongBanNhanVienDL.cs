using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IPhongBanNhanVienDL : IBaseDL<PhongBanNhanVienDL>
    {
        Task<int> AddPhongBanNhanVien(PhongBanNhanVien pbnv);
        Task<IEnumerable<PhongBanNhanVien>> getDatas();
    }
}
