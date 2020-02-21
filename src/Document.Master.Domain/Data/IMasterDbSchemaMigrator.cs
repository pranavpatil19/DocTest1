using System.Threading.Tasks;

namespace Document.Master.Data
{
    public interface IMasterDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
