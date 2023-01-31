using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DotnetApiBoilerplatev1._0.Model.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(EntityTypeBuilder<Accounts> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("AccountId")
                .HasColumnType(SqlDbType.Int.ToString())
                .ValueGeneratedOnAdd();
        }
    }
}
