using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LukieannLoanWeb.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "bf210b42 - 6889 - 4b74 - 833a - 97dff66352c5",
                    UserId = "be210b42-8689-4b84-833a-97dff99352c5"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "dr210b42 - 8523 - 4b74 - 783a - 97dff66342c5",
                    UserId = "cf310b42-6529-8b84-831a-97dff74352c5"
                }
                );
        }
    }
}