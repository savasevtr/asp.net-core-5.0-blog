using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Text;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Username).HasMaxLength(20).IsRequired();
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u => u.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250).IsRequired(false);
            builder.Property(u => u.CreatedByName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(50).IsRequired();
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Note).HasMaxLength(500);
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Savaş",
                LastName = "Ev",
                Username = "savasev",
                Email = "savas.ev@yahoo.com",
                Description = "ilk admin kullanıcısı",
                Picture = "https://i2.cnnturk.com/i/cnnturk/75/630x0/57ea19ad8685762060249c06.jpg",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                ModifiedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Note = "ilk admin kullanıcısı",
                PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500")
            });
        }
    }
}
