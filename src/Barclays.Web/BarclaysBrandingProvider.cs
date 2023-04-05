using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Barclays.Web;

[Dependency(ReplaceServices = true)]
public class BarclaysBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Barclays";
}
