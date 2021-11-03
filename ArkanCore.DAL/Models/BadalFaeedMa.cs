using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class BadalFaeedMa
    {
        public int BadalFaeedCode { get; set; }
        public int CertificateHcode { get; set; }
        public int StudentCode { get; set; }
        public int HospitalCode { get; set; }
        public int BranchCode { get; set; }
        public int DateInLieu { get; set; }
        public int EmpCode { get; set; }
        public int? BadalDone { get; set; }
        public int? HealthResultDate { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public DateTime? StampDatetTime { get; set; }
        public long? SessionDel { get; set; }
        public string SadadNo { get; set; }
        public long? StudId { get; set; }
    }
}
