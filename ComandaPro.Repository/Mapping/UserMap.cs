using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComandaPro.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(150);
            builder.Property(prop => prop.Telephone).IsRequired().HasMaxLength(15);
            builder.Property(prop => prop.Address).IsRequired().HasMaxLength(255);
            builder.Property(prop => prop.Document).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.Password).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.Email).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.IsRestaurant).IsRequired();
        }
    }
}
