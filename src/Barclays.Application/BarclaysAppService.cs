using System;
using System.Collections.Generic;
using System.Text;
using Barclays.Localization;
using Volo.Abp.Application.Services;

namespace Barclays;

/* Inherit your application services from this class.
 */
public abstract class BarclaysAppService : ApplicationService
{
    protected BarclaysAppService()
    {
        LocalizationResource = typeof(BarclaysResource);
    }


}
