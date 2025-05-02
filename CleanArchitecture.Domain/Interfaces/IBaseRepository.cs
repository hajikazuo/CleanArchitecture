using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
