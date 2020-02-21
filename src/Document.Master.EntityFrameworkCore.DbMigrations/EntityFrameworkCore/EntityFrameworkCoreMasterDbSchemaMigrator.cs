using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Document.Master.Data;
using Volo.Abp.DependencyInjection;

namespace Document.Master.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreMasterDbSchemaMigrator 
        : IMasterDbSchemaMigrator, ITransientDependency
    {
        private readonly MasterMigrationsDbContext _dbContext;

        public EntityFrameworkCoreMasterDbSchemaMigrator(MasterMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}