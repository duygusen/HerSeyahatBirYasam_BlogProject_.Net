using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entity.Entities;

namespace Project.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Barcelona Seyahat Rehberi",
                Content = "Barcelona güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Zaandam Seyahat Rehberi",
                Content = "Zaandam güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Amsterdam Seyahat Rehberi",
                Content = "Amsterdam güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Portofino Seyahat Rehberi",
                Content = "Portofino güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Viyana Seyahat Rehberi",
                Content = "Viyana güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Paris Seyahat Rehberi",
                Content = "Paris güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Amalfi Seyahat Rehberi",
                Content = "Amalfi güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Roma Seyahat Rehberi",
                Content = "Roma güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Selanik Seyahat Rehberi",
                Content = "Selanik güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Prag Seyahat Rehberi",
                Content = "Prag güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Budapeşte Seyahat Rehberi",
                Content = "Budapeşte güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Napoli Seyahat Rehberi",
                Content = "Napoli güzel şehir",
                ViewCount = 15,
                CategoryId = Guid.Parse("D23E4F79-9600-4B5E-B3E9-756CDCACD2B1"),
                ImageId = Guid.Parse("D16A6EC7-8C50-4AB0-89A5-02B9A551F0FA"),
                CreatedBy = "superadmin",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427")
            });
        }
    }
}
