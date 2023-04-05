using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Barclays.Data;
using Volo.Abp.DependencyInjection;

namespace Barclays.EntityFrameworkCore;

public class EntityFrameworkCoreBarclaysDbSchemaMigrator
    : IBarclaysDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBarclaysDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BarclaysDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BarclaysDbContext>()
            .Database
            .MigrateAsync();
    }
}
