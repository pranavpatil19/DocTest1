using Document.Master.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Document.Master
{
    [DependsOn(
        typeof(MasterEntityFrameworkCoreTestModule)
        )]
    public class MasterDomainTestModule : AbpModule
    {

    }
}