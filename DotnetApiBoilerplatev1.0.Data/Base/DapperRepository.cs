using System.Data;

namespace DotnetApiBoilerplatev1._0.Data.Base
{
    public class BaseDapperRepository
    {
        protected IDbConnection _dbConnection { get; set; }

        public BaseDapperRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
