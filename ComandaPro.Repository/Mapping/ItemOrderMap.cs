using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComandaPro.Repository.Mapping
{
    public class ItemOrderMap : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> builder)
        {
            builder.ToTable("ItemOrders");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Quantity).IsRequired();
            builder.Property(prop => prop.UnitPrice).IsRequired();
            builder.Property(prop => prop.Observations).HasMaxLength(100);
            builder.Property(prop => prop.OrderId).IsRequired();
            builder.Property(prop => prop.ProductId).IsRequired();
            builder.HasOne(prop => prop.Order)
                .WithMany()
                .HasForeignKey(prop => prop.OrderId);
            builder.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey(prop => prop.ProductId);
        }
    }
}
