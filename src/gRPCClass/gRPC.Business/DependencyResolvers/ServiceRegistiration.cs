using gRPC.Business.Absrtract;
using gRPC.Business.Concrete;
using gRPC.Data.Abstract;
using gRPC.Data.Concrete;
using gRPC.Data.Concrete.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Business.DependencyResolvers
{
    public static class ServiceRegistiration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<GRPCDBContext>();

            services.AddScoped<ITaskDal, TaskDal>();
            services.AddScoped<ITaskService,TaskManeger>();
        }
    }
}
