using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class EmpMa
    {
        public EmpMa()
        {
            CourseMoveMas = new HashSet<CourseMoveMa>();
            UserMas = new HashSet<UserMa>();
            VoucherMas = new HashSet<VoucherMa>();
        }

        public int EmpCode { get; set; }
        public int BranchCode { get; set; }
        public string EmpNmA { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? ItTypeCode { get; set; }
        public int? NatCode { get; set; }
        public int? CertifTypeCode { get; set; }
        public int? JobType { get; set; }
        public int? DepCode { get; set; }
        public string EmpNmE { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }

        public virtual BranchMa BranchCodeNavigation { get; set; }
        public virtual CertifTypeMa CertifTypeCodeNavigation { get; set; }
        public virtual ItTypeMa ItTypeCodeNavigation { get; set; }
        public virtual NatMa NatCodeNavigation { get; set; }
        public virtual ICollection<CourseMoveMa> CourseMoveMas { get; set; }
        public virtual ICollection<UserMa> UserMas { get; set; }
        public virtual ICollection<VoucherMa> VoucherMas { get; set; }
    }
}
