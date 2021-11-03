using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class TransStudentFbranch
    {
        public int? TransBranchCode { get; set; }
        public int? StudentcodeOld { get; set; }
        public int? StudentCodeNew { get; set; }
        public int? FromBranch { get; set; }
        public int? ToBranCh { get; set; }
        public int? EmpCode { get; set; }
        public int? TransDate { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
