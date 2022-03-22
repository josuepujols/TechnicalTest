using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class UnitOfWork : IDisposable
    {
        private Dictionary<string, object> repositories;

        public Repository<T> Repository<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                object repositoryInstance = null;

                repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)));
                repositories.Add(type, repositoryInstance);

            }

            return (Repository<T>)repositories[type];
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
