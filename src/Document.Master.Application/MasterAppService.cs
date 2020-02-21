using System;
using System.Collections.Generic;
using System.Text;
using Document.Master.Localization;
using Volo.Abp.Application.Services;

namespace Document.Master
{
    /* Inherit your application services from this class.
     */
    public abstract class MasterAppService : ApplicationService
    {
        protected MasterAppService()
        {
            LocalizationResource = typeof(MasterResource);
        }
    }
}
