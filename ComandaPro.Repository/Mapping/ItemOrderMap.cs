using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

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
            builder.HasOne(prop => prop.Order);
            builder.HasOne(prop => prop.Product);
        }
    }
}
