using DotnetApiBoilerplatev1._0.BusinessLogic.Services;
using DotnetApiBoilerplatev1._0.BusinessLogic.Services.Base;
using DotnetApiBoilerplatev1._0.Data;
using DotnetApiBoilerplatev1._0.Data.Base.Interfaces;
using DotnetApiBoilerplatev1._0.Data.Context;

namespace DotnetApiBoilerplatev1._0
{
    public static class IoC
    {
        private static ServiceProvider serviceProvider;

        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();
            services.AddControllers();

            var dbConnectionString = configuration.GetConnectionString("DevConnection");
            services.AddTransient<DataContext>();
            services.AddScoped<IUnitOfWork>(x => new UnitOfWork(dbConnectionString));
            services.AddScoped<IUnitOfWorkDapper>(x => new UnitOfWorkDapper(dbConnectionString));
            services.AddScoped<ILoggingService, LoggingService>();
            services.AddScoped<IAccountsService, AccountsService>();
            
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}
