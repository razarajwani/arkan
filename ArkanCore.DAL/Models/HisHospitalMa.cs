using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HisHospitalMa
    {
        public int HisId { get; set; }
        public int? BranchCode { get; set; }
        public int? HospitalCode { get; set; }
        public string HospitalNmA { get; set; }
        public int? Closed { get; set; }
        public DateTime? DatTime { get; set; }
        public string TransType { get; set; }
        public int? UserCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public int? OldUser { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
    }
}
