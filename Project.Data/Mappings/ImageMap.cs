using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entity.Entities;

namespace Project.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                FileName = "/assets/img/blog/amsterdam",
                FileType = "jpeg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                FileName = "/assets/img/blog/paris",
                FileType = "jpeg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
