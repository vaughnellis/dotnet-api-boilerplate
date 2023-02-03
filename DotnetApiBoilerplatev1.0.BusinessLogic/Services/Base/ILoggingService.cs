namespace DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base
{
    public interface ILoggingService
    {
        void AddEntityToLog(long? entityId = null, string entityName = null, string additionalInfo = null);
        void LogExceptionError(string message);
    }
}
