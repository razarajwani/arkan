using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CourseTransLogMa
    {
        public int? FromCourseMove { get; set; }
        public int? ToCourseMove { get; set; }
        public int? TransDate { get; set; }
        public int? StudentCode { get; set; }
        public int? Branchcode { get; set; }
        public int? EmpCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }
    }
}
