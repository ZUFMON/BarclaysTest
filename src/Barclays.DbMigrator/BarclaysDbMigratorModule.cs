using Barclays.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Barclays.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BarclaysEntityFrameworkCoreModule),
    typeof(BarclaysApplicationContractsModule)
    )]
public class BarclaysDbMigratorModule : AbpModule
{

}
