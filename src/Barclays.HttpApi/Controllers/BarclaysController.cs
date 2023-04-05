using Barclays.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Barclays.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BarclaysController : AbpControllerBase
{
    protected BarclaysController()
    {
        LocalizationResource = typeof(BarclaysResource);
    }
}
