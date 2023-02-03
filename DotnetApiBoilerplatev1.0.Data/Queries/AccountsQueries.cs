using Dapper;
using DotnetApiBoilerplatev1._0.Data.Base;
using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.DTO.Out;
using System.Data;

namespace DotnetApiBoilerplatev1._0.Data.Queries
{
    public class AccountQueries : BaseDapperRepository, IAccountsQueries
    {
        public AccountQueries(IDbConnection db)
            : base(db)
        { }

        public async Task<LoginResponseDTO> LoginByBasicCredential(LoginRequestByBasicCredentialDTO loginRequestByBasicCredential)
        {
            #region Query
            var query = @$"
                SELECT A.Email, R.Name as Role, GA.IsActive
                FROM GroupAccounts GA
				INNER JOIN Accounts A
				ON A.AccountId = GA.AccountId
                INNER JOIN Roles R
                ON R.RoleId = GA.RoleId
                WHERE A.Email = @Email
                AND A.Password = @Password
                AND A.IsActive = @IsActive";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Email", loginRequestByBasicCredential.Email);
            parameters.Add("@Password", loginRequestByBasicCredential.Password);
            parameters.Add("@IsActive", loginRequestByBasicCredential.IsActive);

            return await _dbConnection.QuerySingleOrDefaultAsync<LoginResponseDTO>(sql: query, param: parameters, commandType: CommandType.Text);
            #endregion

            #region Stored Procedure
            //var parameters = new DynamicParameters();
            //arameters.Add("@Email", loginRequestByBasicCredential.Email);
            //parameters.Add("@Password", loginRequestByBasicCredential.Password);
            //parameters.Add("@IsActive", loginRequestByBasicCredential.IsActive);

            //return await _dbConnection.QuerySingleOrDefaultAsync<LoginResponseDTO>("sp_LoginByBasicCredential", parameters, commandType: CommandType.StoredProcedure);
            #endregion
        }
    }
}
