using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIdentityEF.Data;

namespace IdentityEF.Sqlite
{
    public static class IdentityEFExtension
    {
        public static IServiceCollection AddIdentityEFSqlite(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("IdentityConnection"),
                x => x.MigrationsAssembly("IdentityEF.Sqlite")));
            return services;
        }
    }
}
