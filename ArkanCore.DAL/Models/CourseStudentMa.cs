using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CourseStudentMa
    {
        public int CourseStudentCode { get; set; }
        public int Branchcode { get; set; }
        public int CourseCode { get; set; }
        public int StudentCode { get; set; }
        public int? CourseDate { get; set; }
        public int CourseMoveCode { get; set; }
        public int EmpCode { get; set; }
        public int VoucherNo { get; set; }
        public double? CourseValue { get; set; }
        public int Depcode { get; set; }
        public int? Cancelvoucher { get; set; }
        public string Reason { get; set; }
        public int? Oldvoucher { get; set; }
        public int? Reprint { get; set; }
        public int? CourselangCode { get; set; }
        public int? OldCourseCode { get; set; }
        public int? LevelCode { get; set; }
        public int? OldBranchCode { get; set; }
        public int? OldCourseMoveCode { get; set; }
        public int? CancelDate { get; set; }
        public DateTime? Getdatetime { get; set; }
        public int? DateBefore { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public double? Amount { get; set; }
        public double? Tax { get; set; }
        public double? TaxValue { get; set; }
        public int? CancelNo { get; set; }
        public int? CancelEmpCode { get; set; }
        public int? AbortDate { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public string CompanyNmA { get; set; }
        public string CompVatFile { get; set; }
        public long? SessionDel { get; set; }
        public string RandomPass { get; set; }
        public int? TriningType { get; set; }
        public int? PaymentType { get; set; }
        public long? StudId { get; set; }

        public virtual CourseMoveMa CourseMoveMa { get; set; }
    }
}
