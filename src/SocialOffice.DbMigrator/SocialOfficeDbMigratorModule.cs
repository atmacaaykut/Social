using SocialOffice.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SocialOffice.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SocialOfficeEntityFrameworkCoreModule),
    typeof(SocialOfficeApplicationContractsModule)
    )]
public class SocialOfficeDbMigratorModule : AbpModule
{

}
