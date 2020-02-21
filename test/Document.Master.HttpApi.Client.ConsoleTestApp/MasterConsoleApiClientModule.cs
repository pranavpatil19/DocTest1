using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Document.Master.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MasterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MasterConsoleApiClientModule : AbpModule
    {
        
    }
}
