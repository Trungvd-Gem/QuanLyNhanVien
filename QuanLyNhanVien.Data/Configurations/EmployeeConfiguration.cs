using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace QuanLyNhanVien.Core.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.ToTable("Employees");
            builder.HasKey(x => x.EmployeeID);
            builder.Property(x => x.EmployeeID).UseIdentityColumn();

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Adrress).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);

            builder.Property(x => x.Birthday).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentID);
        }
    }
}
