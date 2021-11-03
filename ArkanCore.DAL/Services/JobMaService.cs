using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.Services
{

    public class JobMaService : GenericRepository<JobMa>, IJobMaService
    {
        public JobMaService(ArkanDbContext context) : base(context)
        {
        }
    }
}
