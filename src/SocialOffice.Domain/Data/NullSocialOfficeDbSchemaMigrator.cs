using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SocialOffice.Data;

/* This is used if database provider does't define
 * ISocialOfficeDbSchemaMigrator implementation.
 */
public class NullSocialOfficeDbSchemaMigrator : ISocialOfficeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
