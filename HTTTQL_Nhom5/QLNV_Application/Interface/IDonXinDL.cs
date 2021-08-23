using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IDonXinDL : IBaseDL<DonXin>
    {
        Task<int> SetIsHide(int Ma);

        Task<int> CountDonXin();

        Task<int> ChangeStatus(int MaDon);
    }
}
