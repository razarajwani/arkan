using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HospitalRechargeOnLine
    {
        public int RechargeOnLineId { get; set; }
        public int RechargeDate { get; set; }
        public int BranchCode { get; set; }
        public int HospitalCode { get; set; }
        public decimal Amount { get; set; }
        public int? CardCount { get; set; }
        public int? UserCode { get; set; }
        public decimal? SadadNo { get; set; }
        public bool? Done { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
