using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IBacLuongDL : IBaseDL<BacLuong>
    {
        Task<int> SetIsHide(int Ma);
    }
}
