using DotnetApiBoilerplatev1._0.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetApiBoilerplatev1._0.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Pre-populate Role Table
            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    Id = 1,
                    Name = "Role1",
                    Description = "DescriptionHere",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new Roles
                {
                    Id = 2,
                    Name = "Role2",
                    Description = "DescriptionHere2",
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            );
            #endregion

            #region Pre-populate Accounts Table
            modelBuilder.Entity<Accounts>().HasData(
               new Accounts
               {
                   Id = 1,
                   Name = "Name",
                   Email = "Email",
                   Password = "HashedPassword",
                   IsActive = true,
                   CreatedDate = DateTime.Now
               },
               new Accounts
               {
                   Id = 2,
                   Name = "Name2",
                   Email = "Email2",
                   Password = "HashedPassword2",
                   IsActive = true,
                   CreatedDate = DateTime.Now
               }
           );
            #endregion

            #region Pre-populate GroupAccounts Table
            modelBuilder.Entity<GroupAccounts>().HasData(
               new GroupAccounts
               {
                   Id = 1,
                   AccountId = 1,
                   RoleId= 1,
                   IsActive = true,
                   CreatedDate = DateTime.Now
               },
               new GroupAccounts
               {
                   Id = 2,
                   AccountId= 1,
                   RoleId= 2,
                   IsActive = true,
                   CreatedDate = DateTime.Now
               },
               new GroupAccounts
               {
                   Id = 2,
                   AccountId = 2,
                   RoleId = 2,
                   IsActive = true,
                   CreatedDate = DateTime.Now
               }
           );
            #endregion
        }
    }
}
