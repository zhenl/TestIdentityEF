using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIdentityEF.Data;

namespace IdentityEF.SqlServer
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(local);Database=TestIdentity;Trusted_Connection=True;MultipleActiveResultSets=true",
              x => x.MigrationsAssembly("IdentityEF.SqlServer"));
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
