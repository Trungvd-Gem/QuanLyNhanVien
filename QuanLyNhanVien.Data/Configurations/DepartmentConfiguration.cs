using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(x => x.DepartmentID);
            builder.Property(x => x.DepartmentID).UseIdentityColumn();

            builder.Property(x => x.DepartmentName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(250);

        }
    }
}
