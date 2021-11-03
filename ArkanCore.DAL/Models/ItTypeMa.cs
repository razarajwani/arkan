using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ItTypeMa
    {
        public ItTypeMa()
        {
            EmpMas = new HashSet<EmpMa>();
        }

        public int ItTypeCode { get; set; }
        public string ItTypeNmA { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }

        public virtual ICollection<EmpMa> EmpMas { get; set; }
    }
}
