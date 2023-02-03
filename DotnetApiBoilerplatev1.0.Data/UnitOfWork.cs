using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Data.Context;

namespace DotnetApiBoilerplatev1._0.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext _dataContext;
        private bool _disposed;

        public UnitOfWork(string dbConnectionString)
        {
            _dataContext = new DataContext(dbConnectionString);
        }

        public async Task Complete()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing && _dataContext != null)
                {
                    _dataContext.Dispose();
                }
            }
            _disposed = true;
        }
        ~UnitOfWork() { dispose(false); }
    }
}
