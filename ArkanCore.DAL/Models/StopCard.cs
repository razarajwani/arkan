using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class StopCard
    {
        public int StopCardId { get; set; }
        public int Idno { get; set; }
        public int StudentCode { get; set; }
        public int BranchCode { get; set; }
        public int? StopCard1 { get; set; }
        public string StopNote { get; set; }
    }
}
