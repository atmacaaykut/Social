using System;
using System.Collections.Generic;
using System.Text;
using SocialOffice.Localization;
using Volo.Abp.Application.Services;

namespace SocialOffice;

/* Inherit your application services from this class.
 */
public abstract class SocialOfficeAppService : ApplicationService
{
    protected SocialOfficeAppService()
    {
        LocalizationResource = typeof(SocialOfficeResource);
    }
}
