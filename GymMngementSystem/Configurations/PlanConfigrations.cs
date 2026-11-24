using GymMngementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {

                X.HasCheckConstraint("ck_DurationDaysConstraints", "DurationDays Between 1 And 365");
            });
        }
    }
}