using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.Services
{

    public class JobTypeMaService : GenericRepository<JobTypeMa>, IJobTypeMaService
    {
        public JobTypeMaService(ArkanDbContext context) : base(context)
        {
        }
    }
}
