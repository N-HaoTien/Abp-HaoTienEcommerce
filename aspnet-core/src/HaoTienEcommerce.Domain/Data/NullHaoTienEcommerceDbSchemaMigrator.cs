using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HaoTienEcommerce.Data;

/* This is used if database provider does't define
 * IHaoTienEcommerceDbSchemaMigrator implementation.
 */
public class NullHaoTienEcommerceDbSchemaMigrator : IHaoTienEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
