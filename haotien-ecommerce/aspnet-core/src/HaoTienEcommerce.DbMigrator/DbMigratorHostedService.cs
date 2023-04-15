using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HaoTienEcommerce.Data;
using Serilog;
using Volo.Abp;
using HaoTienEcommerce.Seeding;

namespace HaoTienEcommerce.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IConfiguration _configuration;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime, IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = await AbpApplicationFactory.CreateAsync<HaoTienEcommerceDbMigratorModule>(options =>
        {
           options.Services.ReplaceConfiguration(_configuration);
           options.UseAutofac();
           options.Services.AddLogging(c => c.AddSerilog());
        }))
        {
            await application.InitializeAsync();

            // Migrate have been already
            await application
              .ServiceProvider
              .GetRequiredService<IdentityDataSeeder>()
              .SeedAsync("admin@abphaotien.com.vn", "Abc@123$");

            // Override
            await application
                            .ServiceProvider
                            .GetRequiredService<HaoTienEcommerceDbMigrationService>()
                            .MigrateAsync();

            await application.ShutdownAsync();

            _hostApplicationLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
