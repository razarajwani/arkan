using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HospitalCheckMa
    {
        public int HospitalCheckCode { get; set; }
        public int BranchCode { get; set; }
        public int? HospitalCheckDate { get; set; }
        public int? HospitalCode { get; set; }
        public string CheckNo { get; set; }
        public int? CardCount { get; set; }
        public double? CheckValue { get; set; }
        public int? BankCode { get; set; }
        public int? CheckDate { get; set; }
        public int? PayType { get; set; }
        public int? HcardCount { get; set; }
        public int? Post { get; set; }
        public int? PostDate { get; set; }
        public int? UserPost { get; set; }
        public int? UserCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public string ImagePath { get; set; }
        public long? SessionDel { get; set; }

        public virtual BranchMa BranchCodeNavigation { get; set; }
    }
}
