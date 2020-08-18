using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyNhanVien.Core.Data
{
    public class QuanLyNhanVienDbContextFactory : IDesignTimeDbContextFactory<QuanLyNhanVienDbContext>
    {
        public QuanLyNhanVienDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

            var connectionString = configuration.GetConnectionString("QLNVSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<QuanLyNhanVienDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new QuanLyNhanVienDbContext(optionsBuilder.Options);


           
        }
    }
}
