using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestIdentityEF.Data;

namespace IdentityEF.SqlServer
{
    public static class IdentityEFExtension
    {
        public static IServiceCollection AddIdentityEFSqlServer(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"),
                x => x.MigrationsAssembly("IdentityEF.SqlServer")));
            return services;
        }
    }
}
