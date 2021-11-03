using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CertificateHma
    {
        public int CertificateHcode { get; set; }
        public int BranchCode { get; set; }
        public int? HospitalCode { get; set; }
        public int? StudentCode { get; set; }
        public int? CertificateDate { get; set; }
        public string CardNo { get; set; }
        public int? HealthResultCode { get; set; }
        public int? Done { get; set; }
        public int? CertificateDateH { get; set; }
        public string PaidNo { get; set; }
        public int? PaidDone { get; set; }
        public int? DelExpireDate { get; set; }
        public int? DelExpireDateH { get; set; }
        public int? CertStop { get; set; }
        public int? FineStop { get; set; }
        public int? FinePaid { get; set; }
        public string FineStopReason { get; set; }
        public int? Printdate { get; set; }
        public int? Temp { get; set; }
        public int? CertExpire { get; set; }
        public int? CertExpireH { get; set; }
        public int? EmpCode { get; set; }
        public int? Act { get; set; }
        public int? StopUserCode { get; set; }
        public string StopDate { get; set; }
        public int? SadadType { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public int? BadalFaeedCode { get; set; }
        public string BadelSadadNo { get; set; }
        public int? Mark { get; set; }
        public long? SessionDel { get; set; }
        public string CancelSadadNo { get; set; }
        public long? StudId { get; set; }

        public virtual BranchMa BranchCodeNavigation { get; set; }
    }
}
