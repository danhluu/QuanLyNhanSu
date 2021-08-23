using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common.EF
{
    public class QuanLyNhanVienDbContextFactory : IDesignTimeDbContextFactory<QLNVDbContext>
    {
        public QLNVDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QuanLyNhanVienDb");
            var optionBuilder = new DbContextOptionsBuilder<QLNVDbContext>();
            optionBuilder.UseSqlServer(connectionString);

            return new QLNVDbContext(optionBuilder.Options);
        }
    }
}
