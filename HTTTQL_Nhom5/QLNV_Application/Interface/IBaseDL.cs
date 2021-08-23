using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_Application.Interface
{
    public interface IBaseDL<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAllData();

        Task<T> GetById(int id);

        Task<int> Create(T entity);

        Task Update(T entity);

        Task<int> Delete(int id);
    }
}
