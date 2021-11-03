using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ExamDegree
    {
        public int ExamDegree1 { get; set; }
        public int BranchCode { get; set; }
        public int StudentCode { get; set; }
        public int ReExamCode { get; set; }
        public int? CourseMoveCode { get; set; }
        public int Degree { get; set; }
        public string Note { get; set; }
        public int? EmpCode { get; set; }
        public int? ExamDegreeDate { get; set; }
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
