using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SocialOffice.Web;

[Dependency(ReplaceServices = true)]
public class SocialOfficeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SocialOffice";
}
