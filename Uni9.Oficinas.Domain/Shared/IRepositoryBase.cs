using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uni9.Oficinas.Domain.Shared
{
    public interface IRepositoryBase<T>
    {
        Task Add(T entity);
        Task Edit(Guid id, T entity);
        Task Delete(Guid id);
        Task<T> Get(Guid id);
        Task<ICollection<T>> GetAll();
        Task<ICollection<T>> GetAll(Guid id);
    }
}
