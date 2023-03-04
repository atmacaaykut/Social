using System.Threading.Tasks;

namespace SocialOffice.Data;

public interface ISocialOfficeDbSchemaMigrator
{
    Task MigrateAsync();
}
