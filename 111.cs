namespace Domain.Data.Common
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> FindAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetActivAsync();
    }
}
