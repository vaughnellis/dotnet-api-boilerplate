using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.DTO.Out;

namespace DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base
{
    public interface IAccountsService
    {
        Task<LoginResponseDTO> GetAccountByBasicCredential(LoginRequestByBasicCredentialDTO loginRequestByBasicCredential);
    }
}
