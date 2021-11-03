using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class OnlineInsert
    {
        public int OnLineCode { get; set; }
        public string BranchCode { get; set; }
        public string Idno { get; set; }
        public string StudentNma { get; set; }
        public string StudentNme { get; set; }
        public int NatCode { get; set; }
        public int Gender { get; set; }
        public int JobTypeCode { get; set; }
        public string IqamaJob { get; set; }
        public DateTime? StampDateTime { get; set; }
    }
}
