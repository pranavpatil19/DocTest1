using Volo.Abp.Modularity;

namespace Document.Master
{
    [DependsOn(
        typeof(MasterApplicationModule),
        typeof(MasterDomainTestModule)
        )]
    public class MasterApplicationTestModule : AbpModule
    {

    }
}