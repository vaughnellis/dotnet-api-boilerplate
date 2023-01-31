using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace DotnetApiBoilerplatev1._0.Model.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("RolesId")
                .HasColumnType(SqlDbType.Int.ToString())
                .ValueGeneratedOnAdd();
        }
    }
}
