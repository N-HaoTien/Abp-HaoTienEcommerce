using HaoTienEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HaoTienEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HaoTienEcommerceController : AbpControllerBase
{
    protected HaoTienEcommerceController()
    {
        LocalizationResource = typeof(HaoTienEcommerceResource);
    }
}
