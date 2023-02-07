using Volo.Abp.Modularity;

namespace HaoTienEcommerce.Admin;

[DependsOn(
    typeof(HaoTienEcommerceApplicationModule),
    typeof(HaoTienEcommerceDomainTestModule)
    )]
public class HaoTienEcommerceApplicationTestModule : AbpModule
{

}
