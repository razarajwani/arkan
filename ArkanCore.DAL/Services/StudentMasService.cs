using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.Services
{

    public class StudentMasService : GenericRepository<StudentMa>, IStudentMasService
    {
        public StudentMasService(ArkanDbContext context) : base(context)
        {
        }
    }
}
