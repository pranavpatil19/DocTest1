﻿using Document.Master.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Document.Master.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MasterEntityFrameworkCoreDbMigrationsModule),
        typeof(MasterApplicationContractsModule)
        )]
    public class MasterDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
