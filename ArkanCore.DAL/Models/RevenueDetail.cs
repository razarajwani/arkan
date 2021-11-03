using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class RevenueDetail
    {
        public int RevenueDetalisCode { get; set; }
        public int BranchCode { get; set; }
        public int Empcode { get; set; }
        public int RevenueDate { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal BankDeposit { get; set; }
        public decimal? AdvancePayment { get; set; }
        public decimal Remainder { get; set; }
        public string Notes { get; set; }
        public decimal? Replace { get; set; }
        public decimal? PrvRemainder { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
