using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ChangeIdlog
    {
        public int ChangeIdLogCode { get; set; }
        public int? ChangeDate { get; set; }
        public string Idold { get; set; }
        public int? Idtypeold { get; set; }
        public string Idnew { get; set; }
        public int? IdtypeNew { get; set; }
        public int? StudentCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }
    }
}
