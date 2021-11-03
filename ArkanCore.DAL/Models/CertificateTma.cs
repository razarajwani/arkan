using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CertificateTma
    {
        public int CertificateTcode { get; set; }
        public int BranchCode { get; set; }
        public int? StudentCode { get; set; }
        public int? CertificateDate { get; set; }
        public string CardNo { get; set; }
        public int? CourseMoveCode { get; set; }
        public int? Done { get; set; }
        public int? CourseCode { get; set; }
        public int? CertificateDateH { get; set; }
        public int? CardSerial { get; set; }
        public int? Reprint { get; set; }
        public int? OldCourseCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public string Bnm { get; set; }
        public int? EmpId { get; set; }
        public DateTime? StampDateTime { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }

        public virtual BranchMa BranchCodeNavigation { get; set; }
    }
}
