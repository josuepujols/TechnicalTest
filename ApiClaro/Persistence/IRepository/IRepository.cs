using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.IRepository
{
    //This is a generic repository to interactuate with each entity
    interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid Id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(Guid Id);
        Task<bool> CommitChanges();
    }
}
