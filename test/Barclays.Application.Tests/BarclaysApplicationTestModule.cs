using Volo.Abp.Modularity;

namespace Barclays;

[DependsOn(
    typeof(BarclaysApplicationModule),
    typeof(BarclaysDomainTestModule)
    )]
public class BarclaysApplicationTestModule : AbpModule
{

}
