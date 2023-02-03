namespace DotnetApiBoilerplatev1._0.Data.Base.Interfaces
{
    public interface IUnitOfWork
    {
        Task Complete();
        void Dispose();
    }
}
