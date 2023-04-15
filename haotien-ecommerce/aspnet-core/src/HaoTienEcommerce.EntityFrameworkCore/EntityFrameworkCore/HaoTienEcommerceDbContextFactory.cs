using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HaoTienEcommerce.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HaoTienEcommerceDbContextFactory : IDesignTimeDbContextFactory<HaoTienEcommerceDbContext>
{
    public HaoTienEcommerceDbContext CreateDbContext(string[] args)
    {
        HaoTienEcommerceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HaoTienEcommerceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new HaoTienEcommerceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HaoTienEcommerce.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
