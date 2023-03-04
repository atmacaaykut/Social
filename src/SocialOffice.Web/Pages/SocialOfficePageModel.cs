using SocialOffice.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SocialOffice.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SocialOfficePageModel : AbpPageModel
{
    protected SocialOfficePageModel()
    {
        LocalizationResourceType = typeof(SocialOfficeResource);
    }
}
