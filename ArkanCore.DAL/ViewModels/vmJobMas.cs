using ArkkanCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkkanCore.DAL.ViewModels
{
    public class vmJobMas
    {
        public int JobCode { get; set; }
        public string JobName { get; set; }
        public int JobTypeCode { get; set; }
        public string JobTypeNmA { get; set; }


        private ArkanDbContext _db = null;
        public vmJobMas()
        {
            this._db = new ArkanDbContext();
        }

        public List<vmJobMas> getList()
        {
            List<vmJobMas> JobList = _db.JobMas.Join(
                            _db.JobTypeMas,
                            a => a.JobTypeCode,
                            b => b.JobTypeCode,
                            (a, b) => new vmJobMas
                            {
                                JobCode = a.JobCode,
                                JobName = a.JobNmA,
                                JobTypeCode = b.JobTypeCode,
                                JobTypeNmA = b.JobTypeNmA
                            }
                        ).ToList();

            return JobList;
        }
    }
}
