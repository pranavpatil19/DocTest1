using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Document.Master.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Document.Master.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Document.Master.Web.Pages.MasterPage
     */
    public abstract class MasterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<MasterResource> L { get; set; }
    }
}
