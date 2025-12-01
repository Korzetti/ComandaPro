using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComandaPro.Repository.Mapping
{
    public class PaymentMap : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payments");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.PaymentMethod).IsRequired().HasMaxLength(50);
            builder.Property(prop => prop.ValuePaid).IsRequired();
            builder.Property(prop => prop.PaymentDate).IsRequired();
            builder.HasOne(prop => prop.Order);
        }
    }
    
}
