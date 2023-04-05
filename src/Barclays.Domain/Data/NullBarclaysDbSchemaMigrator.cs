using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Barclays.Data;

/* This is used if database provider does't define
 * IBarclaysDbSchemaMigrator implementation.
 */
public class NullBarclaysDbSchemaMigrator : IBarclaysDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
