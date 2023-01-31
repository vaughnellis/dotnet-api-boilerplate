using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DotnetApiBoilerplatev1._0.Model.Configuration
{
    public class GroupAccountsConfiguration : IEntityTypeConfiguration<GroupAccounts>
    {
        public void Configure(EntityTypeBuilder<GroupAccounts> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("GroupAccountsId")
                .HasColumnType(SqlDbType.Int.ToString())
                .ValueGeneratedOnAdd();

            builder.HasOne(x => x.Accounts)
                .WithMany()
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Roles)
               .WithMany()
               .HasForeignKey(x => x.RoleId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
