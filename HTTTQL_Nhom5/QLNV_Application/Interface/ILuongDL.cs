using Common.Data.Common;
using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface ILuongDL : IBaseDL<Luong>
    {
        Task<int> SetIsHide(int Ma);

        Task<int> AddLuong(Luong luong);

        Task<IEnumerable<LuongHienThi>> HienThiLuong();

        Task<int> UpdateLuong(Luong luong);
    }
}
