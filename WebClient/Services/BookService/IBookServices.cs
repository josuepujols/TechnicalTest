using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BookService
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetById(int Id);
        Task<bool> Add(Book entity);
        Task<bool> Update(int Id, Book entity);
        Task<bool> Delete(int Id);
    }
}
