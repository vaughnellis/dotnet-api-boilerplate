using DotnetApiBoilerplatev1._0.Model.Entities;

namespace DotnetApiBoilerplatev1._0.Data.Base.Interfaces
{
    public interface IAccountsRepository
    {
        Task InsertAccountAsync(Accounts account);
        Task SaveChangesAsync();
    }
}
