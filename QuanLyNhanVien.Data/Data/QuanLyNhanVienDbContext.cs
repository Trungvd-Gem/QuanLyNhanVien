using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Core.Configurations;
using QuanLyNhanVien.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhanVien.Core.Data
{
    public class QuanLyNhanVienDbContext: IdentityDbContext
    {
        public QuanLyNhanVienDbContext( DbContextOptions options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            // data seeding
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentID = 1, DepartmentName = "Kinh Doanh", Description = "Tăng lợi nhuận" },
                new Department() { DepartmentID = 2, DepartmentName = "IT", Description = "Phát triển phần mềm" },
                new Department() { DepartmentID = 3, DepartmentName = "Nhân sự", Description = "Tìm kiếm tài năng" }


                ); 

            modelBuilder.Entity<Employee>().HasData(
                new Employee() {   
                    EmployeeID = 1,
                    DepartmentID = 1,
                    FullName = "Vu Duc Trung",
                    Adrress = "Bac Ninh",
                    Birthday =new DateTime(1993, 02, 14),
                    Email = "trung@gmail.com" },

                 new Employee()
                 {
                     EmployeeID = 2,
                     DepartmentID = 2,
                     FullName = "Nguyen Van Hung",
                     Adrress = "Thanh Hoa",
                     Birthday = new DateTime(1997, 02, 20),
                     Email = "hung@gmail.com"
                 },
                  new Employee()
                  {
                      EmployeeID = 3,
                      DepartmentID = 3,
                      FullName = "Hoang Van Nam",
                      Adrress = "Nam Dinh",
                      Birthday = new DateTime(1999, 08, 06),
                      Email = "nam@gmail.com"
                  }


                );

                    base.OnModelCreating(modelBuilder);
        }

    }
}
