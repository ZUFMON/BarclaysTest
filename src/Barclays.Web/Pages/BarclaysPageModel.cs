using Barclays.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Barclays.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BarclaysPageModel : AbpPageModel
{
    protected BarclaysPageModel()
    {
        LocalizationResourceType = typeof(BarclaysResource);
    }
}
