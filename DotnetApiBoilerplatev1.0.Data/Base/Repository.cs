using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotnetApiBoilerplatev1._0.Data.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(TEntity entity)
        {
            await this._dbContext.Set<TEntity>().AddAsync(entity);
        }
    }
}
