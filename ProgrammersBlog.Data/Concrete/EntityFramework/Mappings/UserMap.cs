﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;

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
        }
    }
}
