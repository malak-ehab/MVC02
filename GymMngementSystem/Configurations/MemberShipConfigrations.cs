using GymMngementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMngementSystem.Configurations
{
    public class MembershipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(M => M.CreatedAt).HasDefaultValueSql("GetDate()");
        }
    }
}
