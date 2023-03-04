using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SocialOffice.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SocialOfficeDbContextFactory : IDesignTimeDbContextFactory<SocialOfficeDbContext>
{
    public SocialOfficeDbContext CreateDbContext(string[] args)
    {
        SocialOfficeEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SocialOfficeDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SocialOfficeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SocialOffice.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
