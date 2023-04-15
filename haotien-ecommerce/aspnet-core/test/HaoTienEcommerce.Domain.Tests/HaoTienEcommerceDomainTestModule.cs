using HaoTienEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HaoTienEcommerce;

[DependsOn(
    typeof(HaoTienEcommerceEntityFrameworkCoreTestModule)
    )]
public class HaoTienEcommerceDomainTestModule : AbpModule
{

}
