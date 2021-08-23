using Common.Data.Common;
using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IKhoaDaoTaoDL : IBaseDL<KhoaDaoTao>
    {
        Task<int> SetIsHide(int Ma);

        Task<IEnumerable<KhoaDaoTaoHienThi>> HienThiKDT();
    }
}
