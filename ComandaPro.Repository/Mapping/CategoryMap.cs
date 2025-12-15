using ComandaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComandaPro.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name);
            builder.HasOne(prop => prop.User)
                .WithMany()
                .HasForeignKey(prop => prop.UserId);
        }
    }
    
}
