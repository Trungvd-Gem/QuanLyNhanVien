using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRoles");

            builder.Property(p => p.Description).HasMaxLength(250).IsRequired();
        }
    }
}
