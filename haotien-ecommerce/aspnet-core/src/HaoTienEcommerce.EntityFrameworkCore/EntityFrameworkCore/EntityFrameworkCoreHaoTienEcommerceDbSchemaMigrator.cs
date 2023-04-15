using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HaoTienEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace HaoTienEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreHaoTienEcommerceDbSchemaMigrator
    : IHaoTienEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHaoTienEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HaoTienEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HaoTienEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
