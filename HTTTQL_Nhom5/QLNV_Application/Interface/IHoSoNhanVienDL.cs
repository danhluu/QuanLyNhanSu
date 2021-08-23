using Common.Data.Common;
using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IHoSoNhanVienDL : IBaseDL<HoSoNhanVien>
    {
        Task<IEnumerable<HoSoNhanVien>> getMaHSSV();
        Task<int> SetIsHide(int Ma);
        Task<HienThiHSNV> HienThiHSNV(String username);
    }
}
