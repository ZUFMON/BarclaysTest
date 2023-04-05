using Barclays.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Barclays.Permissions;

public class BarclaysPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BarclaysPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BarclaysPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BarclaysResource>(name);
    }
}
