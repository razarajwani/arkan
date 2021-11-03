using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class IncomeExam
    {
        public int IncomeExamCode { get; set; }
        public int VoucherDate { get; set; }
        public int BranchCode { get; set; }
        public int EmpCode { get; set; }
        public int Value { get; set; }
        public int ReExamCode { get; set; }
        public int StudentCode { get; set; }
        public int? Cancel { get; set; }
        public string CancelReason { get; set; }
        public int? CancelDate { get; set; }
        public int DepCode { get; set; }
        public int VoucherNo { get; set; }
        public int? Reprint { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? UserDel { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }
    }
}
