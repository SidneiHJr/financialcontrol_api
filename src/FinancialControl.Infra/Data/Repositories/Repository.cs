using FinancialControl.Core.Entities;
using FinancialControl.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinancialControl.Infra.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        public DbSet<TEntity> Table => throw new NotImplementedException();

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<TEntity>> GetAsync()
        {
            return await Task.FromResult(Table);
        }

        public Task<TEntity> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
