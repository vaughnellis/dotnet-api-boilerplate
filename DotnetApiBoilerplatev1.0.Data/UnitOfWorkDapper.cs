using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Data.Queries;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DotnetApiBoilerplatev1._0.Data
{
    public class UnitOfWorkDapper : IUnitOfWorkDapper
    {
        private IDbConnection _dbConnection;
        private bool _disposed;

        private IAccountsQueries _accountQueries;

        public UnitOfWorkDapper(string dbConnectionString)
        {
            _dbConnection = new SqlConnection(dbConnectionString);
        }

        public IAccountsQueries AccountQueries { get { return _accountQueries ?? new AccountQueries(_dbConnection); } }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing && _dbConnection != null)
                {
                    _dbConnection.Dispose();
                }
            }
            _disposed = true;
        }
        ~UnitOfWorkDapper() { dispose(false); }
    }
}
