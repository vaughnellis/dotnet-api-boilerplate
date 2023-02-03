using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.DTO.Out;

namespace DotnetApiBoilerplatev1._0.Data.Base.Interfaces
{
    public interface IAccountsQueries
    {
        Task<LoginResponseDTO> LoginByBasicCredential(LoginRequestByBasicCredentialDTO loginRequestByBasicCredentialDTO);
    }
}
