using Intranet.Domain.Entities.Statistics;
using Intranet.Domain.Repository;
using Intranet.Infrastructure.Persistance;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRepository<ServiceTemporary>, ServiceTemporaryRepository>();

            services.AddTransient<IDbConnection>(db => new NpgsqlConnection(configuration.GetConnectionString("DefautConnectionString")));
        }
    }
}
