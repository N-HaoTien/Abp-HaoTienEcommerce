using HaoTienEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HaoTienEcommerce.Admin.Permissions;

public class HaoTienEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HaoTienEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HaoTienEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HaoTienEcommerceResource>(name);
    }
}
