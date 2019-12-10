using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyLibraryDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MyLibraryDb;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
