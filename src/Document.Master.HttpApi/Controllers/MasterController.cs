using Document.Master.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Document.Master.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MasterController : AbpController
    {
        protected MasterController()
        {
            LocalizationResource = typeof(MasterResource);
        }
    }
}