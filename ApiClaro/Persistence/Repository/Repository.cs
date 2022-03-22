using Persistence.IRepository;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly GenericServices<T> _context;

        public Repository()
        {
            _context = new GenericServices<T>();
        }

        public async Task<bool> Add(T entity)
        {
            //Use the context to add an entity to database 
           return await _context.AddAsync(entity);
        }

        public async Task<bool> Delete(int Id)
        {
            return await _context.DeleteAsync(Id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.GetListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await _context.GetByIdAsync(Id);
        }

        public async Task<bool> Update(int Id, T entity)
        {
            return await _context.UpdateAsync(Id, entity);
        }
    }
}
