using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HistCourseStudentMa
    {
        public int CourseStudentCode { get; set; }
        public int Branchcode { get; set; }
        public int CourseCode { get; set; }
        public int StudentCode { get; set; }
        public int? CourseDate { get; set; }
        public int CourseMoveCode { get; set; }
        public int EmpCode { get; set; }
        public int VoucherNo { get; set; }
        public int? CourseValue { get; set; }
        public int Depcode { get; set; }
        public int? Cancelvoucher { get; set; }
        public string Reason { get; set; }
        public int? Reprint { get; set; }
        public int? CourselangCode { get; set; }
        public int? LevelCode { get; set; }
        public int? CancelDate { get; set; }
        public int? Movecode { get; set; }
        public int? Movetype { get; set; }
        public int MoveSerial { get; set; }
        public DateTime? Movetime { get; set; }
        public int? HistorySerial { get; set; }
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
