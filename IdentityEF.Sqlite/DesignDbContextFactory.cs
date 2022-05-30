using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TestIdentityEF.Data;

namespace IdentityEF.Sqlite
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("DataSource=mydatabase.db;",
                x => x.MigrationsAssembly("IdentityEF.Sqlite"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
