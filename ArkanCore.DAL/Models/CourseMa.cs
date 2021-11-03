using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CourseMa
    {
        public CourseMa()
        {
            CourseMoveMas = new HashSet<CourseMoveMa>();
        }

        public int CourseCode { get; set; }
        public int Branchcode { get; set; }
        public string CourseNmA { get; set; }
        public int? CourseType { get; set; }
        public int? FixExpDate { get; set; }
        public int? CourseExpire { get; set; }
        public int? Hours { get; set; }
        public int? Cost { get; set; }
        public int? Daywork { get; set; }
        public int? Days { get; set; }
        public string CourseNmE { get; set; }
        public int? DepCode { get; set; }
        public string CourseDesc { get; set; }
        public int? Courseno1 { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }

        public virtual BranchMa BranchcodeNavigation { get; set; }
        public virtual ICollection<CourseMoveMa> CourseMoveMas { get; set; }
    }
}
