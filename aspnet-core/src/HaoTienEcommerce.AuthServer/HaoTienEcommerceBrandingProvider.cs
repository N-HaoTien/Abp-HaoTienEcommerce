using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace HaoTienEcommerce;

[Dependency(ReplaceServices = true)]
public class HaoTienEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HaoTienEcommerce";
}
