using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.IServices
{
    public interface IServices<T> where T : class
    {
        Task<IEnumerable<T>> GetListAsync();
        Task<T> GetByIdAsync(int Id);
        Task<bool> AddAsync(T Entity);
        Task<bool> UpdateAsync(int Id, T Entity);
        Task<bool> DeleteAsync(int Id);
    }
}
