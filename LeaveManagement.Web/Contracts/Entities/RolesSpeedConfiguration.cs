using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Contracts.Entities
{
    public class RolesSpeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                new IdentityRole
                {
                    Id = "2",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()

                }
            );
        }
    }
}