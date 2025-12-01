using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComandaPro.Repository.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Status).IsRequired().HasMaxLength(50);
            builder.Property(prop => prop.Date_Time).IsRequired();
            builder.Property(prop => prop.TotalValue).IsRequired();
            builder.HasOne(prop => prop.User);
        }
    }
}
