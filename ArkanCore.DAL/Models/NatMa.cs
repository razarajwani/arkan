using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class NatMa
    {
        public NatMa()
        {
            EmpMas = new HashSet<EmpMa>();
        }

        public int NatCode { get; set; }
        public string NatNmA { get; set; }
        public string NatNmE { get; set; }
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
