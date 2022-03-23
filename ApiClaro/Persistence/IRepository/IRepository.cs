using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.IRepository
{
    //This is a generic repository to interactuate with each entity
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int Id);
        Task<bool> Add(T entity);
        Task<bool> Update(int Id, T entity);
        Task<bool> Delete(int Id);
    }
}
