using ZsqAbp.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZsqAbp.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}