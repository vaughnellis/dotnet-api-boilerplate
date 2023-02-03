namespace DotnetApiBoilerplatev1._0.Data.Base.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
    }
}
