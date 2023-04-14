using Volo.Abp.Modularity;

namespace HaoTienEcommerce;

[DependsOn(
    typeof(HaoTienEcommerceApplicationModule),
    typeof(HaoTienEcommerceDomainTestModule)
    )]
public class HaoTienEcommerceApplicationTestModule : AbpModule
{

}
