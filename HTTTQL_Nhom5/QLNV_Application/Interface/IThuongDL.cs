using Common.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IThuongDL
    {
        Task<IEnumerable<Thuong>> GetAllData();

        Task<int> Create(Thuong thuong);

        Task<Thuong> GetByID(int id);

        Task Update(Thuong thuong);

        Task<int> Delete(int id);
        Task<int> SetIsHide(int Ma);
    }
}
