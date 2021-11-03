using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServicesDependency(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<INatMasService, NatMasService>();
            services.AddScoped<IJobTypeMaService, JobTypeMaService>();
            services.AddScoped<IJobMaService, JobMaService>();
            services.AddScoped<IDepMasService, DepMasService>();
            services.AddScoped<IUserMasService, UserMasService>();
            services.AddScoped<IStudentMasService, StudentMasService>();


        }
    }
}
