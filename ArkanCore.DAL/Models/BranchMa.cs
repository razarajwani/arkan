using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class BranchMa
    {
        public BranchMa()
        {
            BaladyaMas = new HashSet<BaladyaMa>();
            CertificateHmas = new HashSet<CertificateHma>();
            CertificateTmas = new HashSet<CertificateTma>();
            CompanyMas = new HashSet<CompanyMa>();
            CourseMas = new HashSet<CourseMa>();
            CourseMoveMas = new HashSet<CourseMoveMa>();
            EmpMas = new HashSet<EmpMa>();
            HealthResultMas = new HashSet<HealthResultMa>();
            HospitalCheckMas = new HashSet<HospitalCheckMa>();
            HospitalMas = new HashSet<HospitalMa>();
            HospitalTransMas = new HashSet<HospitalTransMa>();
            RoomMas = new HashSet<RoomMa>();
            UserMas = new HashSet<UserMa>();
            VoucherMas = new HashSet<VoucherMa>();
        }

        public int BranchCode { get; set; }
        public string BranchNmA { get; set; }
        public int? TimeBegin { get; set; }
        public int? TimeEnd { get; set; }
        public int? CourseBefore { get; set; }
        public int? IncomeCut { get; set; }
        public int? CertType { get; set; }
        public int? CertTypeH { get; set; }
        public int? ReprintValue { get; set; }
        public int? TransValue { get; set; }
        public decimal? Remainder { get; set; }
        public int? HealthBefore { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public string ReturnVoucherDay { get; set; }
        public long? SessionDel { get; set; }

        public virtual ICollection<BaladyaMa> BaladyaMas { get; set; }
        public virtual ICollection<CertificateHma> CertificateHmas { get; set; }
        public virtual ICollection<CertificateTma> CertificateTmas { get; set; }
        public virtual ICollection<CompanyMa> CompanyMas { get; set; }
        public virtual ICollection<CourseMa> CourseMas { get; set; }
        public virtual ICollection<CourseMoveMa> CourseMoveMas { get; set; }
        public virtual ICollection<EmpMa> EmpMas { get; set; }
        public virtual ICollection<HealthResultMa> HealthResultMas { get; set; }
        public virtual ICollection<HospitalCheckMa> HospitalCheckMas { get; set; }
        public virtual ICollection<HospitalMa> HospitalMas { get; set; }
        public virtual ICollection<HospitalTransMa> HospitalTransMas { get; set; }
        public virtual ICollection<RoomMa> RoomMas { get; set; }
        public virtual ICollection<UserMa> UserMas { get; set; }
        public virtual ICollection<VoucherMa> VoucherMas { get; set; }
    }
}
