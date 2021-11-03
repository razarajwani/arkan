using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class RoomMa
    {
        public RoomMa()
        {
            CourseMoveMas = new HashSet<CourseMoveMa>();
        }

        public int RoomCode { get; set; }
        public int Branchcode { get; set; }
        public string RoomNmA { get; set; }
        public int? DepCode { get; set; }
        public int? Capacity { get; set; }
        public string RoomNmE { get; set; }
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
