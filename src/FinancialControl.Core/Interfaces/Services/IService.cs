using FinancialControl.Core.Entities;

namespace FinancialControl.Core.Interfaces
{
    public interface IService<TEntity> where TEntity : EntityBase
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(Guid id);
        Task<Guid> InsertAsync(TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
