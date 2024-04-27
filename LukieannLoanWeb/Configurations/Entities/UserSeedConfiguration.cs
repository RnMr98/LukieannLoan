using LukieannLoanWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.HasData
                (
                new User
                {
                    Id = "be210b42-8689-4b84-833a-97dff99352c5",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword@1"),
                    EmailConfirmed = true
                },
                new User
                {
                    Id = "cf310b42-6529-8b84-831a-97dff74352c5",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    UserName = "user@test.com",
                    NormalizedUserName = "USER@TEST.COM",
                    FirstName = "Simple",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword@1"),
                    EmailConfirmed = true
                },

                  new User
                  {
                      Id = "cc511b42-6729-8b84-831a-97dff74352c4",
                      Email = "loanManager@test.com",
                      NormalizedEmail = "LOANMANAGER@TEST.COM",
                      UserName = "loanManager@test.com",
                      NormalizedUserName = "LOANMANAGER@TEST.COM",
                      FirstName = "Loan",
                      LastName = "Manager",
                      PasswordHash = hasher.HashPassword(null, "P@ssword@2"),
                      EmailConfirmed = true
                  }
                );
        }
    }
}