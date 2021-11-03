using System;
using System.Collections.Generic;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class VwHospitalBal
    {
        public int Branchcode { get; set; }
        public int HospitalCode { get; set; }
        public int OpenBal { get; set; }
        public int CardByCheck { get; set; }
        public int? HealthCard { get; set; }
        public int? BadalCard { get; set; }
        public int? Bal { get; set; }
    }
}
