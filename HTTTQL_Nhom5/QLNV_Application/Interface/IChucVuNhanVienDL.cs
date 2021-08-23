using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IChucVuNhanVienDL : IBaseDL<ChucVuNhanVien>
    {
        Task<int> SetIsHide(int Ma);
    }
}
