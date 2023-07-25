using FinancialControl.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancialControl.Core.Interfaces
{ 
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        public DbSet<TEntity> Table { get; }
        Task<IQueryable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(Guid id);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);  
    }
}
