using DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base;
using DotnetApiBoilerplatev1._0.Model.DTO.In;
using DotnetApiBoilerplatev1._0.Model.DTO.Out;
using Microsoft.AspNetCore.Mvc;

namespace DotnetApiBoilerplatev1._0.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAccountsService _accountsService;
        private readonly ILoggingService _loggingService;
        public AuthenticationController(
            IAccountsService accountsService,
            ILoggingService loggingService)
        {
            _accountsService = accountsService;
            _loggingService = loggingService;
        }

        [HttpPost]
        public async Task<LoginResponseDTO> LoginByBasicCredential([FromQuery] LoginRequestByBasicCredentialDTO loginRequestByBasicCredential)
        {
            var response = new LoginResponseDTO();
            try
            {
                response = await _accountsService.GetAccountByBasicCredential(loginRequestByBasicCredential);
            }
            catch (Exception ex)
            {
                _loggingService.LogExceptionError(ex.Message);
            }
            return response;
        }
    }
}
