using Persistence.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    class Repository<T> : IRepository<T> where T : class
    {

    }
}
