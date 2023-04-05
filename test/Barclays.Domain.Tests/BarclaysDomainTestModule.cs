using Barclays.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Barclays;

[DependsOn(
    typeof(BarclaysEntityFrameworkCoreTestModule)
    )]
public class BarclaysDomainTestModule : AbpModule
{

}
