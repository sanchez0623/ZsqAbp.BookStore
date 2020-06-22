using System.Threading.Tasks;

namespace ZsqAbp.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
