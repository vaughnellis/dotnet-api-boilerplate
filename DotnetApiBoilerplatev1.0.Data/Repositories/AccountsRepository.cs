using DotnetApiBoilerplatev1._0.Data.Base;
using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Data.Context;
using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetApiBoilerplatev1._0.Data.Repositories
{
    public class AccountsRepository : Repository<Accounts>, IAccountsRepository
    {
        private DataContext _dataContext
        {
            get
            {
                return _dataContext as DataContext;
            }
        }

        public AccountsRepository(DbContext context)
            : base(context)
        { }

        public async Task InsertAccountAsync(Accounts account)
        {
            await _dataContext.Accounts.AddAsync(account);
        }

        public async Task SaveChangesAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
