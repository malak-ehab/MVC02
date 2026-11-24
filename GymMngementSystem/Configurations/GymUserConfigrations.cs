using GymMngementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymMangmentSystem.Configurations
{
    public class GymUserConfigurations<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(U => U.Name).HasColumnType("varchar(50)");

            builder.Property(U => U.Email).HasColumnType("varchar(100)");


            builder.Property(U => U.PhoneNumber).HasColumnType("varchar(11)");

            builder.ComplexProperty(U => U.Address).IsRequired();

            builder.HasIndex(U => U.Email).IsUnique();
            builder.HasIndex(U => U.PhoneNumber).IsUnique();


            builder.ToTable(X => {
                X.HasCheckConstraint("CK_EmailConstraint", "Email LIKE '%_@_%._%'");
                X.HasCheckConstraint("CK_phoneConstraint", "Len(PhoneNumber) =11 AND PhoneNumber LIKE '010%' or PhoneNumber LIKE '011%' or PhoneNumber LIKE '012%'or PhoneNumber LIKE '015%'");
            });


        }
    }
}