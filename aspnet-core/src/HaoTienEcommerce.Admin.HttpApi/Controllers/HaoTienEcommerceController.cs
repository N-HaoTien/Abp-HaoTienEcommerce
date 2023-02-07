using HaoTienEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HaoTienEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HaoTienEcommerceController : AbpControllerBase
{
    protected HaoTienEcommerceController()
    {
        LocalizationResource = typeof(HaoTienEcommerceResource);
    }
}
