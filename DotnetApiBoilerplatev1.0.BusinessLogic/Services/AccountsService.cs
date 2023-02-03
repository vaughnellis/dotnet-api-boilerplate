using DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base;
using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.DTO.Out;

namespace DotnetApiBoilerplatev1._0.BusinessLogic.Services
{
    public class AccountsService : BaseService, IAccountsService
    {
        public AccountsService(IUnitOfWork unitOfWork, IUnitOfWorkDapper unitOfWorkDapper, ILoggingService logger)
            : base(unitOfWork, unitOfWorkDapper, logger)
        { }

        public async Task<LoginResponseDTO> GetAccountByBasicCredential(LoginRequestByBasicCredentialDTO loginRequestByBasicCredential)
        {
            try
            {
                return await _unitOfWorkDapper.AccountQueries.LoginByBasicCredential(loginRequestByBasicCredential);
            }
            catch (Exception ex)
            {
                _logger.LogExceptionError(ex.ToString());
                throw;
            }
        }
    }
}
