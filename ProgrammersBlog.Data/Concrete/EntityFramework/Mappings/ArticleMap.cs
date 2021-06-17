using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100).IsRequired(true);
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)").IsRequired();
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70).IsRequired();
            builder.Property(a => a.ViewsCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");
            //builder.HasData(
            //    new Article
            //    {
            //        Id = 1,
            //        CategoryId = 1,
            //        Title = "C# 9.0 ve .NET 5.0 Yenilikleri",
            //        Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //        Thumbnail = "default.jpg",
            //        UserId = 1,
            //        ViewsCount = 100,
            //        CommentCount = 1,
            //        SeoAuthor = "savasev",
            //        SeoDescription = "C# 9.0 ve .NET 5.0 Yenilikleri",
            //        SeoTags = "C#, C# 9, .NET5, .NET Framework, .Net Core",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "C# 9.0 ve .NET 5.0 Yenilikleri"
            //    },
            //    new Article
            //    {
            //        Id = 2,
            //        CategoryId = 2,
            //        Title = "C++ 11 ve 19 Yenilikleri",
            //        Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //        Thumbnail = "default.jpg",
            //        UserId = 1,
            //        ViewsCount = 150,
            //        CommentCount = 1,
            //        SeoAuthor = "savasev",
            //        SeoDescription = "C++ 11 ve 19 Yenilikleri",
            //        SeoTags = "C++, C++ 11, C++ 19",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "C++ 11 ve 19 Yenilikleri"
            //    },
            //    new Article
            //    {
            //        Id = 3,
            //        CategoryId = 3,
            //        Title = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
            //        Thumbnail = "default.jpg",
            //        UserId = 1,
            //        ViewsCount = 200,
            //        CommentCount = 1,
            //        SeoAuthor = "savasev",
            //        SeoDescription = "JavaScript ES2019 ve ES2020 Yenilikleri",
            //        SeoTags = "JavaScript, JavaScript ES2019, JavaScript ES2020",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "JavaScript ES2019 ve ES2020 Yenilikleri"
            //    }
            //);
        }
    }
}
