using GymMngementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangmentSystem.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {

                X.HasCheckConstraint("ck_CapacityConstraint", "Capacity Between 1 And 25");
                X.HasCheckConstraint("ck_StartEndDateConstraint", "EndTime > StartTime"
);
            });

            builder.HasOne(S => S.trainer)
                .WithMany(T => T.sessions) 
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}