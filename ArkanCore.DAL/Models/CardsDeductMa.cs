using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class CardsDeductMa
    {
        public int? DeductCode { get; set; }
        public int? Branchcode { get; set; }
        public int? DeductDate { get; set; }
        public int? HospitalCode { get; set; }
        public string DeductReason { get; set; }
        public int? CardsCount { get; set; }
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
