using SocialOffice.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SocialOffice.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SocialOfficeController : AbpControllerBase
{
    protected SocialOfficeController()
    {
        LocalizationResource = typeof(SocialOfficeResource);
    }
}
