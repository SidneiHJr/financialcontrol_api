namespace FinancialControl.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
        Task<bool> CommitAsync();
        bool CommitTransaction();
        Task<bool> CommitTransactionAsync();
        void RollBack();
        Task RollBackAsync();
        bool TransactionOpened();
    }
}
