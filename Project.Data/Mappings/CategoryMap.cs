using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entity.Entities;

namespace Project.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("4C569A9A-5F41-478F-9D17-69AC5B02AE0B"),
                Name = "Türkiye",
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                Name = "Dünya",
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            });

        }
    }
}
