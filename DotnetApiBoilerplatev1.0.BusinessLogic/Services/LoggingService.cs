using DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base;
using NLog;

namespace DotnetApiBoilerplatev1._0.BusinessLogic.Services
{
    public class LoggingService : ILoggingService
    {
        public void AddEntityToLog(long? entityId = null, string entityName = null, string additionalInfo = null)
        {
            throw new NotImplementedException();
        }

        public void LogExceptionError(string message)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Info($"Info - {message}");
        }
    }
}
