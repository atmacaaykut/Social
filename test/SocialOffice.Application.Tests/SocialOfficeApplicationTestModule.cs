using Volo.Abp.Modularity;

namespace SocialOffice;

[DependsOn(
    typeof(SocialOfficeApplicationModule),
    typeof(SocialOfficeDomainTestModule)
    )]
public class SocialOfficeApplicationTestModule : AbpModule
{

}
