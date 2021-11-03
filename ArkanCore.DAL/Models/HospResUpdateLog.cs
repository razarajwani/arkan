using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class HospResUpdateLog
    {
        public int HospReslogCode { get; set; }
        public int? OldSuitable { get; set; }
        public int? NewSutiable { get; set; }
        public int? TransDate { get; set; }
        public string Reson { get; set; }
        public int? HospitalCode { get; set; }
        public int? StudentCode { get; set; }
        public int? UserAdd { get; set; }
        public int? UserEdit { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeEdit { get; set; }
        public DateTime? TimeDel { get; set; }
        public long? SessionAdd { get; set; }
        public long? SessionEdit { get; set; }
        public long? SessionDel { get; set; }
        public long? StudId { get; set; }
    }
}
