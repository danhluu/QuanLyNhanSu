using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IChiTietKhoaDaoTaoDL : IBaseDL<ChiTietKhoaDaoTao>
    {
        Task<IEnumerable<ChiTietKhoaDaoTao> > GetDanhSachLop(int MaLop);
        Task<int> SetIsHide(int Ma);
    }
}
