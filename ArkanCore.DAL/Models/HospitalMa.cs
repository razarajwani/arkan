using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HospitalMa
    {
        public int HospitalCode { get; set; }
        public int Branchcode { get; set; }
        public string HospitalNmA { get; set; }
        public int? CardBal { get; set; }
        public int? Closed { get; set; }
        public int? RegionCode { get; set; }
        public int? OpenBal { get; set; }
        public int? LoginUserCode { get; set; }
        public decimal? Cr { get; set; }
        public int? ExpDateCr { get; set; }
        public bool? ActiveSadad { get; set; }
        public int? BaladyaNo { get; set; }
        public int? ExpDateBaladya { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public decimal? MossasaNum { get; set; }
        public int? ExpMossasa { get; set; }
        public decimal? MedicalNum { get; set; }
        public int? ExpMedical { get; set; }
        public string Mail { get; set; }
        public string Mobile { get; set; }
        public long? SessionDel { get; set; }

        public virtual BranchMa BranchcodeNavigation { get; set; }
    }
}
