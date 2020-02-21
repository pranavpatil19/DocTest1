using Document.Master.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Document.Master.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MasterPageModel : AbpPageModel
    {
        protected MasterPageModel()
        {
            LocalizationResourceType = typeof(MasterResource);
        }
    }
}