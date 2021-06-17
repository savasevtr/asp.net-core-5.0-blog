using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).HasMaxLength(1000).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.ToTable("Comments");
            //builder.HasData(
            //    new Comment
            //    {
            //        Id = 1,
            //        ArticleId = 1,
            //        Text = "Nam nec venenatis diam. Proin dolor ipsum, posuere eget molestie at, rhoncus a massa. Cras nunc orci, vestibulum vitae rutrum in, dignissim at dolor. Vestibulum suscipit erat vel facilisis aliquet. Ut commodo vitae felis nec pretium. Duis a urna sed nulla euismod euismod. Pellentesque egestas sapien lorem, et semper quam sagittis nec.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "C# makale yorumu"
            //    },
            //    new Comment
            //    {
            //        Id = 2,
            //        ArticleId = 2,
            //        Text = "Nam nec venenatis diam. Proin dolor ipsum, posuere eget molestie at, rhoncus a massa. Cras nunc orci, vestibulum vitae rutrum in, dignissim at dolor. Vestibulum suscipit erat vel facilisis aliquet. Ut commodo vitae felis nec pretium. Duis a urna sed nulla euismod euismod. Pellentesque egestas sapien lorem, et semper quam sagittis nec.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "C++ makale yorumu"
            //    },
            //    new Comment
            //    {
            //        Id = 3,
            //        ArticleId = 3,
            //        Text = "Nam nec venenatis diam. Proin dolor ipsum, posuere eget molestie at, rhoncus a massa. Cras nunc orci, vestibulum vitae rutrum in, dignissim at dolor. Vestibulum suscipit erat vel facilisis aliquet. Ut commodo vitae felis nec pretium. Duis a urna sed nulla euismod euismod. Pellentesque egestas sapien lorem, et semper quam sagittis nec.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        ModifiedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedDate = DateTime.Now,
            //        Note = "JavaScript makale yorumu"
            //    }
            //);
        }
    }
}
