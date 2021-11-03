using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CourseMoveMa
    {
        public CourseMoveMa()
        {
            CourseStudentMas = new HashSet<CourseStudentMa>();
        }

        public int CourseMoveCode { get; set; }
        public int Branchcode { get; set; }
        public int CourseCode { get; set; }
        public int? Startdate { get; set; }
        public int? Enddate { get; set; }
        public int TeacherCode { get; set; }
        public int RoomCode { get; set; }
        public int? CourseNo { get; set; }
        public int? CourseType { get; set; }
        public int? TimeFrom { get; set; }
        public int? TimeTo { get; set; }
        public int? Depcode { get; set; }
        public int? LevelCode { get; set; }
        public int? CourseLangCode { get; set; }
        public int? OldCourseCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
        public int? EnddateH { get; set; }
        public int? ExpH { get; set; }
        public int? ExpM { get; set; }

        public virtual BranchMa BranchcodeNavigation { get; set; }
        public virtual CourseMa CourseMa { get; set; }
        public virtual EmpMa EmpMa { get; set; }
        public virtual RoomMa RoomMa { get; set; }
        public virtual ICollection<CourseStudentMa> CourseStudentMas { get; set; }
    }
}
