using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class AbsentMa
    {
        public int Absentcode { get; set; }
        public int BranchCode { get; set; }
        public int? CourseMoveCode { get; set; }
        public int? Absentdate { get; set; }
        public int? Studentcode { get; set; }
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
