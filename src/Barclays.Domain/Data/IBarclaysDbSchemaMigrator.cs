using System.Threading.Tasks;

namespace Barclays.Data;

public interface IBarclaysDbSchemaMigrator
{
    Task MigrateAsync();
}
