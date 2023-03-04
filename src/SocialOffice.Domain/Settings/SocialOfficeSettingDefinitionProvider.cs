using Volo.Abp.Settings;

namespace SocialOffice.Settings;

public class SocialOfficeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SocialOfficeSettings.MySetting1));
    }
}
