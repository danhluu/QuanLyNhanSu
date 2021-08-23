using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface ICongTyDL : IBaseDL<CongTy>
    {
        Task<int> SetIsHide(int Ma);

    }
}
