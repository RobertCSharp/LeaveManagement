using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Contracts.Entities
{
    public class UserRoleSpeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                //Admin User
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "34565286-6452-4a26-a069-120b31427c39"
                },
                //Simple User
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "3c7ee887-281b-4262-a10f-a1872c4e2f08"
                }

            );
        }
    }
}