using SocialOffice.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SocialOffice;

[DependsOn(
    typeof(SocialOfficeEntityFrameworkCoreTestModule)
    )]
public class SocialOfficeDomainTestModule : AbpModule
{

}
