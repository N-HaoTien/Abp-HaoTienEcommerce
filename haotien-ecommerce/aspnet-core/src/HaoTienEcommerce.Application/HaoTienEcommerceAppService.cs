using System;
using System.Collections.Generic;
using System.Text;
using HaoTienEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace HaoTienEcommerce;

/* Inherit your application services from this class.
 */
public abstract class HaoTienEcommerceAppService : ApplicationService
{
    protected HaoTienEcommerceAppService()
    {
        LocalizationResource = typeof(HaoTienEcommerceResource);
    }
}
