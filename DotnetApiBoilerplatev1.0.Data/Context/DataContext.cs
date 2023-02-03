using DotnetApiBoilerplatev1._0.Data.Extensions;
using DotnetApiBoilerplatev1._0.Model.Configuration;
using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DotnetApiBoilerplatev1._0.Data.Context
{
    public class DataContext : DbContext, IDesignTimeDbContextFactory<DataContext>
    {
        private string _dbConnectionString;

        public DataContext(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        public DataContext()
        { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<GroupAccounts> GroupAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountsConfiguration());
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.ApplyConfiguration(new GroupAccountsConfiguration());

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DataContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Secrets/secrets.json", optional: true, reloadOnChange: true)
                .Build();

            var dbConnectionString = configuration.GetConnectionString("DevConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(dbConnectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }
}
