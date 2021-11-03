using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HealthResultMa
    {
        public int HealthResultCode { get; set; }
        public int? HealthResultDate { get; set; }
        public int Branchcode { get; set; }
        public int? StudentCode { get; set; }
        public int? HospitalCode { get; set; }
        public int? Suitable { get; set; }
        public int? CardPrinted { get; set; }
        public int? Result1 { get; set; }
        public int? Result2 { get; set; }
        public int? Result3 { get; set; }
        public int? Result4 { get; set; }
        public int? Result5 { get; set; }
        public int? Result6 { get; set; }
        public int? Result7 { get; set; }
        public int? Result8 { get; set; }
        public int? Result9 { get; set; }
        public int? Result10 { get; set; }
        public int? Result11 { get; set; }
        public int? Result12 { get; set; }
        public int? Result13 { get; set; }
        public int? Result14 { get; set; }
        public int? Result15 { get; set; }
        public int? Result16 { get; set; }
        public int? Result17 { get; set; }
        public int? Result18 { get; set; }
        public int? Result19 { get; set; }
        public int? Result20 { get; set; }
        public int? Result21 { get; set; }
        public int? Result22 { get; set; }
        public int? Result23 { get; set; }
        public int? Result24 { get; set; }
        public int? Result25 { get; set; }
        public int? Result26 { get; set; }
        public string RefuseReason { get; set; }
        public int? Result27 { get; set; }
        public int? Result28 { get; set; }
        public int? Result29 { get; set; }
        public int? Result30 { get; set; }
        public int? Result31 { get; set; }
        public int? Result32 { get; set; }
        public int Vaccindate1 { get; set; }
        public int Vaccindate2 { get; set; }
        public string LabNo { get; set; }
        public int? UserCode { get; set; }
        public DateTime? StmpDateTime { get; set; }
        public int? SadadNo { get; set; }
        public string HealthType { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public int? OldUser2 { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }

        public virtual BranchMa BranchcodeNavigation { get; set; }
    }
}
