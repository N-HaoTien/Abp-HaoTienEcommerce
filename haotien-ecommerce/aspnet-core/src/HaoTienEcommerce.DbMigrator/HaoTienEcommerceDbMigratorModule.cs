using HaoTienEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HaoTienEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HaoTienEcommerceEntityFrameworkCoreModule),
    typeof(HaoTienEcommerceApplicationContractsModule)
    )]
public class HaoTienEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
