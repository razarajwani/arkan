using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ReExamMa
    {
        public int ReExamCode { get; set; }
        public int BranchCode { get; set; }
        public int EmpCode { get; set; }
        public int RoomCode { get; set; }
        public int CourseCode { get; set; }
        public int CourseLangCode { get; set; }
        public int LevelCode { get; set; }
        public int ReEaxmDate { get; set; }
        public int TimeFrom { get; set; }
        public int TimeTo { get; set; }
        public int Year { get; set; }
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
