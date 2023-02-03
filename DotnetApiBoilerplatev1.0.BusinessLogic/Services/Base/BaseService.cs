using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;

namespace DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base
{
    public class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IUnitOfWorkDapper _unitOfWorkDapper;
        protected readonly ILoggingService _logger;

        public BaseService(IUnitOfWork unitOfWork, IUnitOfWorkDapper unitOfWorkDapper, ILoggingService logger)
        {
            _unitOfWork = unitOfWork;
            _unitOfWorkDapper = unitOfWorkDapper;
            _logger = logger;
        }
    }
}
