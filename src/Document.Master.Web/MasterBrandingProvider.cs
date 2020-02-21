using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Document.Master.Web
{
    [Dependency(ReplaceServices = true)]
    public class MasterBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Master";
    }
}
