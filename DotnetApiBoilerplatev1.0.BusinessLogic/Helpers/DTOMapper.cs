using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.Entities;

namespace DotnetApiBoilerplatev1._0.BusinessLogic.Helpers
{
    public static class DTOMapper
    {
        public static Accounts ToEntity(this LoginRequestByBasicCredentialDTO loginRequestByBasicCredential, Accounts account)
        {
            account.CreatedDate = DateTime.Now;
            account.ModifiedDate = DateTime.Now;
            account.IsActive = true;
            account.Email = loginRequestByBasicCredential.Email;
            account.Password = loginRequestByBasicCredential.Password;
            return account;
        }
    }
}
