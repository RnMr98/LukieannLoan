using LukieannLoanWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                },

                new IdentityRole
                {
                    Id = "dr226c42 - 8723 - 4a74 - 763a - 97dff65342b4",
                    Name = Roles.LoanManager,
                    NormalizedName = Roles.LoanManager.ToUpper()
                }


                );
        }
    }
}