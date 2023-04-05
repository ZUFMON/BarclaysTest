using Volo.Abp.Settings;

namespace Barclays.Settings;

public class BarclaysSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BarclaysSettings.MySetting1));
    }
}
